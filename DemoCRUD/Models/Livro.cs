using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCRUD.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoEdicao { get; set; }
        public decimal Valor { get; set; }

        //Associañdo a classe gênero a livro
        public Genero Genero { get; set; }
        public Genero GeneroId { get; set; }
        //Desta forma, o entity entende que GeneroID é a chave estrangeira de Genero para livro
    }
}