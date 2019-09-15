using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace _01._02
{
    public class LojaDeFilmes
    {
        public List<Diretor> Diretores = new List<Diretor>();
        public List<Filme> Filmes = new List<Filme>();
    }

    [Serializable]
    public class Diretor : ISerializable
    {
        public string Nome { get; set; }
        public int NumeroFilmes;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(Nome), $"{Nome}");
            info.AddValue(nameof(NumeroFilmes), $"{NumeroFilmes}");
            info.AddValue("Resumo", $"Nome: ${Nome} Quantidade de Filmes: ${NumeroFilmes}");
        }
    }

    public class Filme
    {
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public string Ano { get; set; }
    }
}