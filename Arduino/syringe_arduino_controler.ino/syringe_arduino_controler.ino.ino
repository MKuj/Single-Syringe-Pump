#include <TimerThree.h>
#include <TimerOne.h>
#include <AccelStepper.h>

//Home Switches PINs:
#define home_switch_stepper2 12     //stepper 2 home_switch
#define home_switch_stepper1 13     //stepper 1 home_switch

///////////////////////////////////////////////////////////////
#define enable_pin  2                  //enable pin 1
#define enable_pin2 11                 //enable pin 2

//////////////////////////////////////////////////////////////
#define half 3
#define quarter 4
//////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////
#define half2   9
#define quarter2 10
///////////////////////////////////////////////////////////////

//Stepper Motors:
AccelStepper stepper(1, 5, 6); // step, dir
AccelStepper stepper2(1, 8, 7); // step, dir

//Variables used in programm:
int i = 0;
int j = 0;
unsigned long stepp = 1;
unsigned long stepp2 = 1;

long initial_homing1 = -1;
long initial_homing2 = -1;

int st1 = 1;
int st2 = 1;

unsigned long start1, start2;

unsigned long stop_pos = 0;
unsigned long stopPos = 108280;
unsigned long stopPos2 = 108280;

int calibration = 0;
int calibration2 = 0;

//////////////////////////////////////////////////////////
void setup()
{
  Serial.begin(115200);

  //Sttepers setup:
  stepper.setMaxSpeed(5000.0);
  stepper.setAcceleration(3000);
  stepper.setSpeed(1000);

  stepper2.setMaxSpeed(5000.0);
  stepper2.setAcceleration(3000);
  stepper2.setSpeed(1000);

  //Switches setup:
  pinMode(home_switch_stepper1, INPUT_PULLUP);
  pinMode(home_switch_stepper2, INPUT_PULLUP);

  pinMode(half, OUTPUT);
  pinMode(quarter, OUTPUT);
  digitalWrite(quarter, HIGH);
  digitalWrite(half, LOW);

  pinMode(half2, OUTPUT);
  pinMode(quarter2, OUTPUT);
  digitalWrite(quarter2, HIGH);
  digitalWrite(half2, LOW);

  delay(5);

  //Initializing Timers default:
  Timer1.initialize(41000);
  Timer3.initialize(500000);

  //Timers interrupt:
  Timer1.attachInterrupt(move11);
  Timer3.attachInterrupt(move22);
}
//////////////////////////////////////////////////////////

void forward1() {
  stepp += st1;
  stepper.moveTo(stepp);
  stepper.run();
}

int switch_pin;
int switch_pin2;

void speed_change(int pin, unsigned long pos) {
  if (pin == 2) {
    digitalWrite(quarter, LOW);
    digitalWrite(half, HIGH);
    stepper.setCurrentPosition(pos);
    stepp = stepper.currentPosition();
    calibration = 1;
  } else if (pin == 1) {
    digitalWrite(quarter, HIGH);
    digitalWrite(half, LOW);
    stepper.setCurrentPosition(pos);
    stepp = stepper.currentPosition();
    calibration = 0;
  } else {
    digitalWrite(quarter, LOW);
    digitalWrite(half, LOW);
    stepper.setCurrentPosition(pos);
    stepp = stepper.currentPosition();
    calibration = 3;
  }
}

void speed_change2(int pin, unsigned long pos) {
  if (pin == 2) {
    digitalWrite(quarter2, LOW);
    digitalWrite(half2, HIGH);
    stepper2.setCurrentPosition(pos);
    stepp2 = stepper2.currentPosition();
    calibration2 = 1;
  } else if (pin == 1) {
    digitalWrite(quarter2, HIGH);
    digitalWrite(half2, LOW);
    stepper2.setCurrentPosition(pos);
    stepp2 = stepper2.currentPosition();
    calibration2 = 0;
  } else {
    digitalWrite(quarter2, LOW);
    digitalWrite(half2, LOW);
    stepper2.setCurrentPosition(pos);
    stepp2 = stepper2.currentPosition();
    calibration2 = 3;
  }
}

int add = 0;
int add2 = 0;

unsigned long newPos = 0;
unsigned long newPos2 = 0;

