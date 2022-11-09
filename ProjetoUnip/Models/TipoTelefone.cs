namespace ProjetoUnip.Models
{
    public class TipoTelefone
    {
        protected int Id { get; set; }
        public string Tipo { get; set; }

        public TipoTelefone()
        {
        }

        public TipoTelefone(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}
