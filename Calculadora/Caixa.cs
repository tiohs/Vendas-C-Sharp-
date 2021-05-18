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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        string query;
        float totalVenda;

        private void GerarCodigoVenda()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            string StrSql = "SELECT MAX(ve_id) FROM venda";

            try
            {
                SqlCommand comando = new SqlCommand(StrSql, conexao);

                if (comando.ExecuteScalar() == DBNull.Value)
                    lblCod.Text = "1";
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    lblCod.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
        private void NomearDataGrid()
        {
            dataGridViewProdutos.ColumnCount = 5;
            dataGridViewProdutos.Columns[0].Name = "Código";
            dataGridViewProdutos.Columns[1].Name = "Produto";
            dataGridViewProdutos.Columns[1].Width = 250;
            dataGridViewProdutos.Columns[2].Name = "Valor Unitário";
            dataGridViewProdutos.Columns[3].Name = "Quantidade";
            dataGridViewProdutos.Columns[4].Name = "Total";

        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            NomearDataGrid();
        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {
            if(txtCod.Text != string.Empty)
                txtQuantidade.Text = "Passei";
                
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
