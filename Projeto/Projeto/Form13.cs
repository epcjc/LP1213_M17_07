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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void refeições_ingredientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refeições_ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_ingredientes' table. You can move, or remove it, as needed.
            this.refeições_ingredientesTableAdapter.Fill(this.database1DataSet.Refeições_ingredientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
