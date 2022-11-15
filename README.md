# .NET + C# :purple_circle:

> Key features of C#
>   - Modern
>   - Cross-platform
>   - Multi-paradigm
>   - General purpose
>   - Tooling
>   - Documentation 


## Alternative to Java okay?

*Update: I really enjoy the journey to switch C#.*

- First steps [here](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro)
- See documentation [here](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Udemy](https://www.udemy.com/course/c-sharp-para-principiantes) course
- [YouTube](https://www.youtube.com/watch?v=xXd-44d_xgc) guide
- [C# exercises](https://exercism.org/tracks/csharp/exercises) on Exercism
- [Design Patterns](https://refactoring.guru/design-patterns) blog/book
<!-- Software Design + Clean Code (Design Patterns + Refactoring) -->
<!-- Coming soon -->

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