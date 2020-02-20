using CSARMetaPlan.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSARMetaPlanDBCap
{
    class Program
    {
        public static string APPSETTINGS_CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["CONNECTIONPARAMETER"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(APPSETTINGS_CONNECTIONSTRING);

        public static void Main(string[] args)
        {
            try
            {
                ARMetaPlanDBCapMethods aRMetaPlanDBCapMethods = new ARMetaPlanDBCapMethods(connection);
                /*
                aRMetaPlanDBCapMethods.SaveAdatElem(new AdatElem()
                {
                    Adattipus = "Teszt adattipus"
                    , BelsoNev = "teszt belsonev"
                    , HumanNev = "teszt humannev"
                    , Irany = "teszt irany"
                    , Opcionalis = true
                });*/

                Muvelet muvelet = aRMetaPlanDBCapMethods.GetByGUIDMuvelet("guid");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
