REM Set the visual studio environment and build the TestSolution. 
call "C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
REM Build Solution
msbuild.exe "%WORKSPACE%\TestFramework\TestFramework.sln" /t:Rebuild /p:Configuration=Release /m

REM Copy browser driver to bin directory
xcopy.exe "%WORKSPACE%\Resources\chromedriver.exe" "%WORKSPACE%\Tests\bin\Debug\" /E /I /Y
xcopy.exe "%WORKSPACE%\Resources\IEDriverServer.exe" "%WORKSPACE%\Tests\bin\Debug\" /E /I /Y
