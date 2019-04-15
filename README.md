# InvokeSQLiteQuery
PowerShell Cmdlet to invoke a SQLite query to your SQLite database

## Folder structur of the Cmdlet
The folder structure will look like this:

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

The files 'sqlite3.dll', 'libsqlite3.so' and 'libsqlite3.dylib' need to be copied to the root folder.

