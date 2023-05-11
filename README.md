# PedalTuner
PedalTuner is a simple application that allows users of pedals from manufacturers like Fanatec whose software does not support fine tuning the pedal output via curves.

While it has been primarily designed for iRacing and Fanatec V3 brake pedals it may (but also may not) work on other devices and input signal.

## Concept
PedalTuner grabs the signal coming from a pedal, transforms it, and emits the transformed signal via an emulated device.

## Warnings
Using this software is at your own risk. 

It is far from being exhaustively tested and is still a prototype. The way in which this tool works inherently introduces lag while consuming additional resources.

Additionally, given that the emulated device uses an emulated XBOX360 trigger controller, the output pedal only has a resolution of 255 values, as opposed to the 65535 possible values of the original.

The best solution is always for the manufacturer to implement this functionality in their software, but this is intended to provide a potential solution.

# Installing
Before using this application you must install and setup the ViGEmBus. ViGEmBus helps us emulate game controllers that we can use to output the transformed signal through.

## Installing ViGEmBus
1. Download and install from https://github.com/ViGEm/ViGEmBus/releases

PedalTuner has been tested with v1.21.442.

## Installing PedalTuner
PedalTuner is a portable application, simply extract the contents of the zip file and run the `MSS.PedalTuner.exe` executable.

# Configuration
Preferably make sure to swtich on all your controller devices before launching PedalTuner, and launch PedalTuner before launching the sim.

## Configuring PedalTuner
1. Open PedalTuner by running the `MSS.PedalTuner.exe` executable
2. Click `Settings` > `InputDevice` to open up the config screen
3. Click `Load Input Devices` to scan your PC for connected steering wheel devices. This may take a while. Note that if your device is not recognised, you may untick `Scan for wheel devices only` to load up all HID devices. This will be a cluttered list but should include all devices.
4. Select the Input Device from the drop down. Note: you may have to reselect if it was selected automatically
5. Click `Calibrate` and follow the prompts
6. Click `Test` and modulate pressure on the pedal to make sure input is detected ok.
7. Click `Save`

If the calibration wizard fails you may set it up manually by populating the:
- Input Device: The device the original pedal is connected from
- Controller Property: The controller property which exposes the pedal input value (you may refer to the `Controller Parameters` window while modulating the pedal to identify the appropriate property)
- Min Value: The minimum value reported by the pedal
- Max Value: The maximum value reported by the pedal
- Invert Value: Check this when the pedal is at Max Value when it is released, and when it is at MinValue when it is fully pressed (Fanatec V3s require this checked. Probably so do other pedals but I have no way to test)

To reset configuration at any time and restart, please remove the `pedaltuner.settings.json` file from the folder in which PedalTuner is installed.

## Using PedalTuner
To use PedalTuner, define the filter, factor and interval and click `Monitor`. 

To confirm PedalTuner is working, refer to the `In` and `Out` trackbars. If both are moving to the pedal input then you should be set.

The filter and factor may be updated at any time (even in-game) by clicking `Set Params` to confirm new values.

From personal testing, I found an interval of 25 to be sufficient. Feel free to tweak this value to suit your needs and specs.

Settings are Saved automatically so setup is only required once.

## Setup in iRacing
To setup in iRacing we must tell the iRacing controller setup screen that we want the pedal signal to be captured from the emulated device.

To do so, go through the pedal setup wizard as normal, but when setting the PedalTuner pedal, go to `Settings` > `Game Setup` and click the `Set Maximum` and `Set Minimum` buttons in line with wizard request. You should see the signal coming from a new device and the maximum value being `255`.

You may need to click the buttons repeatedly for the signal to be detected.

# Thanks
Special thanks to *zaid92* for testing with Thrustmaster LC pedals, and the [TDi99 community](https://www.youtube.com/@Tdi99) for the help, inspiration and entertainment.