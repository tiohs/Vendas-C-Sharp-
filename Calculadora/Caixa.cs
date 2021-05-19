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
                {
                    lblCod.Text = "1";
                    conexao.Close();
                }
                   
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    lblCod.Text = ra.ToString();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show("ERRO: " + ex.Message, "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GravarVenda()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            query = "INSERT INTO venda (ve_valor, ve_data) VALUES (@ValorTotal, '20-05-2021')";

            SqlCommand comando = new SqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@ValorTotal", float.Parse(txtValorCompra.Text));
            
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Inserir();
                dataGridViewProdutos.Rows.Clear();
                totalVenda = 0;
                txtValorCompra.Text = "0";
                txtCod.Focus();
            }

        }
        private void Inserir()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            query = "INSERT INTO itens_venda (ve_id, pr_id, iv_quantidade, iv_valortotalitem) VALUES (@VendaID, @ProdutoID, @Quantidade, @ValorTotal)";

            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@VendaID", lblCod.Text);
                    comando.Parameters.AddWithValue("@ProdutoID", dataGridViewProdutos.Rows[i].Cells[0].Value);
                    comando.Parameters.AddWithValue("@Quantidade", dataGridViewProdutos.Rows[i].Cells[3].Value);
                    comando.Parameters.AddWithValue("@ValorTotal", float.Parse(dataGridViewProdutos.Rows[i].Cells[4].Value.ToString()));

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro: " + ex);
            }

        }
        private void ConsultarProduto()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            query = "SELECT * FROM produto WHERE pr_id = '" + txtCod.Text + "'";
            
            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {
                    MessageBox.Show("Produto não encontrado", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCod.Clear();
                    txtCod.Focus();
                    conexao.Close();
                }
                else
                {
                    txtNome.Text = dr["pr_nome"].ToString();
                    txtValor.Text = dr["pr_precovenda"].ToString();
                    int quantidade = int.Parse(dr["pr_quantidade"].ToString());
                    lblQuantidade.Text = dr["pr_quantidade"].ToString();
                    txtQuantidade.Focus();
                    conexao.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            GerarCodigoVenda();
            NomearDataGrid();
        }

      

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCod_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtCod.Text != string.Empty)
            {
                ConsultarProduto();
            }

            else
                txtCod.Focus();
        }
        void Limpar()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtTotal.Clear();
            txtValor.Clear();
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantidade.Text != string.Empty)
                txtTotal.Text = (float.Parse(txtValor.Text) * float.Parse(txtQuantidade.Text)).ToString();
            else
            {
                MessageBox.Show("Digite a quantidade", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }
        }
        private void BaixaEstoque(string txtCod, string txtQuantidade)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            query = "UPDATE produto SET pr_quantidade = @Quantidade WHERE pr_codigobarras = @CodBarras;";

            SqlCommand comando = new SqlCommand(query, conexao);

            try
            {
                int quantidadeProduto = int.Parse(txtQuantidade);
                int quantidadeTotal = int.Parse(lblQuantidade.Text);

                int quantidade = quantidadeTotal - quantidadeProduto;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Quantidade", quantidade);
                comando.Parameters.AddWithValue("@CodBarras", txtCod);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao dar baixa no estoque: " + ex);
            }

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            int quantidadeCompra = int.Parse(txtQuantidade.Text);
            int quantidadeProduto = int.Parse(lblQuantidade.Text);

            if (quantidadeProduto > quantidadeCompra)
            {
                dataGridViewProdutos.Rows.Add(txtCod.Text, txtNome.Text, txtValor.Text, txtQuantidade.Text, txtTotal.Text);
                totalVenda += float.Parse(txtTotal.Text);
                txtValorCompra.Text = totalVenda.ToString();

                BaixaEstoque(txtCod.Text, txtQuantidade.Text);
                Limpar();
                txtCod.Focus();
            }
            else
                MessageBox.Show("Estoque insuficiente", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            GravarVenda();
            GerarCodigoVenda();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidadeCompra = int.Parse(txtQuantidade.Text);
            int quantidadeProduto = int.Parse(lblQuantidade.Text);

            if (quantidadeProduto > quantidadeCompra)
            {
                dataGridViewProdutos.Rows.Add(txtCod.Text, txtNome.Text, txtValor.Text, txtQuantidade.Text, txtTotal.Text);
                totalVenda += float.Parse(txtTotal.Text);
                txtValorCompra.Text = totalVenda.ToString();

                BaixaEstoque(txtCod.Text, txtQuantidade.Text);
                Limpar();
                txtCod.Focus();
            }
            else
                MessageBox.Show("Estoque insuficiente", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantidadeCompra = int.Parse(txtQuantidade.Text);
            int quantidadeProduto = int.Parse(lblQuantidade.Text);

            if (quantidadeProduto > quantidadeCompra)
            {
                dataGridViewProdutos.Rows.Add(txtCod.Text, txtNome.Text, txtValor.Text, txtQuantidade.Text, txtTotal.Text);
                totalVenda += float.Parse(txtTotal.Text);
                txtValorCompra.Text = totalVenda.ToString();

                BaixaEstoque(txtCod.Text, txtQuantidade.Text);
                Limpar();
                txtCod.Focus();
            }
            else
                MessageBox.Show("Estoque insuficiente", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            GravarVenda();
            GerarCodigoVenda();
        }
    }
}
