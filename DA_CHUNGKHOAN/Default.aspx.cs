using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DA_CHUNGKHOAN
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            try
            {
                string loaiGD = (DrDMuaBan.SelectedIndex==0) ? "Mua" : "Ban";
                string strLenh = "exec SP_KHOPLENH_LO '" + txtMaCK.Text.ToUpper() + "','" + string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now) 
                    + "','"+ loaiGD + "','" + txtKhoiLuong.Text + "','" + txtGia.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(strLenh, Startup.conn);
                Startup.conn.Open();
                sqlcmd.ExecuteNonQuery();
                Response.Write("Đặt lệnh thành công!");
                Startup.conn.Close();
            }
            catch (SqlException ex)
            {
                Startup.conn.Close();
            }
        }

        protected void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaCK.Text = "";
            txtGia.Text = "";
            txtKhoiLuong.Text = "";
            DrDMuaBan.SelectedIndex = 0;
        }
    }
}