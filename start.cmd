@echo off

cd BackendApi
start /b dotnet BackendApi.dll
cd ../Frontend
start /b dotnet Frontend.dll