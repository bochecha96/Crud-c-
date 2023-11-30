using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base (options){

        }

        public DbSet<FilmeModel> Filmes{ get; set; }
    }
}