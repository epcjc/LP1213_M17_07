namespace Projeto
{
    partial class PesquisarRefeições
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
            System.Windows.Forms.Label id_IngredientesLabel;
            System.Windows.Forms.Label id_RefeiçõesLabel;
            this.refeições_ingredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Projeto.Database1DataSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refeiçõesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeições_ingredientesTableAdapter = new Projeto.Database1DataSetTableAdapters.Refeições_ingredientesTableAdapter();
            this.tableAdapterManager = new Projeto.Database1DataSetTableAdapters.TableAdapterManager();
            this.refeiçõesTableAdapter = new Projeto.Database1DataSetTableAdapters.RefeiçõesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refeiçõesRefeiçõesIngredientesNomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refeições_IngredientesNomeTableAdapter = new Projeto.Database1DataSetTableAdapters.Refeições_IngredientesNomeTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id_RefeiçõesTextBox = new System.Windows.Forms.TextBox();
            this.id_IngredientesTextBox = new System.Windows.Forms.TextBox();
            id_IngredientesLabel = new System.Windows.Forms.Label();
            id_RefeiçõesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeiçõesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeiçõesRefeiçõesIngredientesNomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // refeições_ingredientesBindingSource
            // 
            this.refeições_ingredientesBindingSource.DataMember = "Refeições_ingredientes";
            this.refeições_ingredientesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.refeiçõesBindingSource;
            this.listBox1.DisplayMember = "Nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(279, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 8;
            this.listBox1.ValueMember = "Descrição";
            // 
            // refeiçõesBindingSource
            // 
            this.refeiçõesBindingSource.DataMember = "Refeições";
            this.refeiçõesBindingSource.DataSource = this.database1DataSet;
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
            // refeiçõesTableAdapter
            // 
            this.refeiçõesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.refeiçõesRefeiçõesIngredientesNomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(429, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // refeiçõesRefeiçõesIngredientesNomeBindingSource
            // 
            this.refeiçõesRefeiçõesIngredientesNomeBindingSource.DataMember = "Refeições_Refeições_IngredientesNome";
            this.refeiçõesRefeiçõesIngredientesNomeBindingSource.DataSource = this.refeiçõesBindingSource;
            // 
            // refeições_IngredientesNomeTableAdapter
            // 
            this.refeições_IngredientesNomeTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id_Refeições";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // id_IngredientesLabel
            // 
            id_IngredientesLabel.AutoSize = true;
            id_IngredientesLabel.Location = new System.Drawing.Point(4, 41);
            id_IngredientesLabel.Name = "id_IngredientesLabel";
            id_IngredientesLabel.Size = new System.Drawing.Size(80, 13);
            id_IngredientesLabel.TabIndex = 13;
            id_IngredientesLabel.Text = "Id Ingredientes:";
            // 
            // id_RefeiçõesLabel
            // 
            id_RefeiçõesLabel.AutoSize = true;
            id_RefeiçõesLabel.Location = new System.Drawing.Point(4, 15);
            id_RefeiçõesLabel.Name = "id_RefeiçõesLabel";
            id_RefeiçõesLabel.Size = new System.Drawing.Size(70, 13);
            id_RefeiçõesLabel.TabIndex = 11;
            id_RefeiçõesLabel.Text = "Id Refeições:";
            // 
            // id_RefeiçõesTextBox
            // 
            this.id_RefeiçõesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_ingredientesBindingSource, "Id_Refeições", true));
            this.id_RefeiçõesTextBox.Location = new System.Drawing.Point(90, 12);
            this.id_RefeiçõesTextBox.Name = "id_RefeiçõesTextBox";
            this.id_RefeiçõesTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_RefeiçõesTextBox.TabIndex = 12;
            // 
            // id_IngredientesTextBox
            // 
            this.id_IngredientesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.refeições_ingredientesBindingSource, "Id_Ingredientes", true));
            this.id_IngredientesTextBox.Location = new System.Drawing.Point(90, 38);
            this.id_IngredientesTextBox.Name = "id_IngredientesTextBox";
            this.id_IngredientesTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_IngredientesTextBox.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 333);
            this.Controls.Add(id_RefeiçõesLabel);
            this.Controls.Add(this.id_RefeiçõesTextBox);
            this.Controls.Add(id_IngredientesLabel);
            this.Controls.Add(this.id_IngredientesTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refeições_ingredientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeiçõesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refeiçõesRefeiçõesIngredientesNomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource refeições_ingredientesBindingSource;
        private Database1DataSetTableAdapters.Refeições_ingredientesTableAdapter refeições_ingredientesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource refeiçõesBindingSource;
        private Database1DataSetTableAdapters.RefeiçõesTableAdapter refeiçõesTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource refeiçõesRefeiçõesIngredientesNomeBindingSource;
        private Database1DataSetTableAdapters.Refeições_IngredientesNomeTableAdapter refeições_IngredientesNomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox id_RefeiçõesTextBox;
        private System.Windows.Forms.TextBox id_IngredientesTextBox;
    }
}