@echo off

:: Print the current working directory
echo Current directory: %cd%

:: Check .NET version
echo Checking .NET version...
dotnet --version

:: Build the project
echo Building the project...
dotnet build

:: Run tests
echo Running tests...
dotnet test

echo CI Pipeline executed successfully!
