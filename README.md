[![Board Status](https://kunal.visualstudio.com/30be2058-e068-483e-a194-825b65049101/0ab87ccb-e959-4406-afe5-0da97ee740c0/_apis/work/boardbadge/39ee39ec-dad6-4688-9cce-54e40f3190ef)](https://kunal.visualstudio.com/30be2058-e068-483e-a194-825b65049101/_boards/board/t/0ab87ccb-e959-4406-afe5-0da97ee740c0/Microsoft.RequirementCategory)
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

# Install
Install-Package SimpleConsoleAppLogger -Version 6.0.0
