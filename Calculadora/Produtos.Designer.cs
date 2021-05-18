namespace Calculadora
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            System.Windows.Forms.Label pr_idLabel;
            System.Windows.Forms.Label pr_nomeLabel;
            System.Windows.Forms.Label pr_descricaoLabel;
            System.Windows.Forms.Label pr_quantidadeLabel;
            System.Windows.Forms.Label pr_datavalidadeLabel;
            System.Windows.Forms.Label pr_precovendaLabel;
            this.aREA_VENDASDataSet3 = new Calculadora.AREA_VENDASDataSet3();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Calculadora.AREA_VENDASDataSet3TableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new Calculadora.AREA_VENDASDataSet3TableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pr_idTextBox = new System.Windows.Forms.TextBox();
            this.pr_nomeTextBox = new System.Windows.Forms.TextBox();
            this.pr_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.pr_quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.pr_datavalidadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pr_precovendaTextBox = new System.Windows.Forms.TextBox();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pr_idLabel = new System.Windows.Forms.Label();
            pr_nomeLabel = new System.Windows.Forms.Label();
            pr_descricaoLabel = new System.Windows.Forms.Label();
            pr_quantidadeLabel = new System.Windows.Forms.Label();
            pr_datavalidadeLabel = new System.Windows.Forms.Label();
            pr_precovendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aREA_VENDASDataSet3
            // 
            this.aREA_VENDASDataSet3.DataSetName = "AREA_VENDASDataSet3";
            this.aREA_VENDASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.aREA_VENDASDataSet3;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Calculadora.AREA_VENDASDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(1544, 25);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.produtoBindingNavigatorSaveItem.Text = "Save Data";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click_2);
            // 
            // pr_idLabel
            // 
            pr_idLabel.AutoSize = true;
            pr_idLabel.Location = new System.Drawing.Point(30, 74);
            pr_idLabel.Name = "pr_idLabel";
            pr_idLabel.Size = new System.Drawing.Size(62, 17);
            pr_idLabel.TabIndex = 1;
            pr_idLabel.Text = "pr id:";
            // 
            // pr_idTextBox
            // 
            this.pr_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "pr_id", true));
            this.pr_idTextBox.Location = new System.Drawing.Point(98, 71);
            this.pr_idTextBox.Name = "pr_idTextBox";
            this.pr_idTextBox.Size = new System.Drawing.Size(100, 24);
            this.pr_idTextBox.TabIndex = 2;
            // 
            // pr_nomeLabel
            // 
            pr_nomeLabel.AutoSize = true;
            pr_nomeLabel.Location = new System.Drawing.Point(271, 74);
            pr_nomeLabel.Name = "pr_nomeLabel";
            pr_nomeLabel.Size = new System.Drawing.Size(80, 17);
            pr_nomeLabel.TabIndex = 3;
            pr_nomeLabel.Text = "pr nome:";
            // 
            // pr_nomeTextBox
            // 
            this.pr_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "pr_nome", true));
            this.pr_nomeTextBox.Location = new System.Drawing.Point(357, 70);
            this.pr_nomeTextBox.Name = "pr_nomeTextBox";
            this.pr_nomeTextBox.Size = new System.Drawing.Size(100, 24);
            this.pr_nomeTextBox.TabIndex = 4;
            // 
            // pr_descricaoLabel
            // 
            pr_descricaoLabel.AutoSize = true;
            pr_descricaoLabel.Location = new System.Drawing.Point(584, 77);
            pr_descricaoLabel.Name = "pr_descricaoLabel";
            pr_descricaoLabel.Size = new System.Drawing.Size(125, 17);
            pr_descricaoLabel.TabIndex = 5;
            pr_descricaoLabel.Text = "pr descricao:";
            // 
            // pr_descricaoTextBox
            // 
            this.pr_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "pr_descricao", true));
            this.pr_descricaoTextBox.Location = new System.Drawing.Point(715, 74);
            this.pr_descricaoTextBox.Name = "pr_descricaoTextBox";
            this.pr_descricaoTextBox.Size = new System.Drawing.Size(100, 24);
            this.pr_descricaoTextBox.TabIndex = 6;
            // 
            // pr_quantidadeLabel
            // 
            pr_quantidadeLabel.AutoSize = true;
            pr_quantidadeLabel.Location = new System.Drawing.Point(18, 140);
            pr_quantidadeLabel.Name = "pr_quantidadeLabel";
            pr_quantidadeLabel.Size = new System.Drawing.Size(134, 17);
            pr_quantidadeLabel.TabIndex = 7;
            pr_quantidadeLabel.Text = "pr quantidade:";
            // 
            // pr_quantidadeTextBox
            // 
            this.pr_quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "pr_quantidade", true));
            this.pr_quantidadeTextBox.Location = new System.Drawing.Point(158, 137);
            this.pr_quantidadeTextBox.Name = "pr_quantidadeTextBox";
            this.pr_quantidadeTextBox.Size = new System.Drawing.Size(100, 24);
            this.pr_quantidadeTextBox.TabIndex = 8;
            // 
            // pr_datavalidadeLabel
            // 
            pr_datavalidadeLabel.AutoSize = true;
            pr_datavalidadeLabel.Location = new System.Drawing.Point(290, 141);
            pr_datavalidadeLabel.Name = "pr_datavalidadeLabel";
            pr_datavalidadeLabel.Size = new System.Drawing.Size(152, 17);
            pr_datavalidadeLabel.TabIndex = 9;
            pr_datavalidadeLabel.Text = "pr datavalidade:";
            // 
            // pr_datavalidadeDateTimePicker
            // 
            this.pr_datavalidadeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "pr_datavalidade", true));
            this.pr_datavalidadeDateTimePicker.Location = new System.Drawing.Point(448, 137);
            this.pr_datavalidadeDateTimePicker.Name = "pr_datavalidadeDateTimePicker";
            this.pr_datavalidadeDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.pr_datavalidadeDateTimePicker.TabIndex = 10;
            // 
            // pr_precovendaLabel
            // 
            pr_precovendaLabel.AutoSize = true;
            pr_precovendaLabel.Location = new System.Drawing.Point(18, 206);
            pr_precovendaLabel.Name = "pr_precovendaLabel";
            pr_precovendaLabel.Size = new System.Drawing.Size(134, 17);
            pr_precovendaLabel.TabIndex = 11;
            pr_precovendaLabel.Text = "pr precovenda:";
            // 
            // pr_precovendaTextBox
            // 
            this.pr_precovendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "pr_precovenda", true));
            this.pr_precovendaTextBox.Location = new System.Drawing.Point(158, 203);
            this.pr_precovendaTextBox.Name = "pr_precovendaTextBox";
            this.pr_precovendaTextBox.Size = new System.Drawing.Size(100, 24);
            this.pr_precovendaTextBox.TabIndex = 12;
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(66, 305);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.Size = new System.Drawing.Size(643, 220);
            this.produtoDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pr_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "pr_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "pr_nome";
            this.dataGridViewTextBoxColumn9.HeaderText = "pr_nome";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "pr_descricao";
            this.dataGridViewTextBoxColumn10.HeaderText = "pr_descricao";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "pr_quantidade";
            this.dataGridViewTextBoxColumn11.HeaderText = "pr_quantidade";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "pr_datavalidade";
            this.dataGridViewTextBoxColumn12.HeaderText = "pr_datavalidade";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "pr_precovenda";
            this.dataGridViewTextBoxColumn13.HeaderText = "pr_precovenda";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1544, 635);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(pr_precovendaLabel);
            this.Controls.Add(this.pr_precovendaTextBox);
            this.Controls.Add(pr_datavalidadeLabel);
            this.Controls.Add(this.pr_datavalidadeDateTimePicker);
            this.Controls.Add(pr_quantidadeLabel);
            this.Controls.Add(this.pr_quantidadeTextBox);
            this.Controls.Add(pr_descricaoLabel);
            this.Controls.Add(this.pr_descricaoTextBox);
            this.Controls.Add(pr_nomeLabel);
            this.Controls.Add(this.pr_nomeTextBox);
            this.Controls.Add(pr_idLabel);
            this.Controls.Add(this.pr_idTextBox);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private AREA_VENDASDataSet3 aREA_VENDASDataSet3;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private AREA_VENDASDataSet3TableAdapters.produtoTableAdapter produtoTableAdapter;
        private AREA_VENDASDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pr_idTextBox;
        private System.Windows.Forms.TextBox pr_nomeTextBox;
        private System.Windows.Forms.TextBox pr_descricaoTextBox;
        private System.Windows.Forms.TextBox pr_quantidadeTextBox;
        private System.Windows.Forms.DateTimePicker pr_datavalidadeDateTimePicker;
        private System.Windows.Forms.TextBox pr_precovendaTextBox;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}