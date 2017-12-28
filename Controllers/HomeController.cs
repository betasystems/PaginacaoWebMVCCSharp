using System.Web.Mvc;

namespace PaginacaoWebMVCCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int pagina = 0)
        {
            var dtoPesquisaTeste = new Negocio.PesquisaTeste().RecuperarTodosPaginado(pagina);

            return View(dtoPesquisaTeste);
        }
    }
}