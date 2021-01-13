# Open Source Syringe Pump

SyringePumpApp is a C# open source application to control a dedicated Arduino Leonardo based device.
Whole process and necessary parts to built a Syringe Pump device are described in our [publication](https://github.com/MKuj/Single-Syringe-Pump/edit/main/README.md)

The application works only on computers with Windows system.

<img align="right" width="240" height="342" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/Interface%20programu%201.PNG">


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

### Settings

#### Syringe

<img align="right" width = "272" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/SettingsPanel.PNG">

Combobox for selection of a predefined syringe loaded from csv file.

The software use external .csv file to store a user defined syringes, so it is possible to add your own syringe by selecting a "Add new syringe" from the Combobox list.

#### Speed

Numeric UpDown control for defining the injection speed.

#### Bolus Mode

<img align="right" width = "269" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/bolusMode.PNG">

Button for changing from **constant flow mode** to a **bolus mode**.

Bolus mode is an injection of a discrete amount (volume) of the solution with the chosen flow rate. The main difference between the **constant flow rate mode** and the **bolus mode** is that for the latter after the injection of a specific volume of solution the pump stops. 

### Move Panel
The move panel contains controls for handling the position of the push element of pump.

<img align="right" width="273" height="205" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MovePanel3.png">

#### Step + / Step -
Moving the push element forward or backward during the button is press.


#### Start Position


## Contributing
