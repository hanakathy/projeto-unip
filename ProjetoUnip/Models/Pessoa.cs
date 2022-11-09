using System.Xml.Linq;

namespace ProjetoUnip.Models
{
    //Parou no minuto 6:50
    public class Pessoa
    {
        protected int Id { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone [] Telefone {get; set;}

        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, long cpf, Endereco endereco, Telefone[] telefones)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefones;
        }
    }
}
