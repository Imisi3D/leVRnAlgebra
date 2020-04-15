# LeVRnAlgebra
![Test Coverage](https://github.com/Imisi3D/leVRnAlgebra/raw/master/leVRnAlgebra/Unity%20Code%20Coverage/Report/badge_linecoverage.png "Unity Test Coverage")


leVRn:Algebra is an open source VR solution aimed at transforming education in Nigeria.

## Short Description
It is a VR module designed to teach different topics in the Nigerian Secondary School Curriculum. The module will be used by various secondary schools to enhance the learning experience of their students; this project is part of Imisi 3D's VR for Schools program. Imisi 3D is a current member of the UNICEF Innovation Fund cohort, more details can be found [here](https://www.unicef.org/innovation/stories/virtual-reality-classroom)

## Prerequisites
- Unity 2019.1.0f2

## Getting Started
These instructions will get a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on your Oculus Go.

## Installing
To get a copy of this project working properly on your local machine, follow these simple steps:
- Download the project folder
- Open the project with Unity 2019.2.3f1
- Ensure the platform is set to Android in Build Settings
- Build the .apk, load it into an Oculus Go and test the experience to ensure everything works fine.

## Deployment

### On your phone
- Open the Oculus app on your phone
- Click your paired Oculus Go headset at the top
- Click More Settings > Developer Mode and then toggle Developer Mode ON
- Connect the Oculus Go to your computer
- Accept the RSA key request on the Oculus Go

### On your computer
If you are on Windows, you could check if these files have already been downloaded and installed
- [Android Platform tool](https://developer.android.com/studio/releases/platform-tools)
- [ADB drivers](https://developer.oculus.com/downloads/package/oculus-go-adb-drivers/) from Oculus website
    - Unzip the downloaded file
    - Right-click on the .inffile and select install
    - Go to Start Menu, search for CMD, right-click and open as administrator

### On your opened terminal
- Type "adb devices" and press enter
    - If you don’t see any devices listed in the output, turn off your Go, disconnect the USB, power your Go back on, reconnect the USB and then run the command again
    - If you see a device ID show up in the output with “unauthorized” behind it, put your Oculus Go on and give permission
    - If you see a device ID show up with “device” behind it, you are good to go and ready for the next step
- If your Oculus Go is still not found on the terminal
    - Go to the INSTALLEDPATH of the Android Platform tool on your computer (usually, it is found in C:\Users\YOURUSERNAME\AppData\Local\Android\sdk\platform-tools or C:\Users\YOURUSERNAME\AndroidPlatformTools\Android\sdk\platform-tools) and check if adb.exe is there
    - Copy the directory (right-click on the address bar and copy the address)
    - Go back to command prompt and type "cd TheDirectoryYouCopied" and press enter
    - Then type adb
    - Connect your Oculus Go to your computer
    - Type adb devices (your device ID should appear)
- Then type "adb install PathToYourApk\ApkName.apk" and press enter

## Contributing
Please read [CONTRIBUTING.md](https://github.com/Imisi3D/leVRnAlgebra/blob/master/Contributing.md) for details on how best to contribute to this project.

## Authors
- **Oussama Belhadj Hmida** - [Github](https://github.com/belhadjhmida)
- **Tade Ajiboye** - [Github](https://github.com/Gazuntype/)
- **Isiaq Gbadamosi** - [Github](https://github.com/badmusishaq)

## Code of Conduct
- Please read [Code-Of-Conduct.md](https://github.com/Imisi3D/leVRnAlgebra/blob/master/Code%20of%20Conduct.md) for our list of acceptable and unacceptable behaviours.

## License
This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.md](https://github.com/Imisi3D/leVRnAlgebra/blob/master/LICENSE) file for details.
