#region using
using System;

using System.Web.Mvc;
using System.Web.UI.WebControls;
using DemoAjax.Model;
#endregion

namespace DemoAjax.Controllers
{
    public class ContinentsController : Controller
    {
        #region Constructor
        ContinentBuilder _builder;
        public ContinentsController()
        {
            _builder = new ContinentBuilder();
        }
        #endregion

        #region Index
        // GET: Continents
        public ActionResult Index()
        {
            ContinentViewModel vm = _builder.Continents();
            return View(vm);
        }
        #endregion

        #region Index2
        // GET: Continents
        public ActionResult Index2()
        {
            ContinentViewModel vm = _builder.Continents();
            return View(vm);
        }
        #endregion
    }
}