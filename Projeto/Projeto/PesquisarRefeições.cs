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
    public partial class PesquisarRefeições : Form
    {
        public PesquisarRefeições()
        {
            InitializeComponent();
        }

        private void refeições_ingredientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refeições_ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_IngredientesNome' table. You can move, or remove it, as needed.
            this.refeições_IngredientesNomeTableAdapter.Fill(this.database1DataSet.Refeições_IngredientesNome);
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_IngredientesNome' table. You can move, or remove it, as needed.
            this.refeições_IngredientesNomeTableAdapter.Fill(this.database1DataSet.Refeições_IngredientesNome);
            // TODO: This line of code loads data into the 'database1DataSet.Refeições' table. You can move, or remove it, as needed.
            this.refeiçõesTableAdapter.Fill(this.database1DataSet.Refeições);
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_ingredientes' table. You can move, or remove it, as needed.
            this.refeições_ingredientesTableAdapter.Fill(this.database1DataSet.Refeições_ingredientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.refeições_ingredientesTableAdapter.FillByRefeições_Ingredientes(this.database1DataSet.Refeições_ingredientes,Convert.ToInt16(textBox1.Text));*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
