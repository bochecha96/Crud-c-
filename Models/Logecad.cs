using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLocadora.Models
{
    public class Logecad
    {
         public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Permitido { get; set; }

        public string Nome { get; set; }
    }
}