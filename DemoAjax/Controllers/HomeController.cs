#region using
using DemoAjax.Model;
using System.Web.Mvc;
#endregion

namespace DemoAjax.Controllers
{
    public class HomeController : Controller
    {
        #region Constructeur
        readonly Repository _repository;

        public HomeController()
        {
            _repository = new Repository();
        } 
        #endregion

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Xhr()
        {
            var personnes = _repository.Get();
            return View(personnes);
        }

        public ActionResult Fetch()
        {
            var personnes = _repository.Get();
            return View(personnes);
        }

        public ActionResult JQuery()
        {
            var personnes = _repository.Get();
            return View(personnes);
        }

        public ActionResult AHelper()
        {
            var personnes = _repository.Get();
            return View(personnes);
        }

        public ActionResult Details(int id)
        {
            //bool gg = Request.IsAjaxRequest();
            Personne personne = _repository.Details(id);

            //return PartialView("detail", personne);
            return View("detail", personne);
        }
    }
}