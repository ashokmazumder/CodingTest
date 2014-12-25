REM Set the visual studio environment and build the TestSolution. 
call "C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
SET WORKSPACE="C:\Users\ashok.majumder\Documents"
msbuild.exe "%WORKSPACE%\CodingTest\TestFramework\TestFramework.sln" /t:Rebuild /p:Configuration=Release /m
