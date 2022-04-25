namespace PrevisaoTempo.Migrations
{
    using PrevisaoTempo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                new Estado{Nome="Rio Grande do Sul",UF="RS"},
                new Estado{Nome="Rio de Janeiro",UF="RJ"},
                new Estado{Nome="Bahia",UF="BA"},
                new Estado{Nome="Ceará",UF="CE"},
                new Estado{Nome="Espirito Santo",UF="ES"},
                new Estado{Nome="Paraná",UF="PR"},
                new Estado{Nome="Goiás",UF="GO"},
                new Estado{Nome="Santa Catarina",UF="SC"}
            };
            if (!context.Estado.Any()) {
                estados.ForEach(x => context.Estado.Add(x));
                context.SaveChanges();
            }
            

            var cidades = new List<Cidade> {
                new Cidade{ Nome = "Porto Alegre",EstadoId = 1 },
                new Cidade{ Nome = "Niteróí",EstadoId = 2 },
                new Cidade{ Nome = "Salvador",EstadoId = 3 },
                new Cidade{ Nome = "Fortaleza",EstadoId = 4 },
                new Cidade{ Nome = "Vitória",EstadoId = 5 },
                new Cidade{ Nome = "Curitiba",EstadoId = 6 },
                new Cidade{ Nome = "Goiânia",EstadoId = 7 },
                new Cidade{ Nome = "Florianópolis",EstadoId = 8 }
            };
            if (!context.Cidade.Any()) {
                cidades.ForEach(x => context.Cidade.Add(x));
                context.SaveChanges();
            }
            

            var previsaoClima = new List<PrevisaoClima> {
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 18, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 1,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Quente,DataPrevisao = DateTime.Now,TemperaturaMaxima = 35, TemperaturaMinima = 20 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 32, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 18, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 2,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 3,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 4,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 5,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 6,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Frio,DataPrevisao = DateTime.Now,TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 7,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Quente,DataPrevisao = DateTime.Now,TemperaturaMaxima = 36, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(1),TemperaturaMaxima = 26, TemperaturaMinima = 12 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(2),TemperaturaMaxima = 40, TemperaturaMinima = 24 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Ensolarado,DataPrevisao = DateTime.Now.AddDays(3),TemperaturaMaxima = 23, TemperaturaMinima = 14 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Chuvoso,DataPrevisao = DateTime.Now.AddDays(4),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(5),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Frio,DataPrevisao = DateTime.Now.AddDays(6),TemperaturaMaxima = 35, TemperaturaMinima = 23 },
                new PrevisaoClima{ CidadeId = 8,Clima = Clima.Quente,DataPrevisao = DateTime.Now.AddDays(7),TemperaturaMaxima = 35, TemperaturaMinima = 23 },

            };

            if (!context.PrevisaoClima.Any()) {
                previsaoClima.ForEach(x => context.PrevisaoClima.Add(x));
                context.SaveChanges();
            }
            
        }
    }
}
