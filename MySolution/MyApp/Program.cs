using MyLibrary;

var name = args.Length > 0 ? args[0] : "World";//short hand for if-else

Console.WriteLine(Greeter.Hello(name));





// No traditional Main() method required.
// Modern .NET uses top-level statements by default.
// Cleaner. Faster. Better.
//-----------------------------

// mkdir MySolution && cd MySolution

// dotnet new sln -n MySolution

// dotnet new console -n MyApp

// dotnet new classlib -n MyLibrary

// dotnet sln add MyApp/MyApp.csproj
// dotnet sln add MyLibrary/MyLibrary.csproj

// dotnet add MyApp/MyApp.csproj reference MyLibrary/MyLibrary.csproj

// # write your code
// dotnet build
// dotnet run --project MyApp/MyApp.csproj