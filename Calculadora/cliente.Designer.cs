namespace Calculadora
{
    partial class cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cl_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente));
            System.Windows.Forms.Label cl_nomeLabel;
            System.Windows.Forms.Label cl_numeroLabel;
            System.Windows.Forms.Label cl_enderecoLabel;
            System.Windows.Forms.Label cl_BILabel;
            System.Windows.Forms.Label cl_nascimentoLabel;
            this.aREA_VENDASDataSet2 = new Calculadora.AREA_VENDASDataSet2();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Calculadora.AREA_VENDASDataSet2TableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new Calculadora.AREA_VENDASDataSet2TableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cl_idTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.cl_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cl_numeroTextBox = new System.Windows.Forms.TextBox();
            this.cl_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cl_BITextBox = new System.Windows.Forms.TextBox();
            this.cl_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_idLabel = new System.Windows.Forms.Label();
            cl_nomeLabel = new System.Windows.Forms.Label();
            cl_numeroLabel = new System.Windows.Forms.Label();
            cl_enderecoLabel = new System.Windows.Forms.Label();
            cl_BILabel = new System.Windows.Forms.Label();
            cl_nascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aREA_VENDASDataSet2
            // 
            this.aREA_VENDASDataSet2.DataSetName = "AREA_VENDASDataSet2";
            this.aREA_VENDASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.aREA_VENDASDataSet2;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.administradorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Calculadora.AREA_VENDASDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1460, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cl_idLabel
            // 
            cl_idLabel.AutoSize = true;
            cl_idLabel.ForeColor = System.Drawing.Color.White;
            cl_idLabel.Location = new System.Drawing.Point(86, 89);
            cl_idLabel.Name = "cl_idLabel";
            cl_idLabel.Size = new System.Drawing.Size(35, 17);
            cl_idLabel.TabIndex = 1;
            cl_idLabel.Text = "ID:";
            // 
            // cl_idTextBox
            // 
            this.cl_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cl_id", true));
            this.cl_idTextBox.Location = new System.Drawing.Point(154, 86);
            this.cl_idTextBox.Name = "cl_idTextBox";
            this.cl_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.cl_idTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Save Data";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(125, 324);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(643, 220);
            this.clienteDataGridView.TabIndex = 3;
            // 
            // cl_nomeLabel
            // 
            cl_nomeLabel.AutoSize = true;
            cl_nomeLabel.ForeColor = System.Drawing.Color.White;
            cl_nomeLabel.Location = new System.Drawing.Point(329, 92);
            cl_nomeLabel.Name = "cl_nomeLabel";
            cl_nomeLabel.Size = new System.Drawing.Size(53, 17);
            cl_nomeLabel.TabIndex = 4;
            cl_nomeLabel.Text = "Nome:";
            cl_nomeLabel.Click += new System.EventHandler(this.cl_nomeLabel_Click);
            // 
            // cl_nomeTextBox
            // 
            this.cl_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cl_nome", true));
            this.cl_nomeTextBox.Location = new System.Drawing.Point(415, 89);
            this.cl_nomeTextBox.Name = "cl_nomeTextBox";
            this.cl_nomeTextBox.Size = new System.Drawing.Size(100, 24);
            this.cl_nomeTextBox.TabIndex = 5;
            // 
            // cl_numeroLabel
            // 
            cl_numeroLabel.AutoSize = true;
            cl_numeroLabel.ForeColor = System.Drawing.Color.White;
            cl_numeroLabel.Location = new System.Drawing.Point(594, 93);
            cl_numeroLabel.Name = "cl_numeroLabel";
            cl_numeroLabel.Size = new System.Drawing.Size(71, 17);
            cl_numeroLabel.TabIndex = 6;
            cl_numeroLabel.Text = "Numero:";
            cl_numeroLabel.Click += new System.EventHandler(this.cl_numeroLabel_Click);
            // 
            // cl_numeroTextBox
            // 
            this.cl_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cl_numero", true));
            this.cl_numeroTextBox.Location = new System.Drawing.Point(698, 90);
            this.cl_numeroTextBox.Name = "cl_numeroTextBox";
            this.cl_numeroTextBox.Size = new System.Drawing.Size(100, 24);
            this.cl_numeroTextBox.TabIndex = 7;
            // 
            // cl_enderecoLabel
            // 
            cl_enderecoLabel.AutoSize = true;
            cl_enderecoLabel.ForeColor = System.Drawing.Color.White;
            cl_enderecoLabel.Location = new System.Drawing.Point(32, 144);
            cl_enderecoLabel.Name = "cl_enderecoLabel";
            cl_enderecoLabel.Size = new System.Drawing.Size(89, 17);
            cl_enderecoLabel.TabIndex = 8;
            cl_enderecoLabel.Text = "Endereco:";
            cl_enderecoLabel.Click += new System.EventHandler(this.cl_enderecoLabel_Click);
            // 
            // cl_enderecoTextBox
            // 
            this.cl_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cl_endereco", true));
            this.cl_enderecoTextBox.Location = new System.Drawing.Point(154, 141);
            this.cl_enderecoTextBox.Name = "cl_enderecoTextBox";
            this.cl_enderecoTextBox.Size = new System.Drawing.Size(100, 24);
            this.cl_enderecoTextBox.TabIndex = 9;
            // 
            // cl_BILabel
            // 
            cl_BILabel.AutoSize = true;
            cl_BILabel.ForeColor = System.Drawing.Color.White;
            cl_BILabel.Location = new System.Drawing.Point(347, 147);
            cl_BILabel.Name = "cl_BILabel";
            cl_BILabel.Size = new System.Drawing.Size(35, 17);
            cl_BILabel.TabIndex = 10;
            cl_BILabel.Text = "BI:";
            cl_BILabel.Click += new System.EventHandler(this.cl_BILabel_Click);
            // 
            // cl_BITextBox
            // 
            this.cl_BITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cl_BI", true));
            this.cl_BITextBox.Location = new System.Drawing.Point(415, 144);
            this.cl_BITextBox.Name = "cl_BITextBox";
            this.cl_BITextBox.Size = new System.Drawing.Size(100, 24);
            this.cl_BITextBox.TabIndex = 11;
            // 
            // cl_nascimentoLabel
            // 
            cl_nascimentoLabel.AutoSize = true;
            cl_nascimentoLabel.ForeColor = System.Drawing.Color.White;
            cl_nascimentoLabel.Location = new System.Drawing.Point(558, 145);
            cl_nascimentoLabel.Name = "cl_nascimentoLabel";
            cl_nascimentoLabel.Size = new System.Drawing.Size(107, 17);
            cl_nascimentoLabel.TabIndex = 12;
            cl_nascimentoLabel.Text = "Nascimento:";
            cl_nascimentoLabel.Click += new System.EventHandler(this.cl_nascimentoLabel_Click);
            // 
            // cl_nascimentoDateTimePicker
            // 
            this.cl_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "cl_nascimento", true));
            this.cl_nascimentoDateTimePicker.Location = new System.Drawing.Point(698, 141);
            this.cl_nascimentoDateTimePicker.Name = "cl_nascimentoDateTimePicker";
            this.cl_nascimentoDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.cl_nascimentoDateTimePicker.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cl_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cl_nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cl_numero";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cl_endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cl_BI";
            this.dataGridViewTextBoxColumn5.HeaderText = "BI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cl_nascimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nascimento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1460, 804);
            this.Controls.Add(cl_nascimentoLabel);
            this.Controls.Add(this.cl_nascimentoDateTimePicker);
            this.Controls.Add(cl_BILabel);
            this.Controls.Add(this.cl_BITextBox);
            this.Controls.Add(cl_enderecoLabel);
            this.Controls.Add(this.cl_enderecoTextBox);
            this.Controls.Add(cl_numeroLabel);
            this.Controls.Add(this.cl_numeroTextBox);
            this.Controls.Add(cl_nomeLabel);
            this.Controls.Add(this.cl_nomeTextBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(cl_idLabel);
            this.Controls.Add(this.cl_idTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cliente";
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AREA_VENDASDataSet2 aREA_VENDASDataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AREA_VENDASDataSet2TableAdapters.clienteTableAdapter clienteTableAdapter;
        private AREA_VENDASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cl_idTextBox;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.TextBox cl_nomeTextBox;
        private System.Windows.Forms.TextBox cl_numeroTextBox;
        private System.Windows.Forms.TextBox cl_enderecoTextBox;
        private System.Windows.Forms.TextBox cl_BITextBox;
        private System.Windows.Forms.DateTimePicker cl_nascimentoDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}