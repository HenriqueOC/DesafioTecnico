using System;

namespace DesafioTecnico.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Renda { get; set; }

        public Pessoa(int id, string name, string type, DateTime date, int renda)
        {
            Id = id;
            Nome = name;
            Tipo = type;
            DataNascimento = date;
            Renda = renda;
        }

        public Pessoa()
        {
        }
    }
}
