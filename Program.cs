﻿using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace _01._02
{

    class Program
    {
        static void Main(string[] args)
        {
            var @object = ObterDados();

            using (var fs = new FileStream("personalizado.xml", FileMode.Create, FileAccess.Write))
            {
                new XmlSerializer(typeof(LojaDeFilmes)).Serialize(fs, @object);
            }
        }

        private static LojaDeFilmes ObterDados()
        {
            return new LojaDeFilmes
            {
                Diretores = new List<Diretor>
                {
                    new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                    new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                    new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                    new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                    new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                    new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                    new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                    new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                    new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 }
                },
                Filmes = new List<Filme> {
                    new Filme {
                        Diretor = new Diretor { Nome = "James Cameron", NumeroFilmes = 5 },
                        Titulo = "Avatar",
                        Ano = "2009"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Francis Lawrence", NumeroFilmes = 3 },
                        Titulo = "I Am Legend",
                        Ano = "2007"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Zack Snyder", NumeroFilmes = 6 },
                        Titulo = "300",
                        Ano = "2006"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Joss Whedon", NumeroFilmes = 7 },
                        Titulo = "The Avengers",
                        Ano = "2012"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Martin Scorsese", NumeroFilmes = 4 },
                        Titulo = "The Wolf of Wall Street",
                        Ano = "2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Christopher Nolan", NumeroFilmes = 8 },
                        Titulo = "Interstellar",
                        Ano = "2014"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Game of Thrones",
                        Ano = "2011–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Vikings",
                        Ano = "2013–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Gotham",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Power",
                        Ano = "2014–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Narcos",
                        Ano = "2015–"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Breaking Bad",
                        Ano = "2008–2013"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Scott Derrickson", NumeroFilmes = 4 },
                        Titulo = "Doctor Strange",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Gareth Edwards", NumeroFilmes = 3 },
                        Titulo = "Rogue One: A Star Wars Story",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "Justin Kurzel", NumeroFilmes = 6 },
                        Titulo = "Assassin's Creed",
                        Ano = "2016"
                    },
                    new Filme {
                        Diretor = new Diretor { Nome = "N/A" },
                        Titulo = "Luke Cage",
                        Ano = "2016–"
                    }
                }
            };
        }
    }
}
