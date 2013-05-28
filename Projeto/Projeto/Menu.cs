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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void inseriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           InserirEncomenda frm = new InserirEncomenda();
            frm.ShowDialog();
        }

        private void clentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void refeiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void pesquisrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void pesquisrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();
        }

        private void ingredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          InserirIngrediente frm = new InserirIngrediente();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           InserirCliente frm = new InserirCliente();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
        }

        private void inseriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void encomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refeiçõesIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        }
    }

