﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btcadcliente_Click(object sender, EventArgs e)
        {
            cadastroclientes cadastro = new cadastroclientes();
            cadastro.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
