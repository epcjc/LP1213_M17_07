﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Total_Ingredientes_Cada_Refeicao : Form
    {
        public Total_Ingredientes_Cada_Refeicao()
        {
            InitializeComponent();
        }

        private void Total_Ingredientes_Cada_Refeicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Total_Ingredientes_Cada_Refeição' table. You can move, or remove it, as needed.
            this.Total_Ingredientes_Cada_RefeiçãoTableAdapter.Fill(this.Database1DataSet.Total_Ingredientes_Cada_Refeição);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
