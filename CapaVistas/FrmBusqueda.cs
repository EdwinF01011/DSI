﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI.Negocio;

namespace DSI.CapaVistas
{
    public partial class FrmBusqueda : Form
    {
        public FrmBusqueda()
        {
            InitializeComponent();
        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            Nombre_Usuario();
        }

        private void Nombre_Usuario()
        {
            lblUsuarioname.Text = ClsUsuario.nameUsuario;
        }

        public void Busqueda_tipo_label(string x)
        {
            //Cuando el usuario seleccione el tipo de categoría que
            //quiere buscar
            lblcategoria.Text = x;
        }
    }
}
