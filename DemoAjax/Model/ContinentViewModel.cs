using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAjax.Model
{
    public class ContinentViewModel
    {
        public ContinentViewModel()
        {
            Continents = new List<Continent>();
        }

        public List<Continent> Continents
        {
            get; set;
        }
    }
}