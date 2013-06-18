namespace Projeto
{
    partial class Encomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encomendas));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_RefeiçãoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label preço_RefeiçãoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label id_EncomendaLabel;
            this.database1DataSet = new Projeto.Database1DataSet();
            this.refeições_EncomendadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeições_EncomendadasTableAdapter = new Projeto.Database1DataSetTableAdapters.Refeições_EncomendadasTableAdapter();
            this.tableAdapterManager = new Projeto.Database1DataSetTableAdapters.TableAdapterManager();
            this.refeições_EncomendadasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refeições_EncomendadasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.refeições_EncomendadasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_RefeiçãoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.preço_RefeiçãoTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.id_EncomendaTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            id_RefeiçãoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            preço_RefeiçãoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            id_EncomendaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasBindingNavigator)).BeginInit();
            this.refeições_EncomendadasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refeições_EncomendadasBindingSource
            // 
            this.refeições_EncomendadasBindingSource.DataMember = "Refeições_Encomendadas";
            this.refeições_EncomendadasBindingSource.DataSource = this.database1DataSet;
            // 
            // refeições_EncomendadasTableAdapter
            // 
            this.refeições_EncomendadasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Refeições_EncomendadasTableAdapter = this.refeições_EncomendadasTableAdapter;
            this.tableAdapterManager.Refeições_ingredientesTableAdapter = null;
            this.tableAdapterManager.Refeições1TableAdapter = null;
            this.tableAdapterManager.RefeiçõesTableAdapter = null;
            this.tableAdapterManager.TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // refeições_EncomendadasBindingNavigator
            // 
            this.refeições_EncomendadasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.refeições_EncomendadasBindingNavigator.BindingSource = this.refeições_EncomendadasBindingSource;
            this.refeições_EncomendadasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.refeições_EncomendadasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.refeições_EncomendadasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.refeições_EncomendadasBindingNavigatorSaveItem});
            this.refeições_EncomendadasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.refeições_EncomendadasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.refeições_EncomendadasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.refeições_EncomendadasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.refeições_EncomendadasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.refeições_EncomendadasBindingNavigator.Name = "refeições_EncomendadasBindingNavigator";
            this.refeições_EncomendadasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.refeições_EncomendadasBindingNavigator.Size = new System.Drawing.Size(674, 25);
            this.refeições_EncomendadasBindingNavigator.TabIndex = 0;
            this.refeições_EncomendadasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // refeições_EncomendadasBindingNavigatorSaveItem
            // 
            this.refeições_EncomendadasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refeições_EncomendadasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("refeições_EncomendadasBindingNavigatorSaveItem.Image")));
            this.refeições_EncomendadasBindingNavigatorSaveItem.Name = "refeições_EncomendadasBindingNavigatorSaveItem";
            this.refeições_EncomendadasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.refeições_EncomendadasBindingNavigatorSaveItem.Text = "Save Data";
            this.refeições_EncomendadasBindingNavigatorSaveItem.Click += new System.EventHandler(this.refeições_EncomendadasBindingNavigatorSaveItem_Click);
            // 
            // refeições_EncomendadasDataGridView
            // 
            this.refeições_EncomendadasDataGridView.AutoGenerateColumns = false;
            this.refeições_EncomendadasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refeições_EncomendadasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.refeições_EncomendadasDataGridView.DataSource = this.refeições_EncomendadasBindingSource;
            this.refeições_EncomendadasDataGridView.Location = new System.Drawing.Point(12, 38);
            this.refeições_EncomendadasDataGridView.Name = "refeições_EncomendadasDataGridView";
            this.refeições_EncomendadasDataGridView.Size = new System.Drawing.Size(642, 220);
            this.refeições_EncomendadasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Refeição";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Refeição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preço_Refeição";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço_Refeição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Encomenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_Encomenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(9, 276);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(99, 273);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // id_RefeiçãoLabel
            // 
            id_RefeiçãoLabel.AutoSize = true;
            id_RefeiçãoLabel.Location = new System.Drawing.Point(9, 302);
            id_RefeiçãoLabel.Name = "id_RefeiçãoLabel";
            id_RefeiçãoLabel.Size = new System.Drawing.Size(65, 13);
            id_RefeiçãoLabel.TabIndex = 4;
            id_RefeiçãoLabel.Text = "Id Refeição:";
            // 
            // id_RefeiçãoTextBox
            // 
            this.id_RefeiçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Id_Refeição", true));
            this.id_RefeiçãoTextBox.Location = new System.Drawing.Point(99, 299);
            this.id_RefeiçãoTextBox.Name = "id_RefeiçãoTextBox";
            this.id_RefeiçãoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_RefeiçãoTextBox.TabIndex = 5;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(9, 328);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 6;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(99, 325);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 7;
            // 
            // preço_RefeiçãoLabel
            // 
            preço_RefeiçãoLabel.AutoSize = true;
            preço_RefeiçãoLabel.Location = new System.Drawing.Point(9, 354);
            preço_RefeiçãoLabel.Name = "preço_RefeiçãoLabel";
            preço_RefeiçãoLabel.Size = new System.Drawing.Size(84, 13);
            preço_RefeiçãoLabel.TabIndex = 8;
            preço_RefeiçãoLabel.Text = "Preço Refeição:";
            // 
            // preço_RefeiçãoTextBox
            // 
            this.preço_RefeiçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Preço_Refeição", true));
            this.preço_RefeiçãoTextBox.Location = new System.Drawing.Point(99, 351);
            this.preço_RefeiçãoTextBox.Name = "preço_RefeiçãoTextBox";
            this.preço_RefeiçãoTextBox.Size = new System.Drawing.Size(100, 20);
            this.preço_RefeiçãoTextBox.TabIndex = 9;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(9, 380);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(49, 13);
            subtotalLabel.TabIndex = 10;
            subtotalLabel.Text = "Subtotal:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(99, 377);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalTextBox.TabIndex = 11;
            // 
            // id_EncomendaLabel
            // 
            id_EncomendaLabel.AutoSize = true;
            id_EncomendaLabel.Location = new System.Drawing.Point(9, 406);
            id_EncomendaLabel.Name = "id_EncomendaLabel";
            id_EncomendaLabel.Size = new System.Drawing.Size(79, 13);
            id_EncomendaLabel.TabIndex = 12;
            id_EncomendaLabel.Text = "Id Encomenda:";
            // 
            // id_EncomendaTextBox
            // 
            this.id_EncomendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_EncomendadasBindingSource, "Id_Encomenda", true));
            this.id_EncomendaTextBox.Location = new System.Drawing.Point(99, 403);
            this.id_EncomendaTextBox.Name = "id_EncomendaTextBox";
            this.id_EncomendaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_EncomendaTextBox.TabIndex = 13;
            // 
            // Encomendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 488);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_RefeiçãoLabel);
            this.Controls.Add(this.id_RefeiçãoTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(preço_RefeiçãoLabel);
            this.Controls.Add(this.preço_RefeiçãoTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(id_EncomendaLabel);
            this.Controls.Add(this.id_EncomendaTextBox);
            this.Controls.Add(this.refeições_EncomendadasDataGridView);
            this.Controls.Add(this.refeições_EncomendadasBindingNavigator);
            this.Name = "Encomendas";
            this.Text = "Encomendas";
            this.Load += new System.EventHandler(this.Encomendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasBindingNavigator)).EndInit();
            this.refeições_EncomendadasBindingNavigator.ResumeLayout(false);
            this.refeições_EncomendadasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_EncomendadasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource refeições_EncomendadasBindingSource;
        private Database1DataSetTableAdapters.Refeições_EncomendadasTableAdapter refeições_EncomendadasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator refeições_EncomendadasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton refeições_EncomendadasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView refeições_EncomendadasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_RefeiçãoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox preço_RefeiçãoTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox id_EncomendaTextBox;
    }
}