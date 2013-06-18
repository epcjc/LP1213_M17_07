using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void Relatório_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet1.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.Database1DataSet1.Clientes);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
