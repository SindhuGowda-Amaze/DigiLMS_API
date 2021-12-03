using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace FreshersApp.Data
{
    public class Repository
    {
        //public static MySqlConnection GetConnection()
        //{
        //    MySql.Data.MySqlClient.MySqlConnection db;
        //    string configuration = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //    db = new MySql.Data.MySqlClient.MySqlConnection();
        //    db.ConnectionString = configuration;
        //    db.Open();
        //    return db;
        //}
        public IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
}
