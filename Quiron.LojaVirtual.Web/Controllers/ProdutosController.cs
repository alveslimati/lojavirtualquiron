using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Quiron.LojaVirtual.Domain.Repositorio;
using Quiron.LojaVirtual.Domain.Entidades;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepository _produtosRepository;

        // GET: Produtos
        public ActionResult Index()
        {
            _produtosRepository = new ProdutosRepository();

            var listaProdutos = _produtosRepository.Produtos;
            return View(listaProdutos);
        }
    }
}