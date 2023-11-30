using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class FilmeModel
    {
         public int Id { get; set; }

        public string Titulo { get; set; }

        public string Sinopse { get; set;}

        public int Classificacao { get; set;}
    }
}