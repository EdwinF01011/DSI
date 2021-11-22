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
    public partial class FrmUbicación : Form
    {
        ClsBusqueda ObjBu = new ClsBusqueda();
        ClsUbicacion ObjUbi = new ClsUbicacion();

        Byte idPais, idCity;

        public FrmUbicación()
        {
            InitializeComponent();
        }

        private void FrmUbicación_Load(object sender, EventArgs e)
        {
            LlenarDgv();
            LlenarCboxP();
            // arreglar el evento del click, con más covertura
        }

        public void LlenarDgv()
        {
            dgvUbication.DataSource= ObjBu.BuscarCiudad();
            dgvUbication.Columns[0].Visible = false;
            dgvUbication.Columns[2].Visible = false;

        }

        private void LlenarCboxP()
        {
            cboxPais.DataSource = ObjBu.BuscarPais();
            cboxPais.DisplayMember = "Npais";
            cboxPais.ValueMember = "id";
        }

        private void InsertPais()//                                  >>>>>>
        {
            ObjUbi.InsertPais(txtPais.Text);
        }

        private void UpdatePais()
        {
            ObjUbi.updatePais(idPais, txtPais.Text);
        }

        private void InsertCity()
        {
            //label4.Text = cboxPais.SelectedValue.ToString();
            ObjUbi.InsertCity(txtCiudad.Text,Byte.Parse(cboxPais.SelectedValue.ToString()));
        }

        private void UpdateCity()
        {
            ObjUbi.UpdateCity(txtCiudad.Text, idCity);
        }//                                                         <<<<<<

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
            if(btnAñadir.Text== "Actualizar")
            {
                UpdateCity();
                MessageBox.Show("actualizando ciudad, dentro del if");

            }
            else
                InsertCity();
            LlenarCboxP();
            LlenarDgv();

        }

        private void btnAñadirPais_Click(object sender, EventArgs e)
        {
            
            if (btnAñadirPais.Text == "Actualizar")
            {
                UpdatePais();
            }
            else
                InsertPais();
            LlenarCboxP();
            LlenarDgv();

        }

        private void dgvUbication_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAñadir.Text = "Actualizar";
            btnAñadirPais.Text = "Actualizar";
            //txtCiudad.Text

            idCity = Byte.Parse(dgvUbication.CurrentRow.Cells[0].Value.ToString());
            txtCiudad.Text = dgvUbication.CurrentRow.Cells[1].Value.ToString();
            idPais = Byte.Parse(dgvUbication.CurrentRow.Cells[2].Value.ToString());
            txtPais.Text = dgvUbication.CurrentRow.Cells[3].Value.ToString();



            label4.Text = idPais.ToString();

        }

        private void FrmUbicación_Click(object sender, EventArgs e)
        {
            btnAñadir.Text = "Añadir";
            btnAñadirPais.Text = "Añadir";
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            btnAñadir.Text = "Añadir";
            btnAñadirPais.Text = "Añadir";
        }

        private void getItem()
        {

        }

        




    }
}
