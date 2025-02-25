# MadsMauiBase
The MadsMauiBase is an example app containing examples and snippets of hopefully useful features. Its purpose is to provide a starting point for new projects and to provide a reference for frequently requested techniques. The app is built using the MVVM architecture and uses the following packages:
- [Maui Community Toolkit](https://github.com/CommunityToolkit/Maui)

## Getting Started
To get started with the MadsMauiBase, clone the repository and open the solution in Visual Studio 2022. You should be able to hit debug and run up the app in the emulator straightaway.

## .NET Versions
- .NET: 9.0
- .NET MAUI: 9.0 (goes hand-in-hand with .NET 9.0 so obvious really!)

_Note: Although .NET has LTS and STS versions where LTS are even version numbers and STS are odd versions, .NET MAUI is STS regardless._
- [.NET and .NET Core Support Policy] (https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [.NET MAUI Support Policy] (https://dotnet.microsoft.com/en-us/platform/support/policy/maui)

## Naming Conventions
There are naming conventions and there are naming conventions - my key piece of advice is to be consistent and name everything sensibly. camelcase, PascalCase, snake_case, kebab-case - it doesn't *really* matter as long as you're consistent. If you can't remember what some of the various naming conventions are, here's a quick reminder!
- camelCase: `thisIsCamelCase`
- PascalCase: `ThisIsPascalCase`
- snake_case: `this_is_snake_case`
- kebab-case: `this-is-kebab-case`

Throught MadsMauiBase, I use PascalCase and camelCase with a specific syntax, something I picked up many years ago from an old colleague whom I will acknowledge as "CG". CG was a stickler for naming conventions and looking back, I'm glad he was. So, CG, if you're still around, then thank you - your mentorship back at Q is fondly remembered.

**Classes**
Classes, methods and Models are PascalCase.

**Methods**
Method names are PascalCase and reflect what they do and should in most cases be a verb. I stay close to CRUD naming - if the method is a getter, it should start with `Get`. If it's a setter, it should start with `Create` or `Update`. Likewise, if it deletes, then `Destroy`.

**Models**
Model names are PascalCase and are singular, not plural.

**Variables**
Variables are syntax set camelCase. A variable always starts with a lowercase character, an occasional two character sub-type and following by subsequent words starting with a capital letter. Finally, an occasional uppercase letter at the end. The first character indicates the type of data that the variable contains. This gives you at at-a-glance view of what the variable is and what it contains. The subsequent words should be consise and meaningful. 

| First Character | Notes |
| --- | --- |
| a | Array |
| b | Boolean |
| c | Char |
| i | Integer |
| d | Decimal/Double |
| o | Object - Followed immediately by `Db` if a database connection. E.g. `oDbClientZ`. Objects are always suffixed by `Z`. |
| t | Time/Date |
| v | String |

**Why are objects suffixed with Z?**
Simply to draw attention to it being an object. To be quite honest, I can't remember and am cross with myself for this!

**Database Table and Column Names**
Database table and column names are always in lowercase and use underscores to separate words. The table name should be plural, descriptive and meaningful.
