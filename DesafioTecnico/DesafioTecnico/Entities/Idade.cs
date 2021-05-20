using System;

namespace DesafioTecnico.Entities
{
    public class Idade
    {
        public int CalcularIdade(Pessoa pessoa)
        {

            DateTime dateToday = new DateTime();

            int idade = pessoa.DataNascimento.Year - dateToday.Year;


            return idade;
        }


    }


}
