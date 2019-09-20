@echo off
for /f "usebackq tokens=*" %%i IN (`cd`) do @set PWD=%%i
mklink "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\lqwl" "%PWD%\lqwl.exe"
