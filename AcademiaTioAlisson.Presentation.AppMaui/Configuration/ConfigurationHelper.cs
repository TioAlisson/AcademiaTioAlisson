// Alisson Assis
using AcademiaTioAlisson.Application.DependencyInjection;
using AcademiaTioAlisson.Application.Enums;
using AcademiaTioAlisson.Application.Mappings;

namespace AcademiaTioAlisson.Presentation.AppMaui.Configuration;

public static class ConfigurationHelper
{
    public static void ConfigureServices(IServiceCollection services)
    {
        var databaseType = AppDatabaseType.Sqlite;

        // Aponta diretamente para o banco que os testes alimentaram
        var dbPath = DeviceInfo.Platform == DevicePlatform.WinUI
            ? @"C:\Users\aliss\workspace\AcademiaTioAlisson\AcademiaTioAlisson.Infrastructure.Tests\bin\Debug\net10.0\db_academia_do_tioalisson.db"
            : Path.Combine(FileSystem.AppDataDirectory, "db_academia_do_tioalisson.db");

        string connectionString = $"Data Source={dbPath};Default Timeout=5;";

        services.AddSingleton(new RepositoryConfig
        {
            ConnectionString = connectionString,
            DatabaseType = databaseType.ToInfrastructure()
        });

        services.AddApplicationServices();
    }
}