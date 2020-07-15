@echo off
set VERSION=%~1

cd BackendApi
start /wait dotnet publish --configuration Release --output "../app-%VERSION%\BackendApi"
cd ../Frontend
start /wait dotnet publish --configuration Release --output "../app-%VERSION%\Frontend"

mkdir "../app-%VERSION%\config"
mkdir "../app-%VERSION%\Protos"

cd ..
copy "Protos" "app-%VERSION%\Protos"
copy "start.cmd" "app-%VERSION%\"
copy "stop.cmd" "app-%VERSION%\"
copy "config" "app-%VERSION%\config"