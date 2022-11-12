using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using ProjetoUnip.Models;
using ProjetoUnip.Data;
using System.Reflection.Metadata;

namespace ProjetoUnip.Interfaces
{
    public interface PessoaDAO : IDisposable
    {
        
        //Criar Pessoa
        public bool inserir(Pessoa p)
        {
            return false;
        }

        //Alterar Pessoa
        public bool alterar(Pessoa p)
        {
            return false;
        }

        //Pesquisar por CPF
        public Pessoa consultar(long cpf)
        {
            Pessoa p = new Pessoa();
            return p;
        }

        //Excluir Pessoa
        public bool excluir(Pessoa p)
        {
            return false;
        }
    }
}
