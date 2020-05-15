# WeatherWindowsService
C# Project to Download Weather info for Dallas tx

Project uses 
   This project based on Console application and uses Topshelf and NewtonsoftJson libraries to do the task.
   http://api.openweathermap.org/ api to download weather info 
   AppID (&appid=7a47ca23234371289e9f4549179c8bfa)
   Dallas Texas (Hardcoded) "q=Dallas,Texas"
   Units / Unit of Temperature is in  Fahrenheit (&units=Imperial)
   If service started or run from command line , gathers info every 5 minutes
   
 Gathers information in JSON (Return format)
 
 Writes to fold c:\\temp (assumes its windows and c:\temp exists)
 Writes to a CSV file "Weather.csv"
 It creates file if not exists.
 
 To create a windows service please copy contents .\SimpleHeartbeatService\bin\Debug folder on to c:\temp\Heartbeat (Suggestion)
   run command line "as admin"
   traverse to the directory you have copied the executable to 
   run command "SimpleHeartbeatService.exe install start"
   these actions will create a service in "Service" called "heartbeat" set up in program.cs namespace SimpleHeartbeatService
   
 
 
   
 
