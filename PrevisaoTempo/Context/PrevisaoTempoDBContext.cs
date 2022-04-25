using PrevisaoTempo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PrevisaoTempo.Context
{
    public class PrevisaoTempoContext : DbContext
    {
        public PrevisaoTempoContext() : base("PrevisaoTempoContext")
        {
        }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClima { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<PrevisaoClima>().HasRequired(x => x.Cidade).WithMany(x => x.PrevisaoClima);
            modelBuilder.Entity<Cidade>().HasRequired(X => X.Estado).WithMany(x => x.Cidade);
        }

    }
}