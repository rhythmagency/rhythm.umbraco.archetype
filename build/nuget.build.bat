REM This file should not be run directly.
REM It is run by the Visual Studio build process.

SET NUGET=..\packages\NuGet.CommandLine.4.1.0\tools\NuGet.exe
SET VER=%1
SET CONFIG=%2

@ECHO ====== Creating NuGet Package in "dist" Folder
%NUGET% pack Rhythm.Umbraco.Archetype.csproj -outputdirectory ..\..\dist -version "%VER%" -Properties Configuration=%CONFIG%