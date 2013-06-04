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
    public partial class InserirEncomenda : Form
    {
        public InserirEncomenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.encomendaTableAdapter.Insert(Convert.ToInt16(this.textBox1.Text), this.dateTimePicker1.Value, Convert.ToDecimal(this.textBox3.Text));
            MessageBox.Show("Inserido com sucesso");
        }

        private void encomendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encomendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void InserirEncomenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Encomenda' table. You can move, or remove it, as needed.
            this.encomendaTableAdapter.Fill(this.database1DataSet.Encomenda);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