//Timers interrupt methods:
void move11() {
  switch (i) {
    case 1:
      digitalWrite(enable_pin, LOW);
      if (stepper.currentPosition() != stopPos) {
        forward1();
      }
      else
        i = 9;
      break;

    case 2:
      digitalWrite(enable_pin, LOW);
      if (stepper.currentPosition() == start1) {
        stepper.stop();
        stepp = stepper.currentPosition();
        stepper.setCurrentPosition(stepp);
        i = 5;
      } else {
        stepp += st1;
        stepper.moveTo(stepp);
        stepper.run();
      }
      break;

    case 3:
      digitalWrite(enable_pin, LOW);
      if (digitalRead(home_switch_stepper1)) {
        stepper.moveTo(initial_homing1);
        initial_homing1 --;
        stepper.run();
      } else {
        digitalWrite(8, HIGH);
        stepper.setCurrentPosition(0);
        stepper.stop();
        stepp = 0;
        i = 4;
      }
      break;

      break;

    case 10:
      digitalWrite(enable_pin, LOW);
      if (digitalRead(home_switch_stepper1)) {
        stepp += st1;
        stepper.moveTo(stepp);
        stepper.run();
      }
      else {
        i = 0;
      }
      break;

    case 7:
      digitalWrite(enable_pin, LOW);
      if (stepper.currentPosition() != stopPos) {
        if (stepper.currentPosition() != stop_pos)
        {
          forward1();
        }
        else {
          i = 8;
        }
      } else {
        i = 9;
      }
      break;

    case 11:
      speed_change(switch_pin, newPos);
      i = 0;
      break;
  }
}


void move22() {
  switch (j) {
    case 1:
      digitalWrite(enable_pin2, LOW);
      if (stepper2.currentPosition() != stopPos2) {
        stepp2 += st2;
        stepper2.moveTo(stepp2);
        stepper2.run();
      }
      else
        j = 9;

      break;

    case 2:
      digitalWrite(enable_pin2, LOW);
      if (stepper2.currentPosition() == start2) {
        stepp2 = stepper2.currentPosition();
        stepper2.setCurrentPosition(stepp2);
        stepper2.stop();
        j = 5;
      } else {
        stepp2 += st2;
        stepper2.moveTo(stepp2);
        stepper2.run();
      }
      break;

    case 3:
      digitalWrite(enable_pin2, LOW);
      if (digitalRead(home_switch_stepper2)) {
        stepper2.moveTo(initial_homing2);
        initial_homing2 --;
        stepper2.run();
      } else {
        stepper2.setCurrentPosition(0);
        stepper2.stop();
        stepp2 = 0;
        j = 4;

      }
      break;

    case 10:
      digitalWrite(enable_pin2, LOW);
      if (digitalRead(home_switch_stepper2)) {
        stepp2 += st2;
        stepper2.moveTo(stepp2);
        stepper2.run();
      }
      else {
        j = 0;
      }
      break;

    case 11:
      speed_change2(switch_pin2, newPos2);
      j = 0;
      break;
  }
}

int acce = 500000;
int speedo = 1000;

int move_period = 900;
int homing_period = 900;

//Main loop:
void loop()
{ 
  if (i == 0)
    digitalWrite(enable_pin, HIGH);
  if (j == 0)
    digitalWrite(enable_pin2, HIGH);
  String k = "";
  if (Serial.available() > 0) {

    k = Serial.readStringUntil('\n');
    unsigned long period = k.substring(2, 10).toInt();
    int message = k.substring(0, 2).toInt();
    switch (message) {
      case 15:
        switch_pin = k.substring(2,3).toInt();
        newPos = k.substring(3,11).toInt();
        i = 11;
        break;

      case 25:
        switch_pin2 = k.substring(2,3).toInt();
        newPos2 = k.substring(3,11).toInt();
        j = 11;
        break;

      case 13:        //bolus mode stepper 1
        add = calibration;
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        st1 = 1;
        i = 7;
        
        break;

      case 12:          //bolus stop position
        stop_pos = period;
        break;

      case 14:          //hard stop position 1
        stopPos = period;
        break;

      case 24:          //hard stop position 2
        stopPos2 = period;
        break;

      case 10:          //stepper 1 injection
        add = calibration;
        stepper.setSpeed(50);
        stepper.setAcceleration(50);
        st1 = 1;
        i = 1;
        break;

      case 20:          //stepper 2 injection
        add2 = calibration2;
        stepper2.setSpeed(50);
        stepper2.setAcceleration(50);
        st2 = 1;
        j = 1;
        break;

      case 50:           //stepper 1 forward
      add = calibration;
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        Timer1.setPeriod(move_period);
        st1 = 1;
        i = 1;
        break;

      case 54:            //stepper 1 stop
        i = 0;
        stepp = stepper.currentPosition();
        stepper.setCurrentPosition(stepp);
        st1 = 1;
        digitalWrite(enable_pin, HIGH);
        delay(5);
        stepper.stop();
        break;

      case 51:            //stepper 1 backward
      add = calibration;
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        delay(5);
        Timer1.setPeriod(move_period);
        st1 = -1;
        i = 10;
        break;

      case 60:            //stepper 2 forward
      add2 = calibration2;
        stepper2.setSpeed(speedo);
        stepper2.setAcceleration(acce);
        delay(5);
        Timer3.setPeriod(move_period);
        j = 1;
        st2 = 1;
        break;

      case 61:              //stepper 2 backward
      add2 = calibration2;
        stepper2.setSpeed(speedo);
        stepper2.setAcceleration(acce);
        delay(5);
        Timer3.setPeriod(move_period);
        j = 10;
        st2 = -1;
        break;

      case 55:              //stepper 2 stop
        j = 0;
        stepp2 = stepper2.currentPosition();
        stepper2.setCurrentPosition(stepp2);
        stepper2.stop();
        st2 = 1;
        break;

      case 80:             //set timer 1 (stepper1) period
        Timer1.setPeriod(period);
        break;

      case 90:            //set timer 2 (stepper2) period
        Timer3.setPeriod(period);
        break;

      case 30:            //stepper 1 homing
        add = calibration;
        stepper.stop();
        stepper.setCurrentPosition(0);
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        Timer1.setPeriod(homing_period);
        delay(5);
        i = 3;
        break;

      case 40:            //stepper 2 homing
      add2 = calibration2;
        stepper2.stop();
        stepper2.setCurrentPosition(0);
        stepper2.setSpeed(speedo);
        stepper2.setAcceleration(acce);
        Timer3.setPeriod(homing_period);
        delay(5);
        j = 3;
        break;

      case 31:          //move stepper 1 to start position
        add = calibration;
        stepper.stop();
        start1 = period;
        if (start1 < stepper.currentPosition()) {
          st1 = -1;
        } else {
          st1 = 1;
        }
        stepper.setSpeed(speedo);
        stepper.setAcceleration(acce);
        Timer1.setPeriod(move_period);
        delay(5);
        i = 2;
        break;

      case 41:          //move stepper 2 to start position
      add2 = calibration2;
        stepper2.stop();
        start2 = period;
        if (start2 < stepper2.currentPosition()) {
          st2 = -1;
        } else {
          st2 = 1;
        }
        stepper2.setSpeed(speedo);
        stepper2.setAcceleration(acce);
        Timer3.setPeriod(move_period);
        delay(5);
        j = 2;
        break;

      case 35:            //get current steppers position
        String mes = "";
        if (i == 4) {
          mes += "12:";
          i = 0;
        } else if (i == 5) {
          mes += "14:";
          i = 0;
        } else if (i == 8) {
          mes += "16:";
          i = 0;
        } else if (i == 9) {
          mes += "18:";
          i = 0;
        }
        else {  //if(i==6 ||i==1 || i==10 || i==7){
          mes += "1:";
          mes += stepper.currentPosition()+add;
        }

        if (j == 4) {
          mes += "\n13:";
          j = 0;
        } else if (j == 5) {
          mes += "\n15:";
          j = 0;
        } else if (j == 9) {
          mes += "\n19:";
          j = 0;
        }
        else{ //if (j == 6 || j == 1 | j == 10) {
          mes += "\n2:";
          mes += stepper2.currentPosition()+ add2;
        }
        Serial.println(mes);
        break;
    }

  }
}
