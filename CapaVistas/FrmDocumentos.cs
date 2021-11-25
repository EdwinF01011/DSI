using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//  import, para poder conseguir el nombre del archivo 

namespace DSI.CapaVistas
{
    public partial class FrmDocumentos : Form
    {
        public FrmDocumentos()
        {
            InitializeComponent();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FrmProgreso frmProg = new FrmProgreso();
            frmProg.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            ExploradorArchivos();
        }

        private void ExploradorArchivos()
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
                string cadena = txtRuta.Text;
                FileInfo fi = new FileInfo(cadena);
                var nombre = fi.Name;// lo devuelve con extensión.
                var nombre2 = Path.GetFileNameWithoutExtension(fi.Name);// sin extensión.
                txtNameDoc.Text = nombre2;
            }

            // ttps://es.stackoverflow.com/questions/285939/obtener-nombre-del-archivo-en-una-ruta-con-c
        }


        /*
         
        NOTAS

           TxtNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNombre.Text);
            TxtNombre.SelectionStart = TxtNombre.Text.Length;
            TxtNombre.Text=CultureInfo.InvariantCulture.TextInfo.ToTitleCase(TxtNombre.Text.ToLower());


            observaciones campo en Documentos

            previsualizador de imagenes
            exportar contactos, pdf o excel
            cambiar la documentación


         */

    }
}
