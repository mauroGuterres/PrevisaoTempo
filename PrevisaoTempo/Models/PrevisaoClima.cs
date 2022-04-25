using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrevisaoTempo.Models
{
    [Serializable]
    public class PrevisaoClima
    {
       
        public int Id { get; set; }
        public Clima Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public DateTime DataPrevisao { get; set; }
        public int CidadeId { get; set; }        
        public Cidade Cidade { get; set; }

    }
}