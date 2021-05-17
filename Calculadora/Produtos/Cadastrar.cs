﻿using System;
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
    public partial class Cadastrar : Form
    {
        
        public Cadastrar()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO PRODUTOS(NOME_PRODUTO,PRECO,QUANTIDADE) VALUES(@nome,@produto, @Quantidade)", conexao);
         //   cmd.Parameters.AddWithValue("@nome", nOME_PRODUTOTextBox.Text);
           // cmd.Parameters.AddWithValue("@produto", decimal.Parse(pRECOTextBox.Text));
           // cmd.Parameters.AddWithValue("@Quantidade", float.Parse(qUANTIDADETextBox.Text));
           // cmd.ExecuteNonQuery();

            conexao.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=HS-PC\SQLEXPRESS;Initial Catalog=AREA_VENDAS;Integrated Security=True");
            conexao.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO PRODUTOS(NOME_PRODUTO,PRECO,QUANTIDADE) VALUES(@nome,@produto, @Quantidade)", conexao);
             cmd.Parameters.AddWithValue("@nome", name.Text);
             cmd.Parameters.AddWithValue("@produto", decimal.Parse(preco.Text));
             cmd.Parameters.AddWithValue("@Quantidade", float.Parse(qt.Text));
             cmd.ExecuteNonQuery();
             
            conexao.Close();
            Productos produto = new Productos();
            produto.pRODUTOSDataGridView.DataSource = pRODUTOSTableAdapter.GetData();
            this.Close();

            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pRODUTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet);

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this.aREA_VENDASDataSet.PRODUTOS);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}