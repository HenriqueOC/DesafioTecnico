using DesafioTecnico.Entities.Enums;
using System.Collections.Generic;

namespace DesafioTecnico.Entities
{
    public class Familia
    {
        public int Id { get; set; }
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
        public FamilyStatus StatusFamilia { get; set; }

        public int Pontuacao { get; set; } = 0;
        public int Dependentes { get; set; } = 0;
        public double RendaTotal { get; set; } = 00.00;
        public int CriteriosAtendidos { get; set; } = 0;

        public Familia(int id, List<Pessoa> peoples, FamilyStatus status, int score, int dependents, double totalIncome)
        {
            Id = id;
            Pessoas = peoples;
            StatusFamilia = status;
            Pontuacao = score;
            Dependentes = dependents;
            RendaTotal = totalIncome;
        }

        public Familia()
        {
        }
    }
}
