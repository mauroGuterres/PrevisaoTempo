using PrevisaoTempo.Context;
using PrevisaoTempo.Contracts;
using PrevisaoTempo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PrevisaoTempo.Repository
{
    public class PrevisaoClimaRepository : IPrevisaoClimaRepository
    {

        private PrevisaoTempoContext _context;

        public PrevisaoClimaRepository(PrevisaoTempoContext context) {
            _context = context;
        }

        public async Task AddPrevisaoClima(PrevisaoClima PrevisaoClima)
        {
            _context.PrevisaoClima.Add(PrevisaoClima);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<PrevisaoClima>> GetCidadesMaisFrias()
        {
            var today = DateTime.Now.Date;
            var cidadesMaisFrias = await _context.PrevisaoClima.
                Where(x => DbFunctions.TruncateTime(x.DataPrevisao) == today).
                OrderBy(x => x.TemperaturaMaxima).
                Include(x => x.Cidade).
                Include(x => x.Cidade.Estado).
                AsNoTracking().
                Take(3).
                ToListAsync();
            return cidadesMaisFrias;
        }

        public async Task<IList<PrevisaoClima>> GetCidadesMaisQuentes()
        {
            var today = DateTime.Now.Date;
            var cidadesMaisQuentes = await _context.PrevisaoClima.
                Where(x => DbFunctions.TruncateTime(x.DataPrevisao).Value == today).
                OrderByDescending(x => x.TemperaturaMinima).
                Include(x =>x.Cidade).
                Include(x => x.Cidade.Estado).
                AsNoTracking().Take(3).
                ToListAsync();
            return cidadesMaisQuentes;
        }

        public async Task<IList<PrevisaoClima>> GetPrevisaoClimaParaSemana(int cidadeId)
        {
            var dateLimit = DateTime.Now.AddDays(7).Date;
            var previsaoSemana = await _context.PrevisaoClima.Where(previsao => previsao.CidadeId == cidadeId
            && DbFunctions.TruncateTime(previsao.DataPrevisao) > DbFunctions.TruncateTime(DateTime.Now)
            && DbFunctions.TruncateTime(previsao.DataPrevisao) <= dateLimit).Include(x => x.Cidade).
            AsNoTracking().OrderBy(x => x.DataPrevisao).ToListAsync();
            return previsaoSemana;
        }
    }
}