// Alisson Cordova De Assis

namespace AcademiaTioAlisson.Domain.ValueObjects
{
    public record Senha
    {
        public string Valor { get; }

        public Senha(string valor)
        {
            Valor = valor;
        }
    }
}
