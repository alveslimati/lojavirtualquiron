using System.Linq;
using System.Web.Mvc;
using Quiron.LojaVirtual.Domain.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepository _produtosRepository;
        public int ProdutosPorPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina)
        {
            _produtosRepository = new ProdutosRepository();
            var produtos = _produtosRepository.Produtos
                .OrderBy(p => p.Categoria)
                .Skip((pagina - 1)*ProdutosPorPagina)
                .Take(ProdutosPorPagina);
            
            return View(produtos);
        }
    }
}