using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using ProjetoUnip.Interfaces;
using ProjetoUnip.Models;
using System.Linq;

namespace ProjetoUnip.Controllers.Pessoa
{
    //[Route("api/v1/[controller]")]
    public class PessoaController : Controller, PessoaDAO
    {
        private readonly ProjetoUnipContext _context;

        public PessoaController (ProjetoUnipContext context)
        {
            _context = context;
        }

        //Criando Pessoa
        /* [HttpPost]
        [Route("pessoa")] */
        public bool inserir(Models.Pessoa pessoa)
        {
            _context.Add(pessoa);
            _context.SaveChanges();

            return true;
        }

        //Alterando
        /* [HttpPut]
        [Route("pessoa/{id}")] */
        public bool alterar(Models.Pessoa p)
        {
            _context.Pessoa.Update(p);
            _context.SaveChanges();

            return false;
        }

        //Pesquisar por CPF
        /* [HttpGet]
        [Route("pessoa/{cpf}")] */
        public Models.Pessoa consultar(long cpf)
        {
            var p = _context.Pessoa.Find(cpf);

            return p;
        }

        //Excluir Pessoa
        /*[HttpDelete]
        [Route("pessoa/{id}")] */
        public bool excluir(Models.Pessoa p)
        {
            _context.Pessoa.Remove(p);
            _context.SaveChanges();
            return true;
        }
    }

}
