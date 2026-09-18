// Alisson Assis
using AcademiaTioAlisson.Infrastructure.Data;

namespace AcademiaTioAlisson.Application.DependencyInjection;

public class RepositoryConfig
{
    public required string ConnectionString { get; set; }
    public required DatabaseType DatabaseType { get; set; }
}