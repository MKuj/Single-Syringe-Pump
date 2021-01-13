# Open Source Syringe Pump App

SyringePumpApp is a C# open source application to control a dedicated Arduino Leonardo based device.
Whole process and necessary parts to built a Syringe Pump device are described in our [publication](https://github.com/MKuj/Single-Syringe-Pump/edit/main/README.md)

The application works only on computers with Windows system.

<img align="right" width="240" height="342" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MainInterface.PNG">


## Installation

To run application and use Syringe Pump follow the steps:
- Download ZIP and extract file.
- Open Ardiono IDE and connect your Arduino Leonardo board.
- Open included Arduino file (.ino) and upload it on microcontroller. 
- Run SyringeApp.exe

You can also compile it by yourself. We publish a C# project written in Visual Studio Community Edition IDE.

## Usage

The pump can be used in experiments where it is necessary to use flows from 0.01 ml to 20 ml.
The application was created to control the flow directly during the measurements.

### Connection

<img align="right" width = "191" height = "79" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/connectionStatus.PNG">

Information about the connection status with the device. The software automatically detects Arduino Leonardo boards connected to the computer and connects to the correct one (with the syringe pump controller software installed).

**Change to Arduino Uno board**

Proposed sytem will work on both Arduino Leonardo and Uno boards. All you need to do is change a VID and PID values in **App.config** in Visual Studio Project and recompile solution.

```xml
...
  <appSettings>
    <add key="Leonardo_VID" value="VID_2341"/>    <!--Change to your Arduino UNO VID-->
    <add key="Leonardo_PID" value="PID_8036"/>    <!--Change to your Arduino UNO PID-->
    ...
  </appSettings>
...
```


### Settings

#### Syringe

<img align="right" width = "272" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/SettingsPanel.PNG">

Combobox for selection of a predefined syringe loaded from csv file.

The software use external .csv file to store a user defined syringes, so it is possible to add your own syringe by selecting a **Add new syringe** from the Combobox list.

#### Speed

Numeric UpDown control for defining the injection speed.

#### Bolus Mode

<img align="right" width = "269" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/bolusMode.PNG">

Button for changing from **constant flow mode** to a **bolus mode**.

Bolus mode is an injection of a discrete amount (volume) of the solution with the chosen flow rate. The main difference between the **constant flow rate mode** and the **bolus mode** is that for the latter after the injection of a specific volume of solution the pump stops. 

### Move Panel
The move panel contains controls for handling the position of the push element of pump.

#### Step + / Step -
Moving the push element forward or backward during the button is press.

<img align="right" width="273" height="205" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MovePanel3.png">

#### Start Position
Moving the push element to the start position, which is user defined when adding a syringe to the list.

#### Home
Moving the push element to home position. This is necessary to properly calibrate the pump and should be done after any unexpected shutdowns or device error when real position is different then shown in software (e.g. manually moving the push element). In other cases the device will save current position of push element in Arduino EEPROM memmory.

#### Move speed
Changing resolution of stepper motor.

<img align="right" width="273" height="251" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/RunConsole2.PNG">

### Start / Stop

Start and stop buttons enable the liquid injection process to be started with the set parameters or stopped.


### Run Console

The panel displays information about the current progress of the process and the elapsed time.

### Add new syringe

<img align="right" width="273" height="203" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/Add new syringe interface2.PNG">

After selecting a **Add new syringe** from the Syringe Combobox list a new window appear. 

The controls in the **Add new syringe** window allow you to define a new syringe by entering the name, scale length (in mm) and volume. Then, using the pushing element movement buttons, set the element to the injecting start position and  press the **Set current position as start position**. 

Press **OK** to add a new syringe to .csv file. Syringe Combobox will refresh and new syringe will be selected.
