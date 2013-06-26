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
    public partial class Pesquisar_refeições1 : Form
    {
        public Pesquisar_refeições1()
        {
            InitializeComponent();
        }

        private void refeiçõesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refeiçõesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
            // TODO: This line of code loads data into the 'database1DataSet.Refeições' table. You can move, or remove it, as needed.
            this.refeiçõesTableAdapter.Fill(this.database1DataSet.Refeições);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.refeiçõesTableAdapter.FillByNome(this.database1DataSet.Refeições, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
