using DesafioTecnico.Entities.Criterios;
using System;



namespace DesafioTecnico.Entities
{
    public class CriterioDependentes : Criterio
    {
        public CriterioDependentes(int pts) : base(pts)
        {
        }

        public int VerificarDependentes(Familia familia)
        {
            CountDependentes obj = new CountDependentes();

            int count = obj.ContagemDependentes(familia);

            if (count >= 3)
            {
                Pts = 3;
            }
            else
            {
                switch (count)
                {
                    case 1:
                        Pts = 2;
                        break;

                    case 2:
                        Pts = 2;
                        break;

                    case 0:
                        Pts = 0;
                        break;

                    default:
                        Console.WriteLine("Quantidade inválida");
                        break;
                }
            }

            return Pts;

        }
    }
}
