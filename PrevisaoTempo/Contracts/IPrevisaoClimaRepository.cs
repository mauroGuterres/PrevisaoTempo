using PrevisaoTempo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevisaoTempo.Contracts
{
   public interface IPrevisaoClimaRepository
    {        
        Task<IList<PrevisaoClima>> GetPrevisaoClimaParaSemana(int cidadeId);
        Task<IList<PrevisaoClima>> GetCidadesMaisFrias();
        Task<IList<PrevisaoClima>> GetCidadesMaisQuentes();
    }
}
