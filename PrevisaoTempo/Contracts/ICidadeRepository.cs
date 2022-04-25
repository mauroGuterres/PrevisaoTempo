using PrevisaoTempo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevisaoTempo.Contracts
{
   public interface ICidadeRepository
    {
        Task<List<Cidade>> GetCidades();
    }
}
