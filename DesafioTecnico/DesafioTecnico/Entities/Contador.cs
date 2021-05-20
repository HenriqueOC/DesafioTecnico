using System;

namespace DesafioTecnico.Entities
{
    class Contador
    {
        public void AplicarCriterios(Familia familia)
        {

            switch (familia.StatusFamilia)
            {
                case Enums.FamilyStatus.CadastroValido:

                    CriterioDependentes objDependentes = new CriterioDependentes(0);
                    int pts = objDependentes.VerificarDependentes(familia);
                    familia.Pontuacao += pts;

                    CriterioIdade objIdade = new CriterioIdade(0);
                    pts = objIdade.VerificarIdade(familia);
                    familia.Pontuacao += pts;

                    CriterioRenda objRenda = new CriterioRenda(0);
                    pts = objRenda.VerificarRenda(familia);
                    familia.Pontuacao += pts;

                    break;

                case Enums.FamilyStatus.JaPossuiCasa:

                    Console.WriteLine("Família já possui uma casa");

                    break;

                case Enums.FamilyStatus.SelecionadaOutroProcesso:

                    Console.WriteLine("Família já está concorrendo em outro processo de seleção");

                    break;

                case Enums.FamilyStatus.CadastroIncompleto:

                    Console.WriteLine("Família está com o cadastro incompleto.");

                    break;

                default:

                    break;
            }

            Contemplados objContemplacao = new Contemplados();
            objContemplacao.Contemplar(familia);

        }





    }
}
