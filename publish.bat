@echo off
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:IncludeAllContentForSelfExtract=true /p:TrimMode=Link
explorer C:\Dev\dotnet\Jes\bin\Release\net9.0\win-x64\publish