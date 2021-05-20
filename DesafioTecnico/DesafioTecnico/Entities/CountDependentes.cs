using System;

namespace DesafioTecnico.Entities
{
    public class CountDependentes
    {
        public int CountD { get; set; }



        public int ContagemDependentes(Familia familia)
        {
            foreach (Pessoa people in familia.Pessoas)
            {
                DateTime dateToday = new DateTime();

                int idade = people.DataNascimento.Year - dateToday.Year;

                if (idade <= 18)
                {
                    CountD = +1;
                }
            }

            return CountD;
        }
    }
}
