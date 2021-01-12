# Open Source Syringe Pump

SyringePumpApp is a C# open source application to control a dedicated Arduino Leonardo based device.
Whole process and necessary parts to built a Syringe Pump device are described in our [publication](https://github.com/MKuj/Single-Syringe-Pump/edit/main/README.md)

The application works only on computers with Windows system.

<img align="right" width="240" height="342" src="https://github.com/MKuj/Single-Syringe-Pump/blob/main/Interface%20programu%201.PNG">


## Installation

To run application and use Syringe Pump follow the steps:
- Download ZIP and extract file.
- Open Ardiono IDE and connect your Arduino Leonardo board.
- Open included Arduino file (.ino) and upload it on microcontroller. 
- Run SyringeApp.exe

You can also compile it by yourself. We publish a C# project written in Visual Studio Community Edition IDE.

## Usage

To auto-detect and connect with Arduino Leonardo board we used a Win32_DeviceChangeEvent.

```C#
private readonly ManagementEventWatcher _deviceChanged = new ManagementEventWatcher(new WqlEventQuery(
                "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3"));
```

## Contributing
