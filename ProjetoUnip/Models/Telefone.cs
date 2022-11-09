﻿namespace ProjetoUnip.Models
{
    public class Telefone
    {
        protected int Id { get; set; }
        public int Numero { get; set; }
        public int Ddd { get; set; }
        public TipoTelefone Tipo { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, int numero, int ddd, TipoTelefone tipo)
        {
            Id = id;
            Numero = numero;
            Ddd = ddd;
            Tipo = tipo;
        }
    }
}
