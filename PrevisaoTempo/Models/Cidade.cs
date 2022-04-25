using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace PrevisaoTempo.Models
{
    
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        [ScriptIgnore]
        public List<PrevisaoClima> PrevisaoClima { get; set; }

    }
}