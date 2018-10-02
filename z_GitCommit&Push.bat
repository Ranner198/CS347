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

echo                                                                                                                      +soooooooooooooooooooo+//:::::::::::::::::::::::::://///////////////////////////+`                                                                                                    
                                                                                                                      oo                   `...--------------------------.............................m-                                                                                                    
                                                                                                                      oo                                                                              m-                                                                                                    
                                                                                              `-://///:.`             oo                                                                              m-                                                                                                    
                                                                                           :oso+:-...-:+s+`           oo                                                                              m-                                                                                                    
                                                                                         `yo`            /d`          oo                                                                              m-                                                                                                    
                                                                                        .d-               ys          oo                                                                              m-                                                                                                    
                                                                                        m-                 m-         oo                                                                              m-                                                                                                    
                                                                                       +h                  os         oo                                                                              m-                                                                                                    
                                                                                       d:                  +s         oo                                                                              m-                                                                                                    
                                                                                       d:                 -h-         oo                                                                              m-                                                                                                    
                                                                                       yo               `ss`          oo                ./ooo.                           :d                           m-                                                                                                    
                                                                                        /yodoo+:-----:+os:            oo            `:.y+-``-d.                           N`                          m-                                                                                                    
                                                                                        -sy:```:::::::-`              oo             h+      y+          -        .+oo`   N.                          m-                                                                                                    
                                                                                      :so.                            oo             `m-     s+  :.     .N:      +h-``    os                          m-                                                                                                    
                                                                                   ./ddo++oooooooooooooooooooo:       oo              -m`   -h-  h/     .My     +h`       +y                          m-                                                                                                    
                                                                                 `+y:-....`````````````````````       oo               so `+y.   ss     .Mh    `N`        +y  /s:                     m-                                                                                                    
                                                                                /yd+                                  oo               .mso:`    .m`    `Nh    `m-        +y`ss.h/                    m-                                                                                                    
                                                                              -so`-m::::::::::::--.``                 oo                yo        N.     hh     -s+`      +yso  .m.                   m-                                                                                                    
                                                                            -oo.   :::::::::::::://++ooooooo+////:--.-ys                .m        h/     sh      `/s+     +mh    oy                   m-                                                                                                    
                                                                         `/s+.                            ```.---:::-:ys                 N.       /h     /m         so    +M.    .m                   m-                                                                                                    
                                                                       -+s:`                                          oo                 h/        d:    +M-`       .m    +d     .N                   m-                                                                                                    
                                                                    `/so-                                             oo                 os        -h:.-+sm/o/```.--/d    +y     .N                   m-                                                                                                    
                                                                   sy/`                                               oo                 os         .:/+- /h`+o+++/::.    /s     `+                   m-                                                                                                    
                                                                 .ysso+/:.                                            oo                 -s               `o              `.                          m-                                                                                                    
                                                                :h:  `.-:+o++:-`                                      oo                                                                              m-                                                                                                    
                                                              `oy.         `.-/+o+:                                   oo                                                                              m-                                                                                                    
                                                             .y+`               -yo                                   oo                                                                              m-                                                                                                    
                                                           .oo.              `/s+.                                    oo                                                                              m-                                                                                                    
                                                         .oo.              .+y/`                                      oo                                                                              m-                                                                                                    
                                                       `os.              .yo-                                         oo                                                                              m-                                                                                                    
                                                     `/y/             `:ss.                                           oo                                                                              m-                                                                                                    
                                                    :s/`             :y+`                                             oo                                                                              m-                                                                                                    
                                                  :s/`             `ss                                                oo                                                                              d:                                                                                                    
                                                .ss`              :y:                                                 oo                                                                              so                                                                                                    
                                              `os-               -o`                                                  oo                                                                              /h                                                                                                    
                                             /h-                                                                      oo                                                                              `N.                                                                                                   
                                           `h/                                                                        oo                                                                               +h                                                                                                   
                                           `-                                                                         oo                                                                                m-                                                                                                  
                                                                                                                      oo                                                                                y+                                                                                                  
                                                                                                                      oo                                                        `-:/ossssooooooooooooooohdo+                                                                                                
                                                                                                                      oo                                     `.-:++ooosoosooooooo/-.``                  os                                                                                                  
                                                                                                                      +yoooooooooooooooooooooooooooooooooooooo//-.``                                    +s                                                                                                  
                                                                                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                                                                            



pause