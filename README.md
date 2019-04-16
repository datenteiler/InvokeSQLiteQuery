# InvokeSQLiteQuery
PowerShell Cmdlet to invoke a SQLite query to your SQLite database

PowerShell binary cmdlet Invoke-SQLiteQuery
------------------------------------------------------------

* Invoke-SQLiteQuery -Database /path/to/sqlite.db -Query "SELECT name FROM sqlite_master WHERE type='table';"


How to compile and start:
-------------------------

In PowerShell use the following commands to compile the cmdlet with .NET core:

```
dotnet publish -c Release
ipmo ./bin/Release/netstandard2.0/publish/InvokeSQLiteQuery.dll # Please note folder structure and sqlite3 lib below
Invoke-SQLiteQuery -Database /path/to/sqlite.db -Query "SELECT name FROM sqlite_master WHERE type='table';"
```

The Cmlet will give you the output from your SQLite query.

Installation from PowerShell Gallery (PSGallery)
------------------------------------------------

You can download the module from PSGallery in PowerShell with this command:

```Install-Module -Name InvokeSQLiteQuery```

Folder structur of the Cmdlet
-----------------------------

The files 'sqlite3.dll', 'libsqlite3.so' and 'libsqlite3.dylib' need to be copied from the 'runtimes' to the root folder. The folder structure should look like this:

```
InvokeSQLiteQuery
|--runtimes
   |--win7-x64
      |--native
         |--sqlite3.dll
   |--linux-x64
      |--[...]
InvokeSQLiteQuery.deps.json
InvokeSQLiteQuery.dll
InvokeSQLiteQuery.pdb
InvokeSQLiteQuery.psd1
libsqlite3.dylib
libsqlite3.so
Microsoft.CSharp.dll
Microsoft.Data.Sqlite.dll
Microsoft.EntityFrameworkCore.dll
Microsoft.EntityFrameworkCore.Relational.dll
Microsoft.EntityFrameworkCore.Sqlite.dll
Microsoft.Extensions.Caching.Abstractions.dll
Microsoft.Extensions.Caching.Memory.dll
Microsoft.Extensions.DependencyInjection.Abstractions.dll
Microsoft.Extensions.DependencyInjection.dll
Microsoft.Extensions.Logging.Abstractions.dll
Microsoft.Extensions.Logging.dll
Microsoft.Extensions.Options.dll
Microsoft.Extensions.Primitives.dll
Remotion.Linq.dll
sqlite3.dll
System.Collections.Immutable.dll
System.ComponentModel.Annotations.dll
System.ComponentModel.dll
System.Data.Common.dll
System.Diagnostics.DiagnosticSource.dll
System.Dynamic.Runtime.dll
System.Interactive.Async.dll
System.Linq.dll
System.Linq.Expressions.dll
System.Linq.Queryable.dll
System.Management.Automation.dll
System.ObjectModel.dll
System.Reflection.Emit.dll
System.Reflection.Emit.ILGeneration.dll
System.Reflection.Emit.Lightweight.dll
System.Reflection.TypeExtensions.dll
System.Runtime.CompilerServices.Unsafe.dll
System.Text.RegularExpressions.dll
System.Threading.dll
```

How to use Invoke-SQLiteQuery
-----------------------------

[Download Chinook database as a sample database SQLite](https://github.com/lerocha/chinook-database/blob/master/ChinookDatabase/DataSources/Chinook_Sqlite.sqlite). It is an new and cool alternative to the Northwind database and ideal for demos and testing with the Top of the Pops.

### Show all columns in a SQLite table

```
Invoke-SQLiteQuery -Database "C:\Users\Public\Downloads\Chinook_Sqlite.sqlite" -Query "SELECT sql FROM sqlite_master
 WHERE type = 'table'"
 ```
