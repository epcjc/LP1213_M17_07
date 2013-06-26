namespace Projeto
{
    partial class Total_Ingredientes_Cada_Refeicao
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
            this.Database1DataSet = new Projeto.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Total_Ingredientes_Cada_RefeiçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Total_Ingredientes_Cada_RefeiçãoTableAdapter = new Projeto.Database1DataSetTableAdapters.Total_Ingredientes_Cada_RefeiçãoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Ingredientes_Cada_RefeiçãoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Total_Ingredientes_Cada_RefeiçãoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.relatorios.Relatorio_Total_Ingredientes_Cada_Refeicaodlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // Total_Ingredientes_Cada_RefeiçãoBindingSource
            // 
            this.Total_Ingredientes_Cada_RefeiçãoBindingSource.DataMember = "Total_Ingredientes_Cada_Refeição";
            this.Total_Ingredientes_Cada_RefeiçãoBindingSource.DataSource = this.Database1DataSet;
            // 
            // Total_Ingredientes_Cada_RefeiçãoTableAdapter
            // 
            this.Total_Ingredientes_Cada_RefeiçãoTableAdapter.ClearBeforeFill = true;
            // 
            // Total_Ingredientes_Cada_Refeicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 575);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Total_Ingredientes_Cada_Refeicao";
            this.Text = "Total_Ingredientes_Cada_Refeicao";
            this.Load += new System.EventHandler(this.Total_Ingredientes_Cada_Refeicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Ingredientes_Cada_RefeiçãoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet Database1DataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Total_Ingredientes_Cada_RefeiçãoBindingSource;
        private Database1DataSetTableAdapters.Total_Ingredientes_Cada_RefeiçãoTableAdapter Total_Ingredientes_Cada_RefeiçãoTableAdapter;
    }
}