import os

os.popen('code .')
os.popen('START wt -d ./WeatherAngular powershell npm start ; split-pane -d ./WeatherApi dotnet watch run')
os.popen('START msedge http://localhost:4200')