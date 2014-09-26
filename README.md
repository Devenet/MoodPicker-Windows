# MoodPicker-Windows

[Mood Picker](https://github.com/nicolabricot/MoodPicker) Client for Windows to share your mood!

![Screenshot of Mood Picker Client for Windows](https://github.com/nicolabricot/MoodPicker-Windows/raw/master/MoodPicker-Windows.png)

***

## Installation

### Requirements

Please check that:  
* the [Microsoft .Net Framework 4.5 Full package](https://github.com/nicolabricot/MoodPicker-Windows/raw/resources/downloads/dotnetfx45_full_x86_x64.exe) is installed on your computer  
* your MoodPicker webapp is already online

If you try to install the application without the .Net framework, you will get this error.  
![Screenshot of dependance for .Net Framework](https://github.com/nicolabricot/MoodPicker-Windows/raw/resources/screenshots/installation-dot-net-dependance.png)

### Downloads

Browse the [releases to download the last version](https://github.com/nicolabricot/MoodPicker-Windows/releases) of Mood Picker Client for Windows.

## Configuration

### Import configuration file

The easiest way is to open the Settings dialog box and import an XML configuration file (Tools > Import).

```xml
<?xml version="1.0" encoding="utf-8"?>  
<configuration>  
  <api>  
    <server>http://labs.nicolabricot.com/moods/</server>  
    <key>YourFabulousApiKey</key>  
    <token>3141592653589793238462643383279</token>  
  </api>  
</configuration>  
```

### Manual configuration

You can alse in the Settings dialog box enter the server URL and the API credentials to connect you to the server.


***

## Development

The repository contains two solutions created with Visual Studio 2013:

* __MoodPicker__ which is the Application Windows Form for the Mood Picker Client for Windows
* __Setup__ which is an InstallShield project to create setup files and deploy the app.

You do not need the Setup project for development purpose, and you should not have to use it, except if you want to deploy your own Mood Picker Client at the end of you development.


***

## Screenshots

A list of screenshots is available in the [resources branch](https://github.com/nicolabricot/MoodPicker-Windows/blob/resources/screenshots/README.md).

## License

Refer you to the [LICENSE file](https://github.com/nicolabricot/MoodPicker-Windows/blob/master/LICENSE).

## Want to contribute?

Source code is hosted on [Github](https://github.com/nicolabricot/MoodPicker-Windows) by [nicolabricot](http://nicolabricot.com).  
Feel free to fork it and to improve the application!

Let me know if you use Mood Picker by sending me an email, I will be happy ;-)
