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
            System.Windows.Forms.Label iD_PRODUTOLabel;
            System.Windows.Forms.Label nOME_PRODUTOLabel;
            System.Windows.Forms.Label pRECOLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.aREA_VENDASDataSet = new Calculadora.AREA_VENDASDataSet();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new Calculadora.AREA_VENDASDataSetTableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new Calculadora.AREA_VENDASDataSetTableAdapters.TableAdapterManager();
            this.pRODUTOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.iD_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOME_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.pRECOTextBox = new System.Windows.Forms.TextBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            iD_PRODUTOLabel = new System.Windows.Forms.Label();
            nOME_PRODUTOLabel = new System.Windows.Forms.Label();
            pRECOLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aREA_VENDASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingNavigator)).BeginInit();
            this.pRODUTOSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // pRODUTOSBindingNavigator
            // 
            this.pRODUTOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUTOSBindingNavigator.BindingSource = this.pRODUTOSBindingSource;
            this.pRODUTOSBindingNavigator.CountItem = null;
            this.pRODUTOSBindingNavigator.DeleteItem = null;
            this.pRODUTOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.pRODUTOSBindingNavigatorSaveItem});
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
            // iD_PRODUTOLabel
            // 
            iD_PRODUTOLabel.AutoSize = true;
            iD_PRODUTOLabel.Location = new System.Drawing.Point(12, 56);
            iD_PRODUTOLabel.Name = "iD_PRODUTOLabel";
            iD_PRODUTOLabel.Size = new System.Drawing.Size(78, 13);
            iD_PRODUTOLabel.TabIndex = 1;
            iD_PRODUTOLabel.Text = "ID PRODUTO:";
            // 
            // iD_PRODUTOTextBox
            // 
            this.iD_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "ID_PRODUTO", true));
            this.iD_PRODUTOTextBox.Location = new System.Drawing.Point(115, 56);
            this.iD_PRODUTOTextBox.Name = "iD_PRODUTOTextBox";
            this.iD_PRODUTOTextBox.Size = new System.Drawing.Size(325, 20);
            this.iD_PRODUTOTextBox.TabIndex = 2;
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
            // nOME_PRODUTOLabel
            // 
            nOME_PRODUTOLabel.AutoSize = true;
            nOME_PRODUTOLabel.Location = new System.Drawing.Point(10, 94);
            nOME_PRODUTOLabel.Name = "nOME_PRODUTOLabel";
            nOME_PRODUTOLabel.Size = new System.Drawing.Size(99, 13);
            nOME_PRODUTOLabel.TabIndex = 3;
            nOME_PRODUTOLabel.Text = "NOME PRODUTO:";
            // 
            // nOME_PRODUTOTextBox
            // 
            this.nOME_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "NOME_PRODUTO", true));
            this.nOME_PRODUTOTextBox.Location = new System.Drawing.Point(115, 91);
            this.nOME_PRODUTOTextBox.Name = "nOME_PRODUTOTextBox";
            this.nOME_PRODUTOTextBox.Size = new System.Drawing.Size(325, 20);
            this.nOME_PRODUTOTextBox.TabIndex = 4;
            // 
            // pRECOLabel
            // 
            pRECOLabel.AutoSize = true;
            pRECOLabel.Location = new System.Drawing.Point(12, 128);
            pRECOLabel.Name = "pRECOLabel";
            pRECOLabel.Size = new System.Drawing.Size(47, 13);
            pRECOLabel.TabIndex = 5;
            pRECOLabel.Text = "PRECO:";
            // 
            // pRECOTextBox
            // 
            this.pRECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "PRECO", true));
            this.pRECOTextBox.Location = new System.Drawing.Point(115, 128);
            this.pRECOTextBox.Name = "pRECOTextBox";
            this.pRECOTextBox.Size = new System.Drawing.Size(325, 20);
            this.pRECOTextBox.TabIndex = 6;
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(12, 156);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(81, 13);
            qUANTIDADELabel.TabIndex = 7;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOSBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(115, 156);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(325, 20);
            this.qUANTIDADETextBox.TabIndex = 8;
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
            this.Controls.Add(iD_PRODUTOLabel);
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
        private System.Windows.Forms.BindingNavigator pRODUTOSBindingNavigator;
        private System.Windows.Forms.ToolStripButton pRODUTOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PRODUTOTextBox;
        private System.Windows.Forms.TextBox nOME_PRODUTOTextBox;
        private System.Windows.Forms.TextBox pRECOTextBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}