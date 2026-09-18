// Alisson Assis
using AcademiaTioAlisson.Application.Enums;
using AcademiaTioAlisson.Domain.Enums;

namespace AcademiaTioAlisson.Application.Mappings;

public static class ColaboradorEnumMappingExtensions
{
    public static ColaboradorTipo ToDomain(this AppColaboradorTipo appTipo) => (ColaboradorTipo)appTipo;
    public static AppColaboradorTipo ToApplication(this ColaboradorTipo domainTipo) => (AppColaboradorTipo)domainTipo;
    public static ColaboradorVinculo ToDomain(this AppColaboradorVinculo appVinculo) => (ColaboradorVinculo)appVinculo;
    public static AppColaboradorVinculo ToApplication(this ColaboradorVinculo domainVinculo) => (AppColaboradorVinculo)domainVinculo;
}