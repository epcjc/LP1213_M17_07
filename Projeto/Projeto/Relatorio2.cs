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
    public partial class Relatorio2 : Form
    {
        public Relatorio2()
        {
            InitializeComponent();
        }

        private void Relatorio2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Refeições' table. You can move, or remove it, as needed.
            this.RefeiçõesTableAdapter.Fill(this.Database1DataSet.Refeições);

            this.reportViewer1.RefreshReport();
        }
    }
}
