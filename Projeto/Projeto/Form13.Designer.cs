namespace Projeto
{
    partial class Form13
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
            System.Windows.Forms.Label id_RefeiçõesLabel;
            System.Windows.Forms.Label id_IngredientesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.database1DataSet = new Projeto.Database1DataSet();
            this.refeições_ingredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeições_ingredientesTableAdapter = new Projeto.Database1DataSetTableAdapters.Refeições_ingredientesTableAdapter();
            this.tableAdapterManager = new Projeto.Database1DataSetTableAdapters.TableAdapterManager();
            this.refeições_ingredientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_RefeiçõesTextBox = new System.Windows.Forms.TextBox();
            this.id_IngredientesTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.refeições_ingredientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            id_RefeiçõesLabel = new System.Windows.Forms.Label();
            id_IngredientesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingNavigator)).BeginInit();
            this.refeições_ingredientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refeições_ingredientesBindingSource
            // 
            this.refeições_ingredientesBindingSource.DataMember = "Refeições_ingredientes";
            this.refeições_ingredientesBindingSource.DataSource = this.database1DataSet;
            // 
            // refeições_ingredientesTableAdapter
            // 
            this.refeições_ingredientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Clientes1TableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Encomenda1TableAdapter = null;
            this.tableAdapterManager.EncomendaTableAdapter = null;
            this.tableAdapterManager.Ingrediente1TableAdapter = null;
            this.tableAdapterManager.IngredienteTableAdapter = null;
            this.tableAdapterManager.Refeições_EncomendadasTableAdapter = null;
            this.tableAdapterManager.Refeições_ingredientesTableAdapter = this.refeições_ingredientesTableAdapter;
            this.tableAdapterManager.Refeições1TableAdapter = null;
            this.tableAdapterManager.RefeiçõesTableAdapter = null;
            this.tableAdapterManager.TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // refeições_ingredientesBindingNavigator
            // 
            this.refeições_ingredientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.refeições_ingredientesBindingNavigator.BindingSource = this.refeições_ingredientesBindingSource;
            this.refeições_ingredientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.refeições_ingredientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.refeições_ingredientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.refeições_ingredientesBindingNavigatorSaveItem});
            this.refeições_ingredientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.refeições_ingredientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.refeições_ingredientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.refeições_ingredientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.refeições_ingredientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.refeições_ingredientesBindingNavigator.Name = "refeições_ingredientesBindingNavigator";
            this.refeições_ingredientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.refeições_ingredientesBindingNavigator.Size = new System.Drawing.Size(415, 25);
            this.refeições_ingredientesBindingNavigator.TabIndex = 0;
            this.refeições_ingredientesBindingNavigator.Text = "bindingNavigator1";
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
            // id_RefeiçõesLabel
            // 
            id_RefeiçõesLabel.AutoSize = true;
            id_RefeiçõesLabel.Location = new System.Drawing.Point(12, 56);
            id_RefeiçõesLabel.Name = "id_RefeiçõesLabel";
            id_RefeiçõesLabel.Size = new System.Drawing.Size(70, 13);
            id_RefeiçõesLabel.TabIndex = 1;
            id_RefeiçõesLabel.Text = "Id Refeições:";
            // 
            // id_RefeiçõesTextBox
            // 
            this.id_RefeiçõesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_ingredientesBindingSource, "Id_Refeições", true));
            this.id_RefeiçõesTextBox.Location = new System.Drawing.Point(98, 53);
            this.id_RefeiçõesTextBox.Name = "id_RefeiçõesTextBox";
            this.id_RefeiçõesTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_RefeiçõesTextBox.TabIndex = 2;
            // 
            // id_IngredientesLabel
            // 
            id_IngredientesLabel.AutoSize = true;
            id_IngredientesLabel.Location = new System.Drawing.Point(12, 82);
            id_IngredientesLabel.Name = "id_IngredientesLabel";
            id_IngredientesLabel.Size = new System.Drawing.Size(80, 13);
            id_IngredientesLabel.TabIndex = 3;
            id_IngredientesLabel.Text = "Id Ingredientes:";
            // 
            // id_IngredientesTextBox
            // 
            this.id_IngredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_ingredientesBindingSource, "Id_Ingredientes", true));
            this.id_IngredientesTextBox.Location = new System.Drawing.Point(98, 79);
            this.id_IngredientesTextBox.Name = "id_IngredientesTextBox";
            this.id_IngredientesTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_IngredientesTextBox.TabIndex = 4;
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
            // refeições_ingredientesBindingNavigatorSaveItem
            // 
            this.refeições_ingredientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refeições_ingredientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("refeições_ingredientesBindingNavigatorSaveItem.Image")));
            this.refeições_ingredientesBindingNavigatorSaveItem.Name = "refeições_ingredientesBindingNavigatorSaveItem";
            this.refeições_ingredientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.refeições_ingredientesBindingNavigatorSaveItem.Text = "Save Data";
            this.refeições_ingredientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.refeições_ingredientesBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.refeições_ingredientesBindingSource;
            this.listBox1.DisplayMember = "Id_Refeições";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(239, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "Id_Ingredientes";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_RefeiçõesLabel);
            this.Controls.Add(this.id_RefeiçõesTextBox);
            this.Controls.Add(id_IngredientesLabel);
            this.Controls.Add(this.id_IngredientesTextBox);
            this.Controls.Add(this.refeições_ingredientesBindingNavigator);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingNavigator)).EndInit();
            this.refeições_ingredientesBindingNavigator.ResumeLayout(false);
            this.refeições_ingredientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource refeições_ingredientesBindingSource;
        private Database1DataSetTableAdapters.Refeições_ingredientesTableAdapter refeições_ingredientesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator refeições_ingredientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton refeições_ingredientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_RefeiçõesTextBox;
        private System.Windows.Forms.TextBox id_IngredientesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}