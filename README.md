# C# .NET Core app

[.NET Core CLI | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/tools/)

```sh
dotnet new console -n cli  # `cli/` created
cd cli
dotnet build cli.csproj
dotnet run bin/Debug/netcoreapp3.1/cli.dll
# project and binary is optional
dotnet build
dotnet run
cd ../

dotnet new classlib -n lib  # `lib/` created

dotnet new solution -n test # `test.sln` created
dotnet sln add cli/
dotnet sln add lib/
dotnet clean
dotnet build
dotnet run -p cli 2019-04-01

# add package dependency to lib
dotnet add lib/ package Humanizer.Core
# add reference dependency to app
dotnet add cli/ reference lib/

dotnet list package

# release build to RELEASE/
dotnet publish -c Release -o RELEASE/
```
