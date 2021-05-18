namespace Calculadora
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label fc_idLabel;
            System.Windows.Forms.Label fc_usuarioLabel;
            System.Windows.Forms.Label fc_nomeLabel;
            System.Windows.Forms.Label fc_sexoLabel;
            System.Windows.Forms.Label fc_cargoLabel;
            System.Windows.Forms.Label fc_enderecoLabel;
            System.Windows.Forms.Label fc_biLabel;
            System.Windows.Forms.Label fc_telefoneLabel;
            System.Windows.Forms.Label fc_senhaLabel;
            this.aREA_VENDASDataSet2 = new Calculadora.AREA_VENDASDataSet2();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new Calculadora.AREA_VENDASDataSet2TableAdapters.funcionarioTableAdapter();
            this.tableAdapterManager = new Calculadora.AREA_VENDASDataSet2TableAdapters.TableAdapterManager();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fc_idTextBox = new System.Windows.Forms.TextBox();
            this.fc_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.fc_nomeTextBox = new System.Windows.Forms.TextBox();
            this.fc_sexoTextBox = new System.Windows.Forms.TextBox();
            this.fc_cargoTextBox = new System.Windows.Forms.TextBox();
            this.fc_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.fc_biTextBox = new System.Windows.Forms.TextBox();
            this.fc_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.fc_senhaTextBox = new System.Windows.Forms.TextBox();
            fc_idLabel = new System.Windows.Forms.Label();
            fc_usuarioLabel = new System.Windows.Forms.Label();
            fc_nomeLabel = new System.Windows.Forms.Label();
            fc_sexoLabel = new System.Windows.Forms.Label();
            fc_cargoLabel = new System.Windows.Forms.Label();
            fc_enderecoLabel = new System.Windows.Forms.Label();
            fc_biLabel = new System.Windows.Forms.Label();
            fc_telefoneLabel = new System.Windows.Forms.Label();
            fc_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aREA_VENDASDataSet2
            // 
            this.aREA_VENDASDataSet2.DataSetName = "AREA_VENDASDataSet2";
            this.aREA_VENDASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.aREA_VENDASDataSet2;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.administradorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Calculadora.AREA_VENDASDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionarioBindingNavigatorSaveItem});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(1047, 25);
            this.funcionarioBindingNavigator.TabIndex = 0;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorSaveItem.Image")));
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionarioBindingNavigatorSaveItem.Text = "Save Data";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click_3);
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.funcionarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.funcionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            this.funcionarioDataGridView.DataSource = this.funcionarioBindingSource;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(12, 290);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.funcionarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.funcionarioDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.funcionarioDataGridView.Size = new System.Drawing.Size(814, 220);
            this.funcionarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fc_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fc_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fc_nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fc_sexo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fc_cargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fc_endereco";
            this.dataGridViewTextBoxColumn6.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fc_bi";
            this.dataGridViewTextBoxColumn7.HeaderText = "BI";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fc_senha";
            this.dataGridViewTextBoxColumn9.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fc_telefone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // fc_idLabel
            // 
            fc_idLabel.AutoSize = true;
            fc_idLabel.Location = new System.Drawing.Point(16, 53);
            fc_idLabel.Name = "fc_idLabel";
            fc_idLabel.Size = new System.Drawing.Size(24, 13);
            fc_idLabel.TabIndex = 2;
            fc_idLabel.Text = "ID :";
            // 
            // fc_idTextBox
            // 
            this.fc_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_id", true));
            this.fc_idTextBox.Location = new System.Drawing.Point(67, 46);
            this.fc_idTextBox.Name = "fc_idTextBox";
            this.fc_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_idTextBox.TabIndex = 3;
            // 
            // fc_usuarioLabel
            // 
            fc_usuarioLabel.AutoSize = true;
            fc_usuarioLabel.Location = new System.Drawing.Point(186, 56);
            fc_usuarioLabel.Name = "fc_usuarioLabel";
            fc_usuarioLabel.Size = new System.Drawing.Size(46, 13);
            fc_usuarioLabel.TabIndex = 4;
            fc_usuarioLabel.Text = "Usuário:";
            // 
            // fc_usuarioTextBox
            // 
            this.fc_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_usuario", true));
            this.fc_usuarioTextBox.Location = new System.Drawing.Point(248, 53);
            this.fc_usuarioTextBox.Name = "fc_usuarioTextBox";
            this.fc_usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_usuarioTextBox.TabIndex = 5;
            // 
            // fc_nomeLabel
            // 
            fc_nomeLabel.AutoSize = true;
            fc_nomeLabel.Location = new System.Drawing.Point(405, 59);
            fc_nomeLabel.Name = "fc_nomeLabel";
            fc_nomeLabel.Size = new System.Drawing.Size(35, 13);
            fc_nomeLabel.TabIndex = 6;
            fc_nomeLabel.Text = "Nome";
            // 
            // fc_nomeTextBox
            // 
            this.fc_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_nome", true));
            this.fc_nomeTextBox.Location = new System.Drawing.Point(459, 56);
            this.fc_nomeTextBox.Name = "fc_nomeTextBox";
            this.fc_nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_nomeTextBox.TabIndex = 7;
            // 
            // fc_sexoLabel
            // 
            fc_sexoLabel.AutoSize = true;
            fc_sexoLabel.Location = new System.Drawing.Point(646, 62);
            fc_sexoLabel.Name = "fc_sexoLabel";
            fc_sexoLabel.Size = new System.Drawing.Size(32, 13);
            fc_sexoLabel.TabIndex = 8;
            fc_sexoLabel.Text = "sexo:";
            // 
            // fc_sexoTextBox
            // 
            this.fc_sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_sexo", true));
            this.fc_sexoTextBox.Location = new System.Drawing.Point(696, 59);
            this.fc_sexoTextBox.Name = "fc_sexoTextBox";
            this.fc_sexoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_sexoTextBox.TabIndex = 9;
            // 
            // fc_cargoLabel
            // 
            fc_cargoLabel.AutoSize = true;
            fc_cargoLabel.Location = new System.Drawing.Point(641, 114);
            fc_cargoLabel.Name = "fc_cargoLabel";
            fc_cargoLabel.Size = new System.Drawing.Size(35, 13);
            fc_cargoLabel.TabIndex = 10;
            fc_cargoLabel.Text = "Cargo";
            // 
            // fc_cargoTextBox
            // 
            this.fc_cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_cargo", true));
            this.fc_cargoTextBox.Location = new System.Drawing.Point(696, 111);
            this.fc_cargoTextBox.Name = "fc_cargoTextBox";
            this.fc_cargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_cargoTextBox.TabIndex = 11;
            // 
            // fc_enderecoLabel
            // 
            fc_enderecoLabel.AutoSize = true;
            fc_enderecoLabel.Location = new System.Drawing.Point(386, 117);
            fc_enderecoLabel.Name = "fc_enderecoLabel";
            fc_enderecoLabel.Size = new System.Drawing.Size(53, 13);
            fc_enderecoLabel.TabIndex = 12;
            fc_enderecoLabel.Text = "Endereço";
            // 
            // fc_enderecoTextBox
            // 
            this.fc_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_endereco", true));
            this.fc_enderecoTextBox.Location = new System.Drawing.Point(459, 114);
            this.fc_enderecoTextBox.Name = "fc_enderecoTextBox";
            this.fc_enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_enderecoTextBox.TabIndex = 13;
            // 
            // fc_biLabel
            // 
            fc_biLabel.AutoSize = true;
            fc_biLabel.Location = new System.Drawing.Point(212, 117);
            fc_biLabel.Name = "fc_biLabel";
            fc_biLabel.Size = new System.Drawing.Size(17, 13);
            fc_biLabel.TabIndex = 14;
            fc_biLabel.Text = "BI";
            // 
            // fc_biTextBox
            // 
            this.fc_biTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_bi", true));
            this.fc_biTextBox.Location = new System.Drawing.Point(248, 110);
            this.fc_biTextBox.Name = "fc_biTextBox";
            this.fc_biTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_biTextBox.TabIndex = 15;
            // 
            // fc_telefoneLabel
            // 
            fc_telefoneLabel.AutoSize = true;
            fc_telefoneLabel.Location = new System.Drawing.Point(1, 106);
            fc_telefoneLabel.Name = "fc_telefoneLabel";
            fc_telefoneLabel.Size = new System.Drawing.Size(49, 13);
            fc_telefoneLabel.TabIndex = 16;
            fc_telefoneLabel.Text = "Telefone";
            // 
            // fc_telefoneTextBox
            // 
            this.fc_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_telefone", true));
            this.fc_telefoneTextBox.Location = new System.Drawing.Point(67, 103);
            this.fc_telefoneTextBox.Name = "fc_telefoneTextBox";
            this.fc_telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_telefoneTextBox.TabIndex = 17;
            // 
            // fc_senhaLabel
            // 
            fc_senhaLabel.AutoSize = true;
            fc_senhaLabel.Location = new System.Drawing.Point(10, 165);
            fc_senhaLabel.Name = "fc_senhaLabel";
            fc_senhaLabel.Size = new System.Drawing.Size(38, 13);
            fc_senhaLabel.TabIndex = 18;
            fc_senhaLabel.Text = "Senha";
            // 
            // fc_senhaTextBox
            // 
            this.fc_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fc_senha", true));
            this.fc_senhaTextBox.Location = new System.Drawing.Point(67, 162);
            this.fc_senhaTextBox.Name = "fc_senhaTextBox";
            this.fc_senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fc_senhaTextBox.TabIndex = 19;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1047, 534);
            this.Controls.Add(fc_senhaLabel);
            this.Controls.Add(this.fc_senhaTextBox);
            this.Controls.Add(fc_telefoneLabel);
            this.Controls.Add(this.fc_telefoneTextBox);
            this.Controls.Add(fc_biLabel);
            this.Controls.Add(this.fc_biTextBox);
            this.Controls.Add(fc_enderecoLabel);
            this.Controls.Add(this.fc_enderecoTextBox);
            this.Controls.Add(fc_cargoLabel);
            this.Controls.Add(this.fc_cargoTextBox);
            this.Controls.Add(fc_sexoLabel);
            this.Controls.Add(this.fc_sexoTextBox);
            this.Controls.Add(fc_nomeLabel);
            this.Controls.Add(this.fc_nomeTextBox);
            this.Controls.Add(fc_usuarioLabel);
            this.Controls.Add(this.fc_usuarioTextBox);
            this.Controls.Add(fc_idLabel);
            this.Controls.Add(this.fc_idTextBox);
            this.Controls.Add(this.funcionarioDataGridView);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AREA_VENDASDataSet2 aREA_VENDASDataSet2;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private AREA_VENDASDataSet2TableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private AREA_VENDASDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox fc_idTextBox;
        private System.Windows.Forms.TextBox fc_usuarioTextBox;
        private System.Windows.Forms.TextBox fc_nomeTextBox;
        private System.Windows.Forms.TextBox fc_sexoTextBox;
        private System.Windows.Forms.TextBox fc_cargoTextBox;
        private System.Windows.Forms.TextBox fc_enderecoTextBox;
        private System.Windows.Forms.TextBox fc_biTextBox;
        private System.Windows.Forms.TextBox fc_telefoneTextBox;
        private System.Windows.Forms.TextBox fc_senhaTextBox;





    }
}