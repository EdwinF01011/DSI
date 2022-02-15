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
using DSI.Negocio;
using System.Diagnostics;// import usado para abrir archivos.

namespace DSI.CapaVistas
{
    public partial class FrmDocumentos : Form
    {
        ClsDocumentos _documen = new ClsDocumentos();

        Int16 itemDoc;
        string rutaFile;

        public FrmDocumentos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {
            consultarDocs();
            btnDelete.Enabled = false;
            btnAnexar.Enabled = false;
            btnOpenFile.Enabled = false;
            accesosRol();

        //--https://www.youtube.com/watch?v=HDcdX2endE8

        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            ExploradorArchivos();
            btnAnexar.Enabled = true;
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

        private void consultarDocs()
        {
            dgvDocs.DataSource = _documen.consultaDoc();
            dgvDocs.Columns[0].Visible = false;
            dgvDocs.Columns[4].Visible = false;
        }

        private void insertDocs()
        {
            _documen.InsertDocu(txtNameDoc.Text, txtRuta.Text, txtObsr.Text,Clscontacto.idContanto);
        }

        private void deleteDocs()
        {
            _documen.DeleteDoc(itemDoc);
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            insertDocs();
            lblAlert.Text = "El documento ha sido guardado";
            //consultarDocs();
            clearVista();

        }

        private void dgvDocs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemDoc = Int16.Parse(dgvDocs.CurrentRow.Cells[0].Value.ToString());
            rutaFile = dgvDocs.CurrentRow.Cells[2].Value.ToString();
            btnOpenFile.Enabled = true;
            btnDelete.Enabled = true;
            btnOpenFile.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteDocs();
            lblAlert.Text = "El documento ha sido eliminado";
            //consultarDocs();
            clearVista();

        }

        private void clearVista()
        {
            //lblAlert.Text = "-";
            txtNameDoc.Text = string.Empty;
            txtRuta.Text = string.Empty;
            txtObsr.Text = string.Empty;
            btnDelete.Enabled = false;
            btnAnexar.Enabled = false;
            btnOpenFile.Enabled = false;
            consultarDocs();
        }

        private void FrmDocumentos_Click(object sender, EventArgs e)
        {
            lblAlert.Text = "-";
            clearVista();
        }

        private void abrirFile()
        {
            

            try
            {
                //abre archivos por la ruta.
                Process proceso = new Process();
                //proceso.StartInfo.FileName = @"";// se índica la ruta entre las "".
                proceso.StartInfo.FileName = rutaFile;

                proceso.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show("El sistema no pudo encontrar el archivo seleccionado"  /*ex.ToString()*/);
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            abrirFile();
        }

        private void accesosRol()//  bloque accesos según el rol
        {
            if (ClsUsuario.rolUsuario == 1)
            {
                btnDelete.Visible = false;
            }
        }
        /*

NOTAS

  TxtNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNombre.Text);
   TxtNombre.SelectionStart = TxtNombre.Text.Length;
   TxtNombre.Text=CultureInfo.InvariantCulture.TextInfo.ToTitleCase(TxtNombre.Text.ToLower());


   observaciones campo en Documentos

   previsualizador de imagenes-listo
   exportar contactos, pdf o excel
   cambiar la documentación


*/

    }
}
