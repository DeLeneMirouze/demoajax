using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAjax.Model;

namespace DemoAjax.Controllers.Api
{
    [RoutePrefix("api/continents")]
    public class ContinentsController : ApiController
    {
        #region Constructor
        ContinentBuilder _builder;
        public ContinentsController()
        {
            _builder = new ContinentBuilder();
        }
        #endregion

        [HttpGet]
        [Route("{id:int}/countries")]
        public List<Country> Countries(int id)
        {
            List<Country> countries = _builder.Countries(id);

            return countries;
        }

        [HttpGet]
        [Route("{idContinent:int}/countries/{id}")]
        public List<Country> Towns(int idContinent, int id)
        {
            List<Country> countries = _builder.Countries(id);

            return countries;
        }
    }
}
