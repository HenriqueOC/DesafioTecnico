using System;

namespace DesafioTecnico.Entities
{
    public class CriterioRenda : Criterios.Criterio
    {
        public CriterioRenda(int pts) : base(pts)
        {
        }

        public int VerificarRenda(Familia familia)
        {

            double renda = familia.RendaTotal;

            if (renda < 900.00)
            {
                Pts = 5;
            }

            else if (renda >= 900.00 && renda <= 1500.00)
            {
                Pts = 3;
            }

            else if (renda >= 1501 && renda <= 2000)
            {
                Pts = 1;
            }

            else if (renda > 2000.00)
            {
                Pts = 0;
            }

            else
            {
                Console.WriteLine("Renda inválida");
            }

            return Pts;
        }
    }
}
