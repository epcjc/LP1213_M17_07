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
    public partial class Relatorio1 : Form
    {
        public Relatorio1()
        {
            InitializeComponent();
        }

        private void Relatorio1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Ingrediente' table. You can move, or remove it, as needed.
            this.IngredienteTableAdapter.Fill(this.Database1DataSet.Ingrediente);

            this.reportViewer1.RefreshReport();
        }
    }
}
