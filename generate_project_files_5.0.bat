@echo off

rem Set all paths
SET EnginePath=E:\UE_5.0
SET BuildToolRelativePath=Engine\Binaries\DotNET\UnrealBuildTool\UnrealBuildTool.exe
SET VersionSelector=E:\UE_5.0\Engine\Binaries\Win64\UnrealVersionSelector.exe
SET ProjectName=ShootThemUp.uproject

devops/generate_project_files.bat "%EnginePath%" "%BuildToolRelativePath%" "%VersionSelector%" "%ProjectName%"