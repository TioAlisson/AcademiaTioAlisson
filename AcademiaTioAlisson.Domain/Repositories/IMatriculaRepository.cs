// Alisson Cordova De Assis
using AcademiaTioAlisson.Domain.Entities;
using AcademiaTioAlisson.Domain.Enums;

namespace AcademiaTioAlisson.Domain.Repositories;

public interface IMatriculaRepository : IRepository<Matricula>
{
    Task<IEnumerable<Matricula>> ObterPorAluno(int alunoId, CancellationToken cancellationToken = default);
    Task<Matricula?> ObterMatriculaAtivaPorAluno(int alunoId, CancellationToken cancellationToken = default);
    Task<bool> PossuiMatriculaAtiva(int alunoId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Matricula>> ObterAtivas(int alunoId = 0, CancellationToken cancellationToken = default);
    Task<IEnumerable<Matricula>> ObterVencendoEmDias(int dias, CancellationToken cancellationToken = default);
    Task<IEnumerable<Matricula>> ObterPorPlano(MatriculaPlano plano, CancellationToken cancellationToken = default);
}