#region 程序集 MySql.EntityFrameworkCore, Version=7.0.2.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d
// C:\Users\lsk15\.nuget\packages\mysql.entityframeworkcore\7.0.2\lib\net7.0\MySql.EntityFrameworkCore.dll
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using MySql.Data.MySqlClient;
using MySql.EntityFrameworkCore.Infrastructure.Internal;
using MySql.EntityFrameworkCore.Internal;

namespace MySql.EntityFrameworkCore.Infrastructure;

//
// 摘要:
//     Represents the Microsoft.EntityFrameworkCore.Infrastructure.RelationalDbContextOptionsBuilder`2
//     implementation for MySQL.
public class MySQLDbContextOptionsBuilder : RelationalDbContextOptionsBuilder<MySQLDbContextOptionsBuilder, MySQLOptionsExtension>
{
    //
    // 摘要:
    //     Initializes a new instance of the MySql.EntityFrameworkCore.Infrastructure.MySQLDbContextOptionsBuilder
    //     class.
    //
    // 参数:
    //   optionsBuilder:
    //     The options builder.
    public MySQLDbContextOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
        : base(optionsBuilder)
    {
    }

    internal virtual MySQLDbContextOptionsBuilder CharSet(CharacterSet charSet)
    {
        CharacterSet charSet2 = charSet;
        return WithOption((MySQLOptionsExtension e) => e.WithCharSet(charSet2));
    }

    //
    // 摘要:
    //     Configures the context to use the default retrying Microsoft.EntityFrameworkCore.Storage.IExecutionStrategy.
    public virtual MySQLDbContextOptionsBuilder EnableRetryOnFailure()
    {
        return ExecutionStrategy((ExecutionStrategyDependencies c) => new MySqlRetryingExecutionStrategy(c));
    }

    //
    // 摘要:
    //     Configures the context to use the default retrying Microsoft.EntityFrameworkCore.Storage.IExecutionStrategy.
    //
    //
    // 参数:
    //   maxRetryCount:
    //     The maximum number of retry attempts.
    public virtual MySQLDbContextOptionsBuilder EnableRetryOnFailure(int maxRetryCount)
    {
        return ExecutionStrategy((ExecutionStrategyDependencies c) => new MySqlRetryingExecutionStrategy(c, maxRetryCount));
    }

    //
    // 摘要:
    //     Configures the context to use the default retrying Microsoft.EntityFrameworkCore.Storage.IExecutionStrategy.
    //
    //
    // 参数:
    //   maxRetryCount:
    //     The maximum number of retry attempts.
    //
    //   maxRetryDelay:
    //     The maximum delay between retries.
    //
    //   errorNumbersToAdd:
    //     Additional SQL error numbers that should be considered transient.
    public virtual MySQLDbContextOptionsBuilder EnableRetryOnFailure(int maxRetryCount, TimeSpan maxRetryDelay, ICollection<int>? errorNumbersToAdd)
    {
        ICollection<int> errorNumbersToAdd2 = errorNumbersToAdd;
        return ExecutionStrategy((ExecutionStrategyDependencies c) => new MySqlRetryingExecutionStrategy(c, maxRetryCount, maxRetryDelay, errorNumbersToAdd2));
    }
}
#if false // 反编译日志
缓存中的 314 项
------------------
解析: "System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Runtime, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Runtime.dll"
------------------
解析: "System.Runtime.InteropServices, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Runtime.InteropServices, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Runtime.InteropServices.dll"
------------------
解析: "Microsoft.EntityFrameworkCore, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.EntityFrameworkCore, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Users\lsk15\.nuget\packages\microsoft.entityframeworkcore\7.0.2\lib\net6.0\Microsoft.EntityFrameworkCore.dll"
------------------
解析: "System.Data.Common, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Data.Common, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Data.Common.dll"
------------------
解析: "Microsoft.EntityFrameworkCore.Relational, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.EntityFrameworkCore.Relational, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Users\lsk15\.nuget\packages\microsoft.entityframeworkcore.relational\7.0.2\lib\net6.0\Microsoft.EntityFrameworkCore.Relational.dll"
------------------
解析: "System.Linq.Expressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Linq.Expressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Linq.Expressions.dll"
------------------
解析: "System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Collections, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Collections.dll"
------------------
解析: "MySql.Data, Version=8.0.33.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d"
找到单个程序集: "MySql.Data, Version=8.0.33.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d"
从以下位置加载: "C:\Users\lsk15\.nuget\packages\mysql.data\8.0.33\lib\net7.0\MySql.Data.dll"
------------------
解析: "System.Text.RegularExpressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Text.RegularExpressions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Text.RegularExpressions.dll"
------------------
解析: "System.Linq, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Linq, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Linq.dll"
------------------
解析: "Microsoft.Extensions.DependencyInjection.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.Extensions.DependencyInjection.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\7.0.15\ref\net7.0\Microsoft.Extensions.DependencyInjection.Abstractions.dll"
------------------
解析: "System.ComponentModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.ComponentModel, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.ComponentModel.dll"
------------------
解析: "Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.Extensions.Logging.Abstractions, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\7.0.15\ref\net7.0\Microsoft.Extensions.Logging.Abstractions.dll"
------------------
解析: "Microsoft.Extensions.DependencyInjection, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.Extensions.DependencyInjection, Version=7.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\7.0.15\ref\net7.0\Microsoft.Extensions.DependencyInjection.dll"
------------------
解析: "System.Threading.Thread, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
找到单个程序集: "System.Threading.Thread, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Threading.Thread.dll"
------------------
解析: "Microsoft.EntityFrameworkCore.Abstractions, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
找到单个程序集: "Microsoft.EntityFrameworkCore.Abstractions, Version=7.0.2.0, Culture=neutral, PublicKeyToken=adb9793829ddae60"
从以下位置加载: "C:\Users\lsk15\.nuget\packages\microsoft.entityframeworkcore.abstractions\7.0.2\lib\net6.0\Microsoft.EntityFrameworkCore.Abstractions.dll"
------------------
解析: "System.Runtime.CompilerServices.Unsafe, Version=7.0.0.0, Culture=neutral, PublicKeyToken=null"
找到单个程序集: "System.Runtime.CompilerServices.Unsafe, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
从以下位置加载: "C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\7.0.15\ref\net7.0\System.Runtime.CompilerServices.Unsafe.dll"
#endif
