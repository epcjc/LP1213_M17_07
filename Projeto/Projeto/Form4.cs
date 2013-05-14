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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ingredienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Ingrediente' table. You can move, or remove it, as needed.
            this.ingredienteTableAdapter.Fill(this.database1DataSet.Ingrediente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ingredienteTableAdapter.FillByIngrediente(this.database1DataSet.Ingrediente,textBox1.Text);
        }
    }
}
