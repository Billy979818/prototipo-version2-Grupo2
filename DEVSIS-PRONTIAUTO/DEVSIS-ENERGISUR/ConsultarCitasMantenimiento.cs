﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarCitasMantenimiento : Form
    {
        public ConsultarCitasMantenimiento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegistrarCitaMantenimiento().Show();
            this.Close();
        }
    }
}
