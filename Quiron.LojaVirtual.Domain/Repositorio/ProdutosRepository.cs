using System;
using System.Collections.Generic;
using System.Data.Entity;
using Quiron.LojaVirtual.Domain.Entidades;

namespace Quiron.LojaVirtual.Domain.Repositorio
{
    public class ProdutosRepository
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
      
    }
}
