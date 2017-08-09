using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAjax.Model
{
    public class FormViewModel
    {
        public FormViewModel()
        {
            Civilites = new List<Civilite>();
        }

        public EtatCivil EtatCivil { get; set; }

        public List<Civilite> Civilites { get; set; }
    }
}