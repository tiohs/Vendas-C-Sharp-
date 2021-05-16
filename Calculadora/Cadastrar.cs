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
    public partial class Cadastrar : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSql;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void pRODUTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet);
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.Visible = false;
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this.aREA_VENDASDataSet.PRODUTOS);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pRODUTOSBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {

        }

        private void iD_PRODUTOTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "";
        }
    }
}
