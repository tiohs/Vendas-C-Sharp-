namespace Calculadora
{
    partial class Cadastrar
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
            System.Windows.Forms.Label nOME_PRODUTOLabel;
            System.Windows.Forms.Label pRECOLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.aREA_VENDASDataSet = new Calculadora.AREA_VENDASDataSet();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new Calculadora.AREA_VENDASDataSetTableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new Calculadora.AREA_VENDASDataSetTableAdapters.TableAdapterManager();
            this.nOME_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.pRECOTextBox = new System.Windows.Forms.TextBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.iD_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUTOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUTOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            nOME_PRODUTOLabel = new System.Windows.Forms.Label();
            pRECOLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingNavigator)).BeginInit();
            this.pRODUTOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOME_PRODUTOLabel
            // 
            nOME_PRODUTOLabel.AutoSize = true;
            nOME_PRODUTOLabel.Location = new System.Drawing.Point(46, 98);
            nOME_PRODUTOLabel.Name = "nOME_PRODUTOLabel";
            nOME_PRODUTOLabel.Size = new System.Drawing.Size(99, 13);
            nOME_PRODUTOLabel.TabIndex = 3;
            nOME_PRODUTOLabel.Text = "NOME PRODUTO:";
            // 
            // pRECOLabel
            // 
            pRECOLabel.AutoSize = true;
            pRECOLabel.Location = new System.Drawing.Point(46, 144);
            pRECOLabel.Name = "pRECOLabel";
            pRECOLabel.Size = new System.Drawing.Size(47, 13);
            pRECOLabel.TabIndex = 5;
            pRECOLabel.Text = "PRECO:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(46, 189);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(81, 13);
            qUANTIDADELabel.TabIndex = 7;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // aREA_VENDASDataSet
            // 
            this.aREA_VENDASDataSet.DataSetName = "AREA_VENDASDataSet";
            this.aREA_VENDASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.aREA_VENDASDataSet;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRODUTOSTableAdapter = this.pRODUTOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Calculadora.AREA_VENDASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nOME_PRODUTOTextBox
            // 
            this.nOME_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "NOME_PRODUTO", true));
            this.nOME_PRODUTOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_PRODUTOTextBox.Location = new System.Drawing.Point(161, 91);
            this.nOME_PRODUTOTextBox.Name = "nOME_PRODUTOTextBox";
            this.nOME_PRODUTOTextBox.Size = new System.Drawing.Size(325, 24);
            this.nOME_PRODUTOTextBox.TabIndex = 4;
            // 
            // pRECOTextBox
            // 
            this.pRECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "PRECO", true));
            this.pRECOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRECOTextBox.Location = new System.Drawing.Point(161, 133);
            this.pRECOTextBox.Name = "pRECOTextBox";
            this.pRECOTextBox.Size = new System.Drawing.Size(325, 24);
            this.pRECOTextBox.TabIndex = 6;
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(161, 178);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(325, 24);
            this.qUANTIDADETextBox.TabIndex = 8;
            // 
            // iD_PRODUTOTextBox
            // 
            this.iD_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "ID_PRODUTO", true));
            this.iD_PRODUTOTextBox.Location = new System.Drawing.Point(343, 300);
            this.iD_PRODUTOTextBox.Name = "iD_PRODUTOTextBox";
            this.iD_PRODUTOTextBox.Size = new System.Drawing.Size(325, 20);
            this.iD_PRODUTOTextBox.TabIndex = 2;
            this.iD_PRODUTOTextBox.TextChanged += new System.EventHandler(this.iD_PRODUTOTextBox_TextChanged);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // pRODUTOSBindingNavigatorSaveItem
            // 
            this.pRODUTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUTOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUTOSBindingNavigatorSaveItem.Image")));
            this.pRODUTOSBindingNavigatorSaveItem.Name = "pRODUTOSBindingNavigatorSaveItem";
            this.pRODUTOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pRODUTOSBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUTOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUTOSBindingNavigatorSaveItem_Click);
            // 
            // pRODUTOSBindingNavigator
            // 
            this.pRODUTOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUTOSBindingNavigator.BindingSource = this.pRODUTOSBindingSource;
            this.pRODUTOSBindingNavigator.CountItem = null;
            this.pRODUTOSBindingNavigator.DeleteItem = null;
            this.pRODUTOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.pRODUTOSBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.pRODUTOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUTOSBindingNavigator.MoveFirstItem = null;
            this.pRODUTOSBindingNavigator.MoveLastItem = null;
            this.pRODUTOSBindingNavigator.MoveNextItem = null;
            this.pRODUTOSBindingNavigator.MovePreviousItem = null;
            this.pRODUTOSBindingNavigator.Name = "pRODUTOSBindingNavigator";
            this.pRODUTOSBindingNavigator.PositionItem = null;
            this.pRODUTOSBindingNavigator.Size = new System.Drawing.Size(703, 25);
            this.pRODUTOSBindingNavigator.TabIndex = 0;
            this.pRODUTOSBindingNavigator.Text = "bindingNavigator1";
            this.pRODUTOSBindingNavigator.RefreshItems += new System.EventHandler(this.pRODUTOSBindingNavigator_RefreshItems);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 383);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(pRECOLabel);
            this.Controls.Add(this.pRECOTextBox);
            this.Controls.Add(nOME_PRODUTOLabel);
            this.Controls.Add(this.nOME_PRODUTOTextBox);
            this.Controls.Add(this.iD_PRODUTOTextBox);
            this.Controls.Add(this.pRODUTOSBindingNavigator);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingNavigator)).EndInit();
            this.pRODUTOSBindingNavigator.ResumeLayout(false);
            this.pRODUTOSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AREA_VENDASDataSet aREA_VENDASDataSet;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private AREA_VENDASDataSetTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private AREA_VENDASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton pRODUTOSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator pRODUTOSBindingNavigator;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        public System.Windows.Forms.TextBox nOME_PRODUTOTextBox;
        public System.Windows.Forms.TextBox pRECOTextBox;
        public System.Windows.Forms.TextBox qUANTIDADETextBox;
        public System.Windows.Forms.TextBox iD_PRODUTOTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}