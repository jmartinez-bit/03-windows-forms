using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            String str = @"Server=LAPTOP-OM5KP6QJ\SQLEXPRESS;Database=db_lab03;Integrated Security=true";
            conn = new SqlConnection(str);
            conn.Open();

            if(conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM tbl_usuario WHERE usuario_nombre = '" + 
                    txtUsername.Text.Trim() + "' and usuario_password = '" + 
                    txtPassword.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                if(dt.Rows.Count == 1)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                }                
            }

            conn.Close();
        }
    }
}
