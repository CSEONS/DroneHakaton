@echo off
setlocal
cd DroneHakaton
rmdir /s /q Migrations
echo y | dotnet ef database drop
dotnet ef migrations add InitialMigration
dotnet ef database update
echo Reload completed.
pause