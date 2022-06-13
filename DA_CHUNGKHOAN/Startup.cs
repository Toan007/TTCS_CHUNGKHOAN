using Microsoft.Owin;
using Owin;
using System.Configuration;
using System.Data.SqlClient;

[assembly: OwinStartupAttribute(typeof(DA_CHUNGKHOAN.Startup))]
namespace DA_CHUNGKHOAN
{
    public partial class Startup {


        //public static string StringConnection = ConfigurationManager.ConnectionStrings["DataBaseConnectSting"].ToString();
        public static string strConn = "Data source=DESKTOP-00M9PPR; Initial Catalog=CHUNGKHOAN; uid=sa; pwd=123456";
        public static SqlConnection conn = new SqlConnection(strConn);
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
