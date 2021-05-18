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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

          

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aREA_VENDASDataSet3.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.aREA_VENDASDataSet3.produto);

        }

        private void produtoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void produtoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aREA_VENDASDataSet3);

        }
    }
}
