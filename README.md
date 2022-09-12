# .NET + C# :purple_circle:

Aternative to Java okey?

- First steps [here](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro)
- See documentation [here](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Udemy course](https://www.udemy.com/course/c-sharp-para-principiantes)
- [YouTube guide](https://www.youtube.com/watch?v=xXd-44d_xgc)


## Notes :pushpin:

General commands
```sh
# general info + sdk
dotnet --info

cd name_project

# console
dotnet run 

# webapp
dotnet watch run

# auto template
dotnet new gitignore
```

```sh
# new solution
dotnet new sln --name FooBar

# link projects
dotnet new console --name Foo --output Foo
dotnet new console --name Bar --output Bar
dotnet sln add .\Foo\Foo.csproj
dotnet sln add .\Bar\Bar.csproj

# build this
dotnet restore
dotnet build FooBar.sln
```

[dotnet CLI vs Visual Studio IDE](https://stackoverflow.com/questions/42730877/net-core-when-to-use-dotnet-new-sln)