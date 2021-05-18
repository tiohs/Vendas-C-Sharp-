using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet2);

        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet2.venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.aREA_VENDASDataSet2.venda);

        }
    }
}
