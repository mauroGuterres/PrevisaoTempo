using PrevisaoTempo.Contracts;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PrevisaoTempo.Controllers
{
    public class HomeController : Controller
    {
        private IPrevisaoClimaRepository _previsao;
        private ICidadeRepository _cidade;

        public HomeController(IPrevisaoClimaRepository previsao, ICidadeRepository cidade) {
            _previsao = previsao;
            _cidade = cidade;
        }
        public ActionResult Index()
        {
            return View();
        }

        public async Task <ActionResult> PrevisaoTempo() {
            ViewBag.CidadesMaisFrias = await _previsao.GetCidadesMaisFrias();
            ViewBag.CidadesMaisQuentes = await _previsao.GetCidadesMaisQuentes();
            ViewBag.Cidades = await _cidade.GetCidades();
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetPrevisaoCidade(int cidadeId) {
            var previsaoCidade = await _previsao.GetPrevisaoClimaParaSemana(cidadeId);
            return Json(previsaoCidade, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}