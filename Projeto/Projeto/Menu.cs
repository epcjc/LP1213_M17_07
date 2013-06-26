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
            InserirEmDuasForm frm = new InserirEmDuasForm();
            frm.ShowDialog();
        }

        private void pesquisrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pesquisar_refeições1 frm = new Pesquisar_refeições1();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Cliente frm = new Pesquisar_Cliente();
            frm.ShowDialog();
        }

        private void pesquisrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Ingrediete frm = new Pesquisar_Ingrediete();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pesquizar frm = new Pesquizar();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
            PesquisarRefeições frm = new PesquisarRefeições();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           InserirCliente frm = new InserirCliente();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
           
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Clientes frm = new Listar_Clientes();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listar_Tipo frm = new Listar_Tipo();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListarIngridente frm = new ListarIngridente();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.ShowDialog();
        }

        private void inseriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void encomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refeiçõesIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refeiçõesEncomendadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void efeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encomendas frm = new Encomendas();
            frm.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Relatório frm = new Relatório();
            //frm.ShowDialog();
        }

        private void relatorioaula7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void realatórioAula7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatóriaAula7 frm = new RelatóriaAula7();
            frm.ShowDialog();
        }

        private void forms7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Errorprovider frm = new Errorprovider();
            frm.ShowDialog();
        }

        private void relatorio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Listar_Ingredientes frm = new Listar_Ingredientes();
            frm.ShowDialog();
        }

        private void relatorio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Refeições frm = new Listar_Refeições();
            frm.ShowDialog();
        }

        private void totalIngredientesCadaRefeicaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total_Ingredientes_Cada_Refeicao frm = new Total_Ingredientes_Cada_Refeicao();
            frm.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        }
    }

