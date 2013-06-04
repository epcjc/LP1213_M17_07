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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.refeiçõesTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, null, Convert.ToDecimal(this.textBox3.Text), 1);

           int ultimoID = (int) this.refeiçõesTableAdapter.UltimoID();
            int id_ingrediente;

            foreach (DataRowView drv in  listBox1.SelectedItems)
            {
                id_ingrediente = (int) drv["Id_Ingrediente"];

                this.refeições_ingredientesTableAdapter.Insert(ultimoID, id_ingrediente);
                MessageBox.Show("Inseri ingrediente" + drv["Nome"].ToString());
                
            }

            MessageBox.Show("Inserido com sucesso");
        }
            
            

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void refeiçõesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_ingredientes' table. You can move, or remove it, as needed.
            this.refeições_ingredientesTableAdapter.Fill(this.database1DataSet.Refeições_ingredientes);
            // TODO: This line of code loads data into the 'database1DataSet.Ingrediente' table. You can move, or remove it, as needed.
            this.ingredienteTableAdapter.Fill(this.database1DataSet.Ingrediente);
            // TODO: This line of code loads data into the 'database1DataSet.Refeições' table. You can move, or remove it, as needed.
            this.refeiçõesTableAdapter.Fill(this.database1DataSet.Refeições);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
