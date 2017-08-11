using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoAjax.Model
{
    public class EtatCivil
    {
        public int Civilite { get; set; }

        [StringLength(80)]
        [Required(AllowEmptyStrings=false,ErrorMessage ="Nom est obligatoire")]
        public string Nom { get; set; }

        [StringLength(80)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Prénom est obligatoire")]
        public string Prenom { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Age est obligatoire")]
        public int Age { get; set; }

        public bool Success { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}