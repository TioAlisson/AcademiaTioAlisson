// Alisson Cordova De Assis
using AcademiaTioAlisson.Domain.Entities;

namespace AcademiaTioAlisson.Domain.Repositories;

public interface IAcessoColaboradorRepository : IRepository<AcessoColaborador>
{
    Task<IEnumerable<AcessoColaborador>> ObterAcessosPorColaboradorPeriodo(int? colaboradorId = null, DateOnly? inicio = null, DateOnly? fim = null, CancellationToken cancellationToken = default);
    Task<AcessoColaborador?> ObterUltimoAcesso(int colaboradorId, CancellationToken cancellationToken = default);
    Task<TimeSpan> ObterHorasTrabalhadasNoDia(int colaboradorId, DateOnly data, CancellationToken cancellationToken = default);
}