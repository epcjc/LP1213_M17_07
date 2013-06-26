namespace Projeto
{
    partial class Listar_Ingredientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IngredienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Projeto.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IngredienteTableAdapter = new Projeto.Database1DataSetTableAdapters.IngredienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IngredienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IngredienteBindingSource
            // 
            this.IngredienteBindingSource.DataMember = "Ingrediente";
            this.IngredienteBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IngredienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.relatorios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // IngredienteTableAdapter
            // 
            this.IngredienteTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio1";
            this.Text = "Relatorio1";
            this.Load += new System.EventHandler(this.Relatorio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngredienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IngredienteBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.IngredienteTableAdapter IngredienteTableAdapter;
    }
}