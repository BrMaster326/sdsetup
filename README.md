[![Homebrew SD Setup](https://www.sdsetup.tk/img/logo.png)](https://www.sdsetup.tk)

[https://www.sdsetup.tk](https://www.sdsetup.tk)
Homebrew SD Setup is a web application written in C# (and a little bit of JavaScript) running on Blazor. The app lets you select the homebrew applications and custom firmwares you want, and quickly create a zip archive to extract to your SD card. The Ninite for your game consoles.

## Compatibility
The application has been verified working in Firefox and Chrome on Windows 10, and Chrome and Firefox on Android. This application is explicitly incompatible with Microsoft Edge at this time (high priority!). Other browsers are likely to work as long as they support WebAssembly or asm.js (even IE11).

## Features
### Nintendo Switch
* Choose between a selection of common homebrew applications, tools and utilities, including:
	* Custom Firmwares (ex. SX OS, Atmosphere, ReiNX)
	* Homebrew Utilities (ex. Homebrew Menu, Checkpoint, JKSV, Tinfoil)
	* Emulators (ex. Salamander RetroNX, pSNES)
	* Games (ex. Mystery of Solarus DX, SDL Prince of Persia)
	* Fusee Payloads (ex. Hekate, BISKeyDump, BriccMii)
	* PC Utilities (ex. TegraRCMSmash)
* Generate a perfectly formatted file structure in ZIP format, ready for direct extraction to your SD card. No additional setup necessary, just drag and drop!

## Usage
Head over to [https://www.sdsetup.tk](https://www.sdsetup.tk), select your console of choice, select the packages you want, and hit download! Once finished, simply **extract the contents of the sd folder** in the downloaded ZIP archive **to the root of your SD card!** Do what you wish with any additional folders included in the zip file.

## Issues
Please feel free [submit an issue](https://www.github.com/noahc3/sdsetup/issues) for any of the following reasons:
* A package is outdated
* A package's information is incorrect
* A package should be retrieved from a different/better source
* A browser other than Edge is incompatible
* Reporting a bug
* Suggesting a feature
* Suggesting a new package
* Requesting a package be removed Homebrew SD setup
* Reporting a redistribution clause license violation for a rehosted package

## Build
Clone the repository and open the solution in Visual Studio. Build from there.

## Included Projects
* **SD Setup Blazor:** The web application itself, written in C# (and a little bit of JavaScript).
* **SD Setup Manifest Generator:** A GUI authoring tool for generating a valid manifest file with package information and where to retrieve files for download.

## Contributing
Fixing Edge is a high priority at the moment, but due to lack of pretty much any debugging tools for Blazor, fixing it is difficult. Help with this would be appreciated.
Other changes are welcome through pull requests, of course!

## Credits
Please see https://www.sdsetup.tk/credits for an up-to-date list of credits and sources for each package available.

Other credits:
*   Steve Sanderson and contributors for making this almost amazing thing called  [Blazor](https://blazor.net/)
*   Rikumax25 / Jorgev259 for JSZip wrapper functions used in  [3SDSetup](https://github.com/jorgev259/3SDSetup)/[WiiuSetup](https://github.com/jorgev259/wiiusetup), ultimately making my life much easier
*   Chanan Braunstein for  [BlazorStrap](https://github.com/chanan/BlazorStrap)
*   Joonas W. for  [Using C# await against JS Promises in Blazor](https://joonasw.net/view/csharp-await-and-js-promises-in-blazor)