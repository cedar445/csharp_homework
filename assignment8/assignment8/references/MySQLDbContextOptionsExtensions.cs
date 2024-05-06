using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.EntityFrameworkCore.Infrastructure;
using MySql.EntityFrameworkCore.Infrastructure.Internal;
using MySql.EntityFrameworkCore.Utils;
namespace Microsoft.EntityFrameworkCore
{
    public static class MySQLDbContextOptionsExtensions
    {
        //
        // 摘要:
        //     Configures the context to connect to a MySQL database, but without initially
        //     setting any System.Data.Common.DbConnection or connection string.
        //
        //     The connection or connection string must be set before the Microsoft.EntityFrameworkCore.DbContext
        //     is used to connect to a database. Set a connection using Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.SetDbConnection(Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade,System.Data.Common.DbConnection).
        //     Set a connection string using Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.SetConnectionString(Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade,System.String).
        //
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder UseMySQL(this DbContextOptionsBuilder optionsBuilder, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null)
        {
            Check.NotNull(optionsBuilder, "optionsBuilder");
            MySQLOptionsExtension orCreateExtension = GetOrCreateExtension(optionsBuilder);
            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(orCreateExtension);
            ConfigureWarnings(optionsBuilder);
            mySqlOptionsAction?.Invoke(new MySQLDbContextOptionsBuilder(optionsBuilder));
            return optionsBuilder;
        }

        //
        // 摘要:
        //     Configures the context used to connect to a MySQL database.
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   connectionString:
        //     The connection string of the database to connect to.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder UseMySQL(this DbContextOptionsBuilder optionsBuilder, string connectionString, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null)
        {
            Check.NotNull(optionsBuilder, "optionsBuilder");
            Check.NotEmpty(connectionString, "connectionString");
            MySQLOptionsExtension extension = (MySQLOptionsExtension)GetOrCreateExtension(optionsBuilder).WithConnectionString(connectionString);
            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(extension);
            ConfigureWarnings(optionsBuilder);
            mySqlOptionsAction?.Invoke(new MySQLDbContextOptionsBuilder(optionsBuilder));
            return optionsBuilder;
        }

        //
        // 摘要:
        //     Configures the context to connect to a MySQL database.
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   connection:
        //     An existing System.Data.Common.DbConnection to be used to connect to the database.
        //     If the connection is in the open state, then Entity Framework (EF) will not open
        //     or close the connection. If the connection is in the closed state, then EF will
        //     open and close the connection as needed.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder UseMySQL(this DbContextOptionsBuilder optionsBuilder, DbConnection connection, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null)
        {
            Check.NotNull(optionsBuilder, "optionsBuilder");
            Check.NotNull(connection, "connection");
            MySQLOptionsExtension extension = (MySQLOptionsExtension)GetOrCreateExtension(optionsBuilder).WithConnection(connection);
            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(extension);
            ConfigureWarnings(optionsBuilder);
            mySqlOptionsAction?.Invoke(new MySQLDbContextOptionsBuilder(optionsBuilder));
            return optionsBuilder;
        }

        //
        // 摘要:
        //     Configures the context to connect to a MySQL database, but without initially
        //     setting any System.Data.Common.DbConnection or connection string.
        //
        //     The connection or connection string must be set before the Microsoft.EntityFrameworkCore.DbContext
        //     is used to connect to a database. Set a connection using Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.SetDbConnection(Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade,System.Data.Common.DbConnection).
        //     Set a connection string using Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.SetConnectionString(Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade,System.String).
        //
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder<TContext> UseMySQL<TContext>(this DbContextOptionsBuilder<TContext> optionsBuilder, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null) where TContext : DbContext
        {
            return (DbContextOptionsBuilder<TContext>)((DbContextOptionsBuilder)optionsBuilder).UseMySQL(mySqlOptionsAction);
        }

        //
        // 摘要:
        //     Configures the context to connect to a MySQL database.
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   connectionString:
        //     The connection string of the database to connect to.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 类型参数:
        //   TContext:
        //     The type of context to be configured.
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder<TContext> UseMySQL<TContext>(this DbContextOptionsBuilder<TContext> optionsBuilder, string connectionString, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null) where TContext : DbContext
        {
            return (DbContextOptionsBuilder<TContext>)((DbContextOptionsBuilder)optionsBuilder).UseMySQL(connectionString, mySqlOptionsAction);
        }

        //
        // 摘要:
        //     Configures the context to connect to a MySQL database.
        //
        // 参数:
        //   optionsBuilder:
        //     The builder being used to configure the context.
        //
        //   connection:
        //     An existing System.Data.Common.DbConnection to be used to connect to the database.
        //     If the connection is in the open state, then Entity Framework (EF) will not open
        //     or close the connection. If the connection is in the closed state, then EF will
        //     open and close the connection as needed.
        //
        //   mySqlOptionsAction:
        //     An optional action to enable additional MySQL server-specific configuration.
        //
        //
        // 类型参数:
        //   TContext:
        //     The type of context to be configured.
        //
        // 返回结果:
        //     The options builder so that further configuration can be chained.
        public static DbContextOptionsBuilder<TContext> UseMySQL<TContext>(this DbContextOptionsBuilder<TContext> optionsBuilder, DbConnection connection, Action<MySQLDbContextOptionsBuilder>? mySqlOptionsAction = null) where TContext : DbContext
        {
            return (DbContextOptionsBuilder<TContext>)((DbContextOptionsBuilder)optionsBuilder).UseMySQL(connection, mySqlOptionsAction);
        }

        private static MySQLOptionsExtension GetOrCreateExtension(DbContextOptionsBuilder optionsBuilder)
        {
            MySQLOptionsExtension mySQLOptionsExtension = optionsBuilder.Options.FindExtension<MySQLOptionsExtension>();
            if (mySQLOptionsExtension == null)
            {
                return new MySQLOptionsExtension();
            }

            return new MySQLOptionsExtension(mySQLOptionsExtension);
        }

        private static void ConfigureWarnings(DbContextOptionsBuilder optionsBuilder)
        {
            CoreOptionsExtension coreOptionsExtension = optionsBuilder.Options.FindExtension<CoreOptionsExtension>() ?? new CoreOptionsExtension();
            coreOptionsExtension = coreOptionsExtension.WithWarningsConfiguration(coreOptionsExtension.WarningsConfiguration.TryWithExplicit(RelationalEventId.AmbientTransactionWarning, WarningBehavior.Throw));
            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(coreOptionsExtension);
        }
    }
}
