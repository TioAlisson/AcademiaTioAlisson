// Alisson Cordova De Assis
using AcademiaTioAlisson.Domain.Enums;
using AcademiaTioAlisson.Domain.ValueObjects;

namespace AcademiaTioAlisson.Domain.Entities
{
    public class Colaborador : Pessoa
    {
        public DateOnly DataAdmissao { get; protected set; }
        public ColaboradorTipo Tipo { get; protected set; }
        public ColaboradorVinculo Vinculo { get; protected set; }

        public Colaborador(
            int id,
            string nome,
            Cpf cpf,
            DateOnly dataNascimento,
            Telefone telefone,
            Email email,
            Senha senha,
            Endereco endereco,
            DateOnly dataAdmissao,
            ColaboradorTipo tipo,
            ColaboradorVinculo vinculo,
            Arquivo? foto = null)
            : base(id, nome, cpf, dataNascimento, telefone, email, senha, endereco, foto)
        {
            DataAdmissao = dataAdmissao;
            Tipo = tipo;
            Vinculo = vinculo;
        }
    }
}
