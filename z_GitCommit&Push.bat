@echo off

color 0a
title GitCommit/Push V0.01 - Ran Crump

set INPUT=
set /P INPUT=Would you like to push a update? (y/n): %=%

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
git pull


echo 
"__________             .__        _________                                                  _____     .__ ._.
\______   \__ __  _____|  |__    /   _____/__ __   ____  ____   ______ ____   ______ _______/ ____\_ __|  || |
|     ___/  |  \/  ___/  |  \   \_____  \|  |  \_/ ___\/ ___\ /  ___// __ \ /  ___//  ___/\   __\  |  \  || |
|    |   |  |  /\___ \|   Y  \  /        \  |  /\  \__\  \___ \___ \\  ___/ \___ \ \___ \  |  | |  |  /  |_\|
|____|   |____//____  >___|  / /_______  /____/  \___  >___  >____  >\___  >____  >____  > |__| |____/|____/_
                     \/     \/          \/            \/    \/     \/     \/     \/     \/                  \/"

pause