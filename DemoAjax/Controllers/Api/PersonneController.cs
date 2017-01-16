#region using
using DemoAjax.Model;
using System.Web.Http;
#endregion

namespace DemoAjax.Controllers.Api
{
    public class PersonneController : ApiController
    {
        #region Constructeur
        readonly Repository _repository;

        public PersonneController()
        {
            _repository = new Repository();
        }
        #endregion

        public Personne Get(int id)
        {
            Personne personne = _repository.Details(id);

            return personne;
        }
    }
}