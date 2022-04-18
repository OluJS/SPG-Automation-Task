# SPG Automation Task

## Overview
This repository contains the solution to the SPG Automation task

## Pre-requisites
- Windows OS
- Visual Studio
- Google Chrome

## Getting started
#### Clone the repo or 'Download ZIP'
```
git clone https://github.com/OluJS/SPG-Automation-Task.git
```
#### Install Specflow Extension
- Go to Extensions > Manage Extensions
- Select > Online
- Search for "Specflow" and download the ["Specflow for Visual Studio 20XX"](https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio2022) Extension for the Visual Studio you're using

#### Install Nuget Packages
- Right-click on the project > Manage NuGet Packages...
- Select the 'Browse' tab
- Search and install the following:
  - ["DotNetSeleniumExtras.WaitHelpers"](https://www.nuget.org/packages/DotNetSeleniumExtras.WaitHelpers/) by _SeleniumExtras.WaitHelpers_
  - ["Newtonsoft.Json"](https://www.nuget.org/packages/Newtonsoft.Json/) by _James Newton-King_
  - ["NUnit"](https://www.nuget.org/packages/NUnit/) by _Charlie Poole, Rob Prouse_
  - ["NUnit3TestAdapter"](https://www.nuget.org/packages/NUnit3TestAdapter/) by _Charlie Poole, Rob Prouse_
  - ["Selenium.WebDriver"](https://www.nuget.org/packages/Selenium.WebDriver/) by _Selenium Committers_
  - ["Selenium.WebDriver.ChromerDriver"](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/100.0.4896.6000?_src=template) by _jsakamoto_
  - ["Specflow"](https://www.nuget.org/packages/SpecFlow/) by _Specflow Team_
  - ["Specflow.NUnit"](https://www.nuget.org/packages/SpecFlow.NUnit/) by _Specflow Team_
  - ["Specflow.Tools.MsBuild.Generation"](https://www.nuget.org/packages/SpecFlow.Tools.MsBuild.Generation/) by _Specflow Team_

## Running The Tests
- After succesfully cloning and installing the extensions and nuget packages, if Test Explorer isn't already open navigate to View > Test Explorer 
- Go into the solution and build it, 'Ctrl + Shift + B' or Right-click the solution > Build Solution
- Right-click > Run to run an individual test or click Run to run them all

![testexplorerview](https://user-images.githubusercontent.com/24880796/163870306-a53f0530-7d7c-4d96-b675-5b3a1d61eb30.png)


