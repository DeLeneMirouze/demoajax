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
            // Validation serveur
            if (etatCivil.Age < 18)
            {
                ModelState.AddModelError("age", "Age doit être plus grand que 18");
            }
            if (string.IsNullOrWhiteSpace( etatCivil.Nom))
            {
                ModelState.AddModelError("nom", "Nom est obligatoire");
            }
            if (string.IsNullOrWhiteSpace(etatCivil.Prenom))
            {
                ModelState.AddModelError("prenom", "Prénom est obligatoire");
            }
            if (etatCivil.Civilite == 0)
            {
                ModelState.AddModelError("civilite", "Civilité est obligatoire");
            }

            if (!ModelState.IsValid)
            {
                // la validation a échouée
                etatCivil.ErrorMessages = GetModelStateErrors(ModelState);
                etatCivil.Success = false;

                return etatCivil;
            }

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
    }
}
