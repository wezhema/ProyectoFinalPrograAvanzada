﻿using DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaRegistrarCuenta : Form
    {
        public fmVistaRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void btnSalirRegistrarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmVistaRegistrarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
			Conductor conductor = new Conductor();
			ClienteTCP.Registrar(conductor);
        }
    }
}