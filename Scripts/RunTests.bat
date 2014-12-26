SET MSTEST_EXE_PATH="C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE"

REM Delete Test Result file of previous run from the workspace
DEL %WORKSPACE%\CodingTestResults.trx 

REM Run all tests
%MSTEST_EXE_PATH%\MSTest.exe /testcontainer:%WORKSPACE%\Tests\bin\Release\Tests.dll /resultsfile:%WORKSPACE%\CodingTestResults.trx 
