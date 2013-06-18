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
    public partial class Encomendas : Form
    {
        public Encomendas()
        {
            InitializeComponent();
        }

        private void refeições_EncomendadasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.refeições_EncomendadasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Encomendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Refeições_Encomendadas' table. You can move, or remove it, as needed.
            this.refeições_EncomendadasTableAdapter.Fill(this.database1DataSet.Refeições_Encomendadas);

        }
    }
}
