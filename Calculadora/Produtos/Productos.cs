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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pesquisar")
            {      
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {        
            if (textBox1.Text == "")
            {   
                textBox1.Text = "Pesquisar";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void pRODUTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet);

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this.aREA_VENDASDataSet.PRODUTOS);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUTOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("update PRODUTOS set NOME_PRODUTO = @nome, PRECO = @PRECO,QUANTIDADE = @Qt Where ID_PRODUTO = @ID ", conexao);
                cmd.Parameters.AddWithValue("@ID", int.Parse(iD_PRODUTOTextBox.Text));
                cmd.Parameters.AddWithValue("@nome", nOME_PRODUTOTextBox.Text);
                cmd.Parameters.AddWithValue("@PRECO", decimal.Parse(pRECOTextBox.Text));
                cmd.Parameters.AddWithValue("@Qt", float.Parse(qUANTIDADETextBox.Text));
                cmd.ExecuteNonQuery();

                conexao.Close();
                pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetData();
            } catch(Exception erro){
                MessageBox.Show(erro.Message);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetData();
            }
            else {
                pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetDataBy(int.Parse(textBox1.Text));
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetData();
            iD_PRODUTOTextBox.Clear();
            nOME_PRODUTOTextBox.Clear();
            pRECOTextBox.Clear();
            qUANTIDADETextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("Delete produtos Where ID_PRODUTO = @ID ", conexao);
                cmd.Parameters.AddWithValue("@ID", int.Parse(iD_PRODUTOTextBox.Text));
                
                cmd.ExecuteNonQuery();

                conexao.Close();
                pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetData();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        } 
    }
}
