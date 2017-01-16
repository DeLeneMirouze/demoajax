#region using
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
#endregion

namespace DemoAjax.Model
{
    public sealed class Repository
    {
        #region Constructor
        readonly string _connexionString;
        public Repository()
        {
            _connexionString = BuildConnexionString();
        } 
        #endregion

        #region Get
        public List<Personne> Get()
        {
            using (var cnx = new SqlConnection(_connexionString))
            {
                string sql = "select top 10 * from person.person";
                var retour = cnx.Query<Personne>(sql);
                return retour.ToList();
            }
        }
        #endregion

        #region Details
        public Personne Details(int id)
        {
            using (var cnx = new SqlConnection(_connexionString))
            {
                string sql = "select * from person.person where BusinessEntityID=" + id.ToString();
                var retour = cnx.Query<Personne>(sql);
                return retour.First();
            }
        }
        #endregion

        #region BuildConnexionString (private, static)
        private static string BuildConnexionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ConfigurationManager.AppSettings["data.datasource"];
            builder.InitialCatalog = ConfigurationManager.AppSettings["data.initialcatalog"];
            builder.IntegratedSecurity = true;
            return builder.ToString();
        } 
        #endregion
    }
}