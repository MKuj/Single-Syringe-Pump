#include <TimerOne.h>
#include <AccelStepper.h>
#include <EEPROM.h>

byte addr = 0;

//Home Switches PIN:
#define H_SWITCH 13                 //stepper homming switch
#define ENABLE  2                  //enable pin
#define HALF 3
#define QUARTER 4
#define STEP 5
#define DIR 6
//////////////////////////////////////////////////////////////

//Stepper Motors:
AccelStepper stepper(1, 5, 6); // (step, dir)

long lastPosition = 0;

//Variables used in programm:
int i = 0;
unsigned long n_pos = 1;

long initial_homing1 = -1;

int st1 = 1;

unsigned long start_position;

unsigned long bolusStopPosition = 0;
unsigned long stopPos = 108280;


int acce = 3000;
int speedo = 5000;

int calibration = 0;
//////////////////////////////////////////////////////////////
void setup()
{
  Serial.begin(115200);

  //Sttepers setup:
  stepper.setMaxSpeed(1100);
  stepper.setAcceleration(acce);
  stepper.setSpeed(speedo);

  EEPROM.get(addr, n_pos);
  stepper.setCurrentPosition(n_pos);

  //Switches setup:
  pinMode(H_SWITCH, INPUT_PULLUP);

  pinMode(HALF, OUTPUT);
  pinMode(QUARTER, OUTPUT);
  digitalWrite(QUARTER, HIGH);
  digitalWrite(HALF, LOW);

  delay(5);

  //Initializing Timers default:
  Timer1.initialize(41000);

  //Timers interrupt:
  Timer1.attachInterrupt(move_func);  
}

//////////////////////////////////////////////////////////////

//VARIABLES
int s = 1;
int add = 0;
long actlPosition = 0;
int changes = 0;

int move_period = 900;
int homing_period = 900;

String mes = "";

//////////////////////////////////////////////////////////////
//FUNC
void forward(void);

void savePosition(void);

void speed_change(int pin);

void move_func(void);

//////////////////////////////////////////////////////////////

//MAIN LOOP
void loop()
{ 
  String k = "";
  if (Serial.available() > 0) {
    k = Serial.readStringUntil('\n');

    unsigned long message = k.substring(2, 10).toInt();
    int code = k.substring(0, 2).toInt();
    switch (code) {
      //CHECK IF DEVICE IS CONNECTED PROPERLY
      case 88:
        mes = "<connected>";
        Serial.println(mes);
        break;

      //START INJECTION IN BOLUS MODE
      case 40:        //bolus mode stepper 1
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        st1 = 1;
        lastPosition = stepper.currentPosition();
        i = 7;
        
        break;

      //BOLUS STOP POSITION
      case 12:         
        bolusStopPosition = message;
        break;

      //SET MAXIMUM (STOP) POSITION
      case 14:         
        stopPos = message;
        break;

      //START INJECTION
      case 10:         
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        st1 = 1;
        lastPosition = stepper.currentPosition();        
        i = 1;
        break;

      //MOVE FORWARD
      case 20:      
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        Timer1.setPeriod(move_period);
        st1 = 1;
        i = 1;
        break;

      //STEPPER STOP
      case 54:          
        i = 0;
        actlPosition = stepper.currentPosition();
        add = calibration*(actlPosition - lastPosition); 
        stepper.setCurrentPosition(actlPosition+add);
        lastPosition = actlPosition+add;
        n_pos = lastPosition;
        st1 = 1;
        digitalWrite(ENABLE, HIGH);
        delay(5);
        stepper.stop();
        savePosition();
        break;

      //MOVE BACKWARD
      case 22:           
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        Timer1.setPeriod(move_period);
        st1 = -1;
        i = 10;   
        break;

      //SET PERIOD
      case 80:             
        Timer1.setPeriod(message);
        break;

      //HOMING
      case 30:
        stepper.setCurrentPosition(0);
        n_pos = 0  ;          
        stepper.stop();
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        initial_homing1 = -1;
        Timer1.setPeriod(homing_period);
        delay(5);
        i = 3;
        break;

      //MOVE STEPPER TO START POSITION
      case 32:          
        stepper.stop();
        start_position = message;
        if (start_position < stepper.currentPosition()+add) {
          st1 = -1;
        } else {
          st1 = 1;
        }
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        Timer1.setPeriod(move_period);
        delay(5);
        changes = 0;
        i = 2;
        break;

      //CHANGE STEPPER RESOLUTION
      case 16:
        s = k.substring(2,3).toInt();
        speed_change(s);
        break;
      
      //SEND MESSAGE
      case 35:           
        mes = "";
        if (i == 4) {
          digitalWrite(ENABLE, HIGH);
          mes += "12:";
          savePosition();
        } else if (i == 5) {
          digitalWrite(ENABLE, HIGH);
          mes += "14:";
          savePosition();
          i = 0;
        } else if (i == 8) {
          digitalWrite(ENABLE, HIGH);
          mes += "16:";
          savePosition();
        } else if (i == 9) {
          digitalWrite(ENABLE, HIGH);
          mes += "18:";
          savePosition();
        }
        else { 
          mes += "1:";
          actlPosition = stepper.currentPosition();
          add = calibration*(actlPosition - lastPosition); 
          mes += actlPosition+ add;      
        }
    
        Serial.println(mes);   
        break;
    }
  }
}
//////////////////////////////////////////////////////////////


//TIMER INTERRUPT:
void move_func() {
  switch (i) {
    case 1:
      digitalWrite(ENABLE, LOW);
      actlPosition = stepper.currentPosition();
      add = calibration*(actlPosition - lastPosition);
      if((actlPosition+add) != stopPos) {
        forward();
      }
      else
        i = 9;
      break;

    case 2:
      digitalWrite(ENABLE, LOW);
      add = calibration*(actlPosition - lastPosition); 
      if (stepper.currentPosition()+add == start_position) {
        stepper.stop();
        n_pos = stepper.currentPosition()+add;
        stepper.setCurrentPosition(n_pos);
        lastPosition = n_pos;
        i = 5;
      } 
      else if(stepper.currentPosition()+add > start_position)
      {
        if((stepper.currentPosition()+add)-start_position<0.1*start_position && changes == 0){
          speed_change(2);
        }
        if((stepper.currentPosition()+add)-start_position<0.02*start_position && changes == 1){
          speed_change(1);

        }
        n_pos += st1;
        stepper.moveTo(n_pos);
        stepper.run();
      }
      else {
        if(start_position-(stepper.currentPosition()+add)<0.1*start_position && changes == 0){
          speed_change(2);
        }
        if(start_position-(stepper.currentPosition()+add)<0.02*start_position && changes == 1){
          speed_change(1);
        }
        n_pos += st1;
        stepper.moveTo(n_pos);
        stepper.run();
      }
      break;

    case 3:
      digitalWrite(ENABLE, LOW);
      if (digitalRead(H_SWITCH)) {
        stepper.moveTo(initial_homing1);
        initial_homing1 --;
        stepper.run();
      } else {
        stepper.setCurrentPosition(0);
        stepper.stop();
        n_pos = 0;
        lastPosition = n_pos;
        initial_homing1 = n_pos;
        i = 6;
      }
      break;
      
    case 6:
      digitalWrite(ENABLE, LOW);
      if (!digitalRead(H_SWITCH)) {
        stepper.moveTo(initial_homing1);
        initial_homing1++;
        stepper.run();
      } else {
        digitalWrite(8, HIGH);
        stepper.setCurrentPosition(0);
        stepper.stop();
        n_pos = 0;
        lastPosition = n_pos;
        i = 4;
        savePosition();
      }
      break;

      break;

    case 10:
      digitalWrite(ENABLE, LOW);
      if (digitalRead(H_SWITCH)) {
        n_pos += st1;
        stepper.moveTo(n_pos);
        stepper.run();
      }
      else {
        i = 0;
        stepper.setCurrentPosition(0);
        savePosition();
      }
      break;

    case 7:
      digitalWrite(ENABLE, LOW);
      actlPosition = stepper.currentPosition();
      add = calibration*(actlPosition - lastPosition); 
      if (actlPosition+add != stopPos) {
        if (actlPosition+add != bolusStopPosition)
        {
          forward();
        }
        else {
          i = 8;
        }
      } else {
        i = 9;
      }
      break;
  }
}

//////////////////////////////////////////////////////////////
void speed_change(int pin)
{
  actlPosition = stepper.currentPosition();
  add = calibration*(actlPosition - lastPosition); 
  n_pos = stepper.currentPosition() +add;
  stepper.setCurrentPosition(n_pos);
  lastPosition = n_pos;
  if (pin == 2) {
    digitalWrite(QUARTER, LOW);
    digitalWrite(HALF, HIGH);
    calibration = 1;
    changes = 1;
  } else if (pin == 1) {
    digitalWrite(QUARTER, HIGH);
    digitalWrite(HALF, LOW);
    changes = 2;
    calibration = 0;
  } else {
    digitalWrite(QUARTER, LOW);
    digitalWrite(HALF, LOW);
    calibration = 3;
  } 
}
//////////////////////////////////////////////////////////////
void savePosition(){
  EEPROM.put(addr, stepper.currentPosition());
}
//////////////////////////////////////////////////////////////
void forward() {
  n_pos += st1;
  stepper.moveTo(n_pos);
  stepper.run();
}
