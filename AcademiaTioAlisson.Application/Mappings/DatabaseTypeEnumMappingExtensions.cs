// Alisson Assis
using AcademiaTioAlisson.Application.Enums;
using AcademiaTioAlisson.Infrastructure.Data;

namespace AcademiaTioAlisson.Application.Mappings;

public static class DatabaseTypeEnumMappingExtensions
{
    public static DatabaseType ToInfrastructure(this AppDatabaseType appDatabaseType)
    {
        return (DatabaseType)appDatabaseType;
    }

    public static AppDatabaseType ToApplication(this DatabaseType databaseType)
    {
        return (AppDatabaseType)databaseType;
    }
}