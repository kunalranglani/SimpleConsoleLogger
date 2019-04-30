[![Build Status](https://kunal.visualstudio.com/SimpleConsoleLogger/_apis/build/status/kunalranglani.SimpleConsoleLogger?branchName=master)](https://kunal.visualstudio.com/SimpleConsoleLogger/_build/latest?definitionId=3&branchName=master)

# SimpleConsoleLogger

Simple .net console logger that outputs messages in certain colors. Normal messages are white, success messages are green, 
warnings are yellow and errors are red. You can also log your entire console output to a file.

```bash
ConsoleLogger.Log

ConsoleLogger.LogSuccess

ConsoleLogger.LogException

ConsoleLogger.LogError

ConsoleLogger.LogWarning

ConsoleLogger.LogSilent

ConsoleLogger.LogToFile

ConsoleLogger.GetLogsRawString

ConsoleLogger.GetLogs
```
