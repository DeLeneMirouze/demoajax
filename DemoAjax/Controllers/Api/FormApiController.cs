using DemoAjax.Model;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Linq;


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
            Validate(etatCivil);

            if (!ModelState.IsValid)
            {
                // la validation a échouée
                etatCivil.ErrorMessages = GetModelStateErrors(ModelState);
                etatCivil.Success = false;

                return etatCivil;
            }

            etatCivil.Success = true;
            return etatCivil;
        }

        #region GetModelStateErrors (private)
        private List<string> GetModelStateErrors(ModelStateDictionary ModelState)
        {
            List<string> errorMessages = new List<string>();

            var validationErrors = ModelState.Values.Select(x => x.Errors);

            validationErrors.ToList().ForEach(ve =>
            {
                IEnumerable<string> errorStrings = ve.Select(x => x.ErrorMessage);
                errorStrings.ToList().ForEach(em =>
                {
                    errorMessages.Add(em);
                });
            });

            return errorMessages;
        }
        #endregion

        #region Validate (private)
        private void Validate(EtatCivil etatCivil)
        {
            if (etatCivil.Age < 18)
            {
                ModelState.AddModelError("age", "Age doit être plus grand que 18");
            }
            if (etatCivil.Civilite == 0)
            {
                ModelState.AddModelError("civilite", "Civilité est obligatoire");
            }
        } 
        #endregion
    }
}
