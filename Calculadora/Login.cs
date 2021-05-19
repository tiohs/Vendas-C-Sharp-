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

namespace Calculadora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string query;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO") {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
                txtErro.Visible = false;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
                txtErro.Visible = false;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PALAVRA-PASSE")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
                txtErro.Visible = false;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PALAVRA-PASSE";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
                txtErro.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean logars(string op)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            if (op == "admin")
            {
                query = "SELECT * FROM administrador WHERE adm_Login = '" + txtUser.Text + "' and adm_Senha = '" + txtPass.Text + "'";
            }
            else {
                query = "SELECT * FROM funcionario WHERE fc_usuario = '" + txtUser.Text + "' and fc_senha = '" + txtPass.Text + "'";
            }
            
            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void lOGAR_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO" && txtPass.Text != "PALAVRA-PASSE")
            {
                if (logars("admin"))
                {
                    Loading load = new Loading();
                    load.Show();
                    this.Visible = false;
                } 
                if(logars("func")) {
                    Caixa caixa = new Caixa();
                    caixa.Show();
                    this.Visible = false;

                }
          
                else {
                    txtErro.Visible = true;
                    txtErro.Text = "Usuário ou senha incorrecta ";
                }

            }
            else {
                txtErro.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
