using Nancy.Json;
using System;

namespace DesafioTecnico.Entities
{
    public class Contemplados
    {
        public int Id { get; set; }
        public int CriteriosAtendidos { get; set; }
        public int PontuacaoFinal { get; set; }
        public DateTime DataDeSelecao { get; set; }


        public Contemplados(int id, int criteriosAtendidos, int pontuacaoFinal, DateTime dataDeSeleção)
        {
            Id = id;
            CriteriosAtendidos = criteriosAtendidos;
            PontuacaoFinal = pontuacaoFinal;
            DataDeSelecao = dataDeSeleção;
        }

        public Contemplados()
        {
        }

        public void Contemplar(Familia familia)
        {

            Contemplados contemplacao = new Contemplados
            {
                Id = familia.Id,
                PontuacaoFinal = familia.Pontuacao,
                CriteriosAtendidos = familia.CriteriosAtendidos,
                DataDeSelecao = DateTime.Now
            };

            var familiaContemplada = new JavaScriptSerializer().Serialize(contemplacao);

            System.IO.File.WriteAllText(@"C:\Users\henri\source\repos\DesafioTecnico\DesafioTecnico\Entities\Contemplados\" + contemplacao.Id + ".json", familiaContemplada);

        }

    }
}
