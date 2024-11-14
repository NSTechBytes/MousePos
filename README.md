# MousePos - Rainmeter Plugin

The **MousePos** plugin is a simple yet powerful plugin for **Rainmeter**, designed to retrieve the current mouse position on your screen. You can display the mouse cursor's **X** or **Y** coordinates using this plugin.

## Features

- Retrieve the **X** and **Y** position of the mouse cursor.
- Supports two types of measurements: **MouseX** and **MouseY**.
- Easy to integrate with Rainmeter skins.
- Written in C# using Rainmeter's plugin system.

## Installation

1. **Download the latest release** of **MousePos**.
2. **Install the plugin** by copying `MousePos.dll` into your Rainmeter's `Plugins` folder:
   - Typically, the folder path is:  
     `C:\Users\<YourUsername>\Documents\Rainmeter\Plugins\`
3. After installation, you can use it in your Rainmeter skins.

## Usage

### 1. Add the plugin to your Rainmeter skin.

In your `.ini` skin file, define a measure that uses the **MousePos** plugin. You can specify whether you want the X or Y coordinate of the mouse.

```ini
[Rainmeter]
Update=50
BackGroundMode=2
SolidColor=ffffff

[MeasureMouseX]
Measure=Plugin
Plugin=MousePos
MeasureType=MouseX
DynamicVariables=1

[MeasureMouseY]
Measure=Plugin
Plugin=MousePos
MeasureType=MouseY
DynamicVariables=1

[MeterMouseX]
Meter=STRING
X=10
Y=10
FontColor=10,10,10
Text=Mouse X: [MeasureMouseX]
DynamicVariables=1
Antialias=1

[MeterMouseY]
Meter=STRING
X=10
Y=30
FontColor=10,10,10
Text=Mouse Y: [MeasureMouseY]
DynamicVariables=1
Antialias=1
```

In this example:
- **MeasureType=MouseX** will get the X position of the mouse.
- **MeasureType=MouseY** will get the Y position of the mouse.



## Parameters

- **MeasureType**: Defines what measurement to fetch. Can be `MouseX` (for X coordinate) or `MouseY` (for Y coordinate).

## Troubleshooting

- Ensure the `MousePos.dll` file is correctly placed in the **Rainmeter Plugins** folder.
- If you don't see the position, check the Rainmeter logs for any errors related to the plugin.

## Contributing

If you'd like to contribute to this project, you can:
- Fork the repository.
- Create a branch for your feature or fix.
- Submit a pull request.

Please ensure that your code follows the existing style and includes necessary documentation or tests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

