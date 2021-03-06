# Open Source Syringe Pump App

SyringePumpApp is a C# open source application to control a dedicated Arduino Leonardo based device.
The whole process and the necessary parts to build the Syringe Pump device are described in our publication: "Low-cost, programmable infusion pump with bolus mode for in-vivo imaging".

The application only works on computers operating with the Windows system.

<img align="right" width="240" height="342" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MainInterface.PNG">


## Installation

To run the application and use the Syringe Pump, perform the following steps:
- Download [ZIP](https://github.com/MKuj/Single-Syringe-Pump/tree/main/Application) and extract the file.
- Open the Ardiono IDE and connect the Arduino Leonardo board.
- Open the included Arduino file ([.ino](https://github.com/MKuj/Single-Syringe-Pump/tree/main/Arduino)) and upload it into the microcontroller. 
- Run SyringeApp.exe

You can also compile it by yourself. We publish a [C# project](https://github.com/MKuj/Single-Syringe-Pump/tree/main/C%23) written in Visual Studio Community Edition IDE.

## Usage

The pump can be used in experiments where it is necessary to use flows ranging from 0.01 mL to 20 mL.
The application was created to control the flow directly during the measurements.

### Connection

<img align="right" width = "191" height = "79" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/connectionStatus.PNG">

The information about the connection status with the device. The software automatically detects the Arduino Leonardo boards connected to the computer and connects to the correct one (with the syringe pump controller software installed).

**Change to Arduino Uno board**

The proposed sytem will work on both Arduino Leonardo and Uno boards. All that is required is to change the VID and PID values in the **App.config** in Visual Studio Project and recompile the solution.

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

The combobox for the selection of a predefined syringe, loaded from a csv file.

The software uses an external .csv file to store user defined syringes, so it is possible to add your own syringe by selecting the **Add new syringe** from the Combobox list.

#### Speed

The numeric UpDown control for defining the injection speed.

#### Bolus Mode

<img align="right" width = "269" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/bolusMode.PNG">

The button for changing from **constant flow mode** to the **bolus mode**.

The bolus mode is an injection of a discrete amount (volume) of the solution with the chosen flow rate. The main difference between the **constant flow rate mode** and the **bolus mode** is that for the latter, after the injection of a specific volume of solution, the pump stops. 

### Move Panel
The move panel contains the controls for handling the position of the push element of the pump.

#### Step + / Step -
Moves the push element forward or backward during the pressing of the buttons.

<img align="right" width="273" height="205" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MovePanel3.png">

#### Start Position
Moves the push element to the start position, which is user defined when adding a syringe to the list.

#### Home
Moves the push element to home position. This is necessary to properly calibrate the pump and it should be done after any unexpected shutdowns or device error, when the real position is different than shown in the software (e.g. manually moving the push element). In other cases, the device will save the current position of the push element in the Arduino EEPROM memmory.

#### Move speed
Changing the resolution of stepper motor.

<img align="right" width="273" height="251" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/RunConsole2.PNG">

### Start / Stop

The start and stop buttons enable the liquid injection process to be started with the set parameters, or stopped.


### Run Console

The panel displays the information about the current progress of the process and the elapsed time.

### Add new syringe

<img align="right" width="273" height="203" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/Add new syringe interface2.PNG">

After selecting the **Add new syringe** from the Syringe Combobox list, a new window will appear. 

The controls in the **Add new syringe** window allow you to define a new syringe by entering the name, scale length (in mm) and volume. Using the pushing element movement buttons allows one to set the element to the desired injecting start position. The **Set current position as start position** is then pressed to store this position.

Press **OK** to add a new syringe to .csv file. The syringe Combobox will refresh and the new syringe will be selected.
