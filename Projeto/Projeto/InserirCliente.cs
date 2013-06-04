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
    public partial class InserirCliente : Form
    {
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void InserirCliente_Load(object sender, EventArgs e)
        {
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientes1TableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text));
                MessageBox.Show("Inserido novo cliente");
            }
            catch (Exception ex) {
                MessageBox.Show("Erro a inserir");
            }


           }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void clientes1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientes1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

