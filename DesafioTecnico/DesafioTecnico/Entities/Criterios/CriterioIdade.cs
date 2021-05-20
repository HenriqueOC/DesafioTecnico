using System;

namespace DesafioTecnico.Entities
{
    public class CriterioIdade : Criterios.Criterio
    {
        public CriterioIdade(int pts) : base(pts)
        {
        }

        public int VerificarIdade(Familia familia)
        {

            foreach (Pessoa pessoa in familia.Pessoas)
            {

                if (pessoa.Tipo == "Pretendente")
                {

                    Idade objIdade = new Idade();
                    int idade = objIdade.CalcularIdade(pessoa);

                    if (idade >= 45)
                    {
                        Pts = 3;
                        break;
                    }

                    else if (idade >= 30 && idade <= 44)
                    {
                        Pts = 2;
                        break;
                    }

                    else if (idade < 30)
                    {
                        Pts = 1;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Idade inválida");
                        break;
                    }

                }
            }

            return Pts;
        }
    }
}
