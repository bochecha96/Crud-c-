using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoLocadora.Data;
using ProjetoLocadora.Models;


namespace ProjetoLocadora.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly BancoContext _bancoContext;

        public FilmeRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public FilmeModel Adicionar(FilmeModel filme)
        {
            _bancoContext.Filmes.Add(filme);
            _bancoContext.SaveChanges();
            return filme;
        }

        public List<FilmeModel> ListarFilmes()
        {
            return _bancoContext.Filmes.ToList();
        }

        public FilmeModel BuscarId(int id)
        {
            return _bancoContext.Filmes.FirstOrDefault(x => x.Id == id);
        }


        public FilmeModel Atualizar(FilmeModel filme)
        {
            FilmeModel filmeDB = BuscarId(filme.Id);

            if (filmeDB == null) throw new Exception("Filme não foi encontrado.");
            filmeDB.Titulo = filme.Titulo;
            filmeDB.Sinopse = filme.Sinopse;
            filmeDB.Classificacao = filme.Classificacao;

            _bancoContext.Filmes.Update(filmeDB);
            _bancoContext.SaveChanges();
            return filmeDB;

        }

        public bool deletar(int id){
            FilmeModel filmeDB = BuscarId(id);
            if (filmeDB == null) throw new Exception("Filme não foi encontrado.");
            _bancoContext.Filmes.Remove(filmeDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}


