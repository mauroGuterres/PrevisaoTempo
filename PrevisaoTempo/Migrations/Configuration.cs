namespace PrevisaoTempo.Migrations
{
    using PrevisaoTempo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<PrevisaoTempo.Context.PrevisaoTempoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrevisaoTempo.Context.PrevisaoTempoContext context)
        {

            var estados = new List<Estado>
            {
                new Estado{Id = 33,Nome="Rio Grande do Sul",UF="RS"},
                new Estado{Id = 34,Nome="Rio de Janeiro",UF="RJ"},
                new Estado{Id = 35,Nome="Bahia",UF="BA"},
                new Estado{Id = 36,Nome="Ceará",UF="CE"},
                new Estado{Id = 37,Nome="Espirito Santo",UF="ES"},
                new Estado{Id = 38,Nome="Paraná",UF="PR"},
                new Estado{Id = 39,Nome="Goiás",UF="GO"},
                new Estado{Id = 40,Nome="Santa Catarina",UF="SC"}
            };

            estados.ForEach(x => context.Estado.AddOrUpdate(u => u.UF, x));
            context.SaveChanges();

            var cidades = new List<Cidade> {
                new Cidade{Id = 27, Nome = "Porto Alegre",EstadoId = 33 },
                new Cidade{Id = 28, Nome = "Niteróí",EstadoId = 34 },
                new Cidade{Id = 29, Nome = "Salvador",EstadoId = 35 },
                new Cidade{Id = 30, Nome = "Fortaleza",EstadoId = 36 },
                new Cidade{Id = 31, Nome = "Vitória",EstadoId = 37 },
                new Cidade{Id = 32, Nome = "Curitiba",EstadoId = 38 },
                new Cidade{Id = 33, Nome = "Goiânia",EstadoId = 39 },
                new Cidade{Id = 34, Nome = "Florianópolis",EstadoId = 40 }
            };

            cidades.ForEach(x => context.Cidade.AddOrUpdate(y => y.Nome, x));
            context.SaveChanges();

            var previsaoClima = new List<PrevisaoClima> {
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 18, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 27,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Quente,DataPrevisao = DateTime.Now,TemperaturaMaxima = 35, TemperaturaMinima = 20 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 32, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 18, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 28,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 29,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 30,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 31,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 32,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 33,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Quente,DataPrevisao = DateTime.Now,TemperaturaMaxima = 36, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 34,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },

            };

            previsaoClima.ForEach(x => context.PrevisaoClima.AddOrUpdate(u => u.DataPrevisao, x));
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
