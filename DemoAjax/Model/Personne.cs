using System.Diagnostics;

namespace DemoAjax.Model
{
    [DebuggerDisplay("{FirstName} {LastName}")]
    public class Personne
    {
        public int BusinessEntityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}