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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet2);

        }

        private void cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet2.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.aREA_VENDASDataSet2.cliente);

        }

        private void cl_numeroLabel_Click(object sender, EventArgs e)
        {

        }

        private void cl_nascimentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cl_nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cl_BILabel_Click(object sender, EventArgs e)
        {

        }

        private void cl_enderecoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
