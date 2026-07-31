// Alisson Cordova De Assis
using AcademiaTioAlisson.Domain.Enums;
using AcademiaTioAlisson.Domain.ValueObjects;

namespace AcademiaTioAlisson.Domain.Entities
{
    public class AcessoColaborador : Entity
    {
        public Colaborador Colaborador { get; protected set; }
        public DateTime DataHoraChegada { get; protected set; }
        public DateTime? DataHoraSaida { get; protected set; }

        public AcessoColaborador(int id, Colaborador colaborador, DateTime dataHoraChegada, DateTime? dataHoraSaida = null) : base(id)
        {
            Colaborador = colaborador;
            DataHoraChegada = dataHoraChegada;
            DataHoraSaida = dataHoraSaida;
        }
    }
}
