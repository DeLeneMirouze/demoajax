using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoAjax.Model
{
    public class EtatCivil
    {
        public int Civilite { get; set; }

        [Required,StringLength(80)]
        public string Nom { get; set; }

        [Required, StringLength(80)]
        public string Prenom { get; set; }

        public int Age { get; set; }

        public bool Success { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}