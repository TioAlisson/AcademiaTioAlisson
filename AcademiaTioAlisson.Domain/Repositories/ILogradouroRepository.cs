// Alisson Cordova De Assis
using AcademiaTioAlisson.Domain.Entities;
using AcademiaTioAlisson.Domain.ValueObjects;

namespace AcademiaTioAlisson.Domain.Repositories;

public interface ILogradouroRepository : IRepository<Logradouro>
{
    Task<Logradouro?> ObterPorCep(Cep cep, CancellationToken cancellationToken = default);
    Task<bool> CepJaExiste(Cep cep, int? id = null, CancellationToken cancellationToken = default);
    Task<IEnumerable<Logradouro>> ObterPorCidade(string cidade, CancellationToken cancellationToken = default);
    Task<IEnumerable<Logradouro>> ObterPorBairro(string cidade, string bairro, CancellationToken cancellationToken = default);
}