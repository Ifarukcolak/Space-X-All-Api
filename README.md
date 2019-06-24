# Space-X-All-Api
Implementation all  of r/SpaceX API with Windows Console Application using .Net Core

## Getting Started 

These instructions will get you a copy of the project running on your local machine for development and testing purposes. All api's implemented according to [spaceX](https://docs.spacexdata.com/?version=latest#intro)  documentation.

## Prerequisites

This project needs .Net Core 2.2 framework and RestSharp 106.6.9, NewtonsoftJson 12.0.2 Nugets.

## Installing

There are two ways to install this project on your local computer.

Firstly, click *Clone or Download* button then select *Download ZIP* and extract ZIP folder. 

Secondly, use this command clone the project. 

```bash
git clone https://github.com/Ifarukcolak/Space-X-All-Api.git
```
## Running & Deployment

Click the **SpaceX.sln** file and open with Visual Studio 2017 then build project. 

If you want to use this project as reference for another .Net Core projects, add reference  **SpaceX.dll** to project or just click *Run* button and test on CMD. 

Here is the simple example uses of this project as a reference in another project.

```bash 
  SpaceX.Services.CapsuleService capsuleService = new SpaceX.Services.CapsuleService();
  Console.WriteLine(JsonConvert.SerializeObject(capsuleService.GetAllCapsulesAsync(),Formatting.Indented));
```
It will returns the list of all capsules.

## Built With

+ Visual Studio 2017
+ .Net Core 2.2 Framework
