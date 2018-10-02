@echo off

set INPUT=
set /P INPUT=Type input: %=%

If /I "%INPUT%"=="y" goto yes 
If /I "%INPUT%"=="n" goto no

:no
echo "Process Diverted, input 'y' not recived"
pause
Exit /b

:yes
git add .
git commit -m "GitCommand&Push Remote User..." 
git pull
git push
pause