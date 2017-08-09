using DemoAjax.Model;
using System.Web.Http;

namespace DemoAjax.Controllers.Api
{
    public class FormApiController : ApiController
    {
        public FormViewModel Get()
        {
            FormViewModel vm = new FormViewModel();
            vm.EtatCivil = new EtatCivil();

            Civilite cv = new Civilite() { Id = 1, Label = "Monsieur" };
            vm.Civilites.Add(cv);
            cv = new Civilite() { Id = 2, Label = "Madame" };
            vm.Civilites.Add(cv);
            cv = new Civilite() { Id = 3, Label = "Mademoiselle" };
            vm.Civilites.Add(cv);

            return vm;
        }

        [HttpPost]
        public EtatCivil Post(EtatCivil etatCivil)
        {
            if (etatCivil.Age <= 0)
            {

            }

            return etatCivil;
        }
    }
}
