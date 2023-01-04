﻿using ChapterSenaiUC17.Contexts;
using ChapterSenaiUC17.Models;

namespace ChapterSenaiUC17.Repositories
{
    public class LivroRepository
    {
        private readonly Sqlcontext _context;
        public LivroRepository(Sqlcontext context)
        {
            _context = context;

        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}