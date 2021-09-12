@ECHO OFF
SET /P ARGS="Args: "
SET /P BIN="Bin: "
START /B "" "%CD%\notnot\bin\%BIN%\net5.0-windows\notnot.exe" %ARGS%
