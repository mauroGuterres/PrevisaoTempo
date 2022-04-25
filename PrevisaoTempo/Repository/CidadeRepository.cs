using PrevisaoTempo.Context;
using PrevisaoTempo.Contracts;
using PrevisaoTempo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PrevisaoTempo.Repository
{
    public class CidadeRepository : ICidadeRepository
    {
        private PrevisaoTempoContext _context;

        public CidadeRepository(PrevisaoTempoContext context)
        {
            _context = context;
        }

        public async Task<List<Cidade>> GetCidades()
        {
            var cidades = await _context.Cidade.OrderBy(x => x.Nome).ToListAsync();
            return cidades;
        }
    }
}