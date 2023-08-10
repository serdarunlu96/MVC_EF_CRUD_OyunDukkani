using System.ComponentModel.DataAnnotations;

namespace OyunDukkani.Data
{
    public class Oyunlar
    {
        public int Id { get; set; }
        public string OyunAdi { get; set; } = string.Empty;
        public double Fiyati { get; set; }
        public string Platformu { get; set; } = string.Empty;
        
        public string BarkodNumarasi { get; set; } = string.Empty;
        public bool TekPlatform { get; set; }
    }
}

