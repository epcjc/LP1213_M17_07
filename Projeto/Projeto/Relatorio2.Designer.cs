namespace Projeto
{
    partial class Relatorio2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new Projeto.Database1DataSet();
            this.RefeiçõesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RefeiçõesTableAdapter = new Projeto.Database1DataSetTableAdapters.RefeiçõesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefeiçõesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RefeiçõesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RefeiçõesBindingSource
            // 
            this.RefeiçõesBindingSource.DataMember = "Refeições";
            this.RefeiçõesBindingSource.DataSource = this.Database1DataSet;
            // 
            // RefeiçõesTableAdapter
            // 
            this.RefeiçõesTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio2";
            this.Text = "Relatorio2";
            this.Load += new System.EventHandler(this.Relatorio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefeiçõesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RefeiçõesBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.RefeiçõesTableAdapter RefeiçõesTableAdapter;
    }
}