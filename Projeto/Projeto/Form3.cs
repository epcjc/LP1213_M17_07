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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Clientes1' table. You can move, or remove it, as needed.
            this.clientes1TableAdapter.Fillbyinsericliente(this.database1DataSet.Clientes1);
            // TODO: This line of code loads data into the 'database1DataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillByCliente(this.database1DataSet.Clientes,textBox1.Text);
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
