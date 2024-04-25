<br/>

<h3 align="left">
    <b><a href="https://github.com/maddada/auto-brightness-and-saturation/releases/latest"> Download Maddada's Auto Brightness and Saturation </a></b>      
</h3>

<br/>

<h4>
    Huge thank you to <a href="https://github.com/incheon-kim">incheon-kim</a> for creating Tarkov Settings which this project is based off. <br/>
    Also thank you to <a href="https://github.com/panicaz">panicaz</a> for adding some great features (hotkeys, profiles, exclusive full screen support).
</h4>

<br/>

### Description:
Automatically change color settings for CS2, Escape From Tarkov, and other games/programs (please post requests in the discussions).

<br/>

### How it works?
- Changes Digital Vibrance value from Nvidia Settings using [NvAPIWrapper](https://github.com/falahati/NvAPIWrapper)
- Changes Gamma using some [Win32 API calls](https://docs.microsoft.com/en-us/windows/win32/api/wingdi/nf-wingdi-setdevicegammaramp)

It only changes your display's colors when the program's window is in focus.
This leaves a smooth transition when minimizing/maximizing.

<br/>

### Supported Graphic Cards:
- Nvidia GPUs **fully supported.** (Brightness/Contrast/Gamma/Digital Vibrance)
- AMD GPUs **partially supported.** (Except Saturation)
- **Intel/Etc is not supported yet.**

<br/>

### What does it do?
You can change any of the following color settings:
1. Brightness
2. Contrast
3. Gamma
4. Digital Vibrance Control (aka. Saturation)
5. Only affects display while the program's window is focussed (It also prevents **sudden flash during Alt-tabbing**)

<br/>

### How to Use:
1. Open application (SmartGuard might prevent opening as it's not signed)
2. Set any color value
2.1. Double-click any slider labels to reset their values.
3. Minimize and play EFT
4. Close application if you want to deactivate

**Exit the app from your taskbar to create a `settings.json` file that will remember your settings**

<br/>

### Warnings:
1. It might blink couple times when you activate the program's window but it works. Don't worry.
2. **Disclaimer: I don't know BSG will ban for using this.**
3. AMD only supports Brightness/Contrast/Gamma Controls
4. Intel Graphic Cards are not supported
5. Only works in **Borderless mode.**
6. Nvidia Optimus Environment (mostly laptops) is not tested.

<br/>

### Features:
- Process Focusing Awareness
- Digital Vibrance Value Change
- Gamma Value Change
- Brightness, Contrast, Gamma Value modify
- INI or JSON configuration
- Process Changeability (Not only for EscapeFromTarkov)
- change display(monitor) target
- Minimize to tray
- Profiles
- Hot Keys
