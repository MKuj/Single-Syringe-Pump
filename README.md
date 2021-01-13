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
<img align="right" width = "272" height = "133" src = "https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/SettingsPanel.PNG">

|Control|Description|
|---|---|
|Syringe|Combobox for selection of a predefined syringe loaded from csv file.|
|Speed|Numeric UpDown control for defining the injection speed.|
|Bolus Mode|Button for changing from **constant flow mode** to a **bolus mode**.|

### Move Panel
The move panel contains controls for handling the position of the push element of pump.

<img align="left" width="177" height="132" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Screens/MovePanel.PNG">

#### Step + / Step -
Moving the push element forward or backward during the button is press.


#### Start Position


## Contributing
