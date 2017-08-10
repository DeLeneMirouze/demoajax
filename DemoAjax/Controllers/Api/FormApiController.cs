using DemoAjax.Model;
using System.Web.Http;

namespace DemoAjax.Controllers.Api
{
    public class FormApiController : ApiController
    {
        public FormViewModel Get()
        {
            FormViewModelBuilder builder = new FormViewModelBuilder();
            FormViewModel vm = builder.Build();

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
