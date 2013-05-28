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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refeições_ingredientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refeições_ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_ingredientes' table. You can move, or remove it, as needed.
            this.refeições_ingredientesTableAdapter.Fill(this.database1DataSet.Refeições_ingredientes);

        }

        private void button1_Click(object sender, EventArgs e)



        {
            //this.refeições_ingredientesTableAdapter.Insert(this.textBox1, Text, Convert.ToInt32(this.textBox2.Text, Convert.ToInt32));
           
            MessageBox.Show("Inserido com sucesso");
        }
    }
}
