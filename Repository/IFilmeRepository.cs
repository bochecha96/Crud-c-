using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Repository
{
    public interface IFilmeRepository
    {
        FilmeModel Adicionar(FilmeModel filme);
        List<FilmeModel> ListarFilmes();
        FilmeModel BuscarId(int id);
        FilmeModel Atualizar(FilmeModel filme);
    }
}