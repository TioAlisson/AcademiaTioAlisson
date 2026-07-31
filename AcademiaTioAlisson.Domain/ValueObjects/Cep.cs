// Alisson Cordova De Assis

namespace AcademiaTioAlisson.Domain.ValueObjects
{
    public record Cep
    {
        public string Valor { get; }

        public Cep(string valor)
        {
            Valor = valor;
        }
    }
}
