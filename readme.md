# CSharpWebSocketAppWithBlazor
Wanted to check out how to make a full stack chat app with .NET, found the following tutorial: [Use ASP.NET Core SignalR with Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/signalr-blazor?view=aspnetcore-10.0&tabs=visual-studio). Followed the tutorial, had to do a bit of debugging to get the code moved around in the right places because the naming was a bit confusing, but got it working. The result is what you see here.

## `dotnet` CLI tool workflow
To run the app:
1. Have .NET 9.0 installed: `dotnet --version` returns `9.X.XXX`. As of this writing, `9.0.304`
2. From the root of this repo, go to the server-side project folder: `cd BlazorSignalRApp`
3. From the server project folder: `dotnet run`
