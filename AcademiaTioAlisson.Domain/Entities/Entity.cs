// Alisson Cordova De Assis

using AcademiaTioAlisson.Domain.Exceptions;

namespace AcademiaTioAlisson.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }

        protected Entity(int id = 0)
        {
            if (id < 0) throw new ArgumentException("O ID não pode ser negativo.", nameof(id));
            Id = id;
        }
    }
}
