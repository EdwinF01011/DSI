using System;
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
        ClsBusqueda ObjBu = new ClsBusqueda();
        ClsValidacionCajas validate = new ClsValidacionCajas();

        //ClsContactosCrud ObjBusqueda = new ClsContactosCrud();    no se usa
        //ClsContactosCrud ObjBusquedaCr = new ClsContactosCrud();  no se usa


        string NombreContacto;
        string RSocial;
        Byte itemSector;
        Byte itemPais;
        Byte itemCity;
        bool bandera = false; //para el control del evento del selectedValue
        int uno = 0, dos = 0, cinco = 0, nueve = 0, once=0;

        //  variables para los campos del dgv
        Byte id;
        string name;
        string NIT;
        string Rsocial;
        string Tel;
        string correo;
        string Direccion;
        string Sector;
        string Pais;
        string City;
        string descripcion;
        //Byte idPais; no se usa


        public FrmBusqueda()
        {
            InitializeComponent();
        }

        private void Nombre_Usuario()
        {
            //lblUsuarioname.Text = ClsUsuario.nameUsuario;// lblUsuarioname ya no existe
            lblcategoria.Text = ClsUsuario.categoria_busqueda;
            
            //dataGridView1.DataSource = ObjBu.consultaTodo();
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            LlenarCombox();
            panelMenu.Visible = false;

            //LlenarComboxSector(); no
            Nombre_Usuario();

            completyDgv();



            //txtNombreMenu.Enabled = false;

        }
        //int a=9,b=8;

        //private void sumar()// no recibe y no retorna
        //{
        //    int z = a + b;
        //}

        //private string ladrar(string comida)// recibe y no retorna
        //{
        //    string ladrido = "wao wao";
        //    int c = a + b;
        //    return ladrido;
        //}

        //private int correr(int a, int b)// recibe y retorna
        //{
        //    int c = a + b;
        //    return c;
        //}

        //private int sumar1()// solo retorna
        //{
        //    int c = a + b;
        //    return c;
        //}


        private void LlenarCombox()
        {
            //ladrar("peitas");



            //  cbox del país
            cboxPaisMenu.DataSource = ObjBu.BuscarPais();
            cboxPaisMenu.DisplayMember = "Npais";
            cboxPaisMenu.ValueMember = "id";
            if (cboxPaisMenu.Items.Count>1)
            {
                cboxPaisMenu.SelectedIndex = -1;
            }
            //  cbox del sector
            cboxSectorMenu.DataSource = ObjBu.BuscarSector();
            cboxSectorMenu.DisplayMember = "nombre_sector";
            cboxSectorMenu.ValueMember = "id";
            if (cboxSectorMenu.Items.Count > 1)
            {
                cboxSectorMenu.SelectedIndex = -1;
            }
            //  cbox de la ciudad
            //cboxCiudadMenu.DataSource = ObjBu.BuscarCiudad(itemPais);
            //cboxCiudadMenu.DisplayMember = "NCiudad";
            //cboxCiudadMenu.ValueMember = "id";
            bandera = true;
        }

        private void LlenarComboxSector()
        {
            //cboxSectorMenu.DataSource = ObjBu.BuscarSector();
            //cboxSectorMenu.DisplayMember = "nombre_sector";
            //cboxSectorMenu.ValueMember = "id";
            //bandera = true;

        }

        private void cboxSectorMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(bandera.ToString());
            if (bandera == true)
            {
                itemSector = Byte.Parse(cboxSectorMenu.SelectedValue.ToString());
                cinco = 5;
                Search_If();
                //MessageBox.Show(itemSector.ToString());

            }
        }

        private void cboxPaisMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            //para poder obtener la pk de la tabla Pais

            if (bandera == true && cboxPaisMenu.SelectedValue!=null)
            {
                itemPais = Byte.Parse(cboxPaisMenu.SelectedValue.ToString());
                //MessageBox.Show(itemPais.ToString()+" pais");
                nueve = 9;
                Search_If();
                LlenarComboxCity();
            }
        }

        private void LlenarComboxCity()
        {
            cboxCiudadMenu.DataSource = ObjBu.BuscarCiudad(itemPais);
            cboxCiudadMenu.DisplayMember = "NCiudad";
            cboxCiudadMenu.ValueMember = "id";
            if (cboxCiudadMenu.Items.Count >= 1)
            {
                cboxCiudadMenu.SelectedIndex = -1;
            }
        }

        private void cboxCiudadMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                //itemCity = Byte.Parse(cboxCiudadMenu.SelectedValue.ToString());
                short n;

                if (cboxCiudadMenu.SelectedValue!=null)
                {
                    var x = cboxCiudadMenu.SelectedValue.ToString();//   tocó usar string para prevenir el error
                    bool check = Int16.TryParse(x, out n);// si contiene números
                    if (check)
                    {
                        itemCity = Byte.Parse(x);
                        once = 11;
                        Search_If();
                        //MessageBox.Show(itemCity.ToString() + " city");
                    }
                }      
            }
        }

        

        public void Busqueda_tipo_label(string x)//string x
        {
            //Cuando el usuario seleccione el tipo de categoría que
            //quiere buscar
            lblcategoria.Text = x;
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            ////this.Hide();
            //FrmRegistro frmR = new FrmRegistro();
            //frmR.Show();

            panelMenu.Visible = true;
            traerFormRegistro1();
        }

        private void btnSalirBusq_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ObjBu.consultaTodo();
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
            //dataGridView1.Columns[13].Visible = false;

            completyDgv();

            //dataGridView1.DataSource = ObjBu.consultaTodo2();



            //Lenarlistcontac();

            //dataGridView1.DataSource = ObjBusqueda.ReadContacto();

            //dataGridView1.DataSource = ObjBu.FiltroOneFive();         //  Busca todo
        }

        public void completyDgv()
        {
            dataGridView1.DataSource = ObjBu.consultaTodo();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }

        private void ocultarCamposDGV()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
        }

        IList<Clscontacto> listcontac = new List<Clscontacto>();

        private void Lenarlistcontac()
        {//llena una lista de tipo Clscontacto # esto no se usa, borrarlo
            try
            {
                

                //Clscontacto ObjCont = new Clscontacto();
                //  no se está usando
                //Clscontacto.Nombre = txtNombreMenu.Text;
                //Clscontacto.Razón_Social = txtRsocialMenu.Text;
                //Clscontacto.id_sector = cboxSectorMenu.SelectedValue.ToString();
                //Clscontacto.id_ubicacion = cboxCiudadMenu.SelectedValue.ToString();
                //Clscontacto.id_ubicacionPais = itemPais.ToString();

                //MessageBox.Show(txtNombreMenu.Text);

                //listcontac.Add(new Clscontacto
                //{
                //    Nombre = txtNombreMenu.Text
                //    //Razón_Social = txtRsocialMenu.Text,
                //    //id_sector = cboxSectorMenu.SelectedValue.ToString(),
                //    //id_ubicacion = cboxCiudadMenu.SelectedValue.ToString(),
                //    //id_ubicacionPais = itemPais.ToString()

                //    //Nombre = null esto no

                //}) ;

            }
            catch
            {

            }
            
        }

        private void ClearTxts()
        {
            txtNombreMenu.Clear();
            txtRsocialMenu.Clear();
            itemCity = 0;
            itemPais =0;
            itemSector = 0;
            dataGridView1.Columns.Clear();
            contador = 0;
            uno = 0; dos = 0; cinco = 0; nueve = 0; once=0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTxts();
            //LlenarCombox();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // doble click al datagridview

            //FrmRegistro ObjRegistro = new FrmRegistro();
            //ObjRegistro.Show();


            id = Byte.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            name= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NIT= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Rsocial= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Tel= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            correo= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Direccion= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            Sector= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Pais= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            City= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            descripcion= dataGridView1.CurrentRow.Cells[10].Value.ToString();
            itemCity = Byte.Parse(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            itemPais = Byte.Parse(dataGridView1.CurrentRow.Cells[12].Value.ToString());
            itemSector = Byte.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString());


            

            //idPais =Byte.Parse( dataGridView1.CurrentRow.Cells[13].Value.ToString());



            panelMenu.Visible = true;
            traerFormRegistro();
            //MessageBox.Show("sirve 2");

        }
        FrmRegistro frmRe = new FrmRegistro();
        private void traerFormRegistro()
        {
            frmRe = new FrmRegistro();
            frmRe.TopLevel = false;
            panelMenu.Controls.Add(frmRe);
            //
            frmRe.Show();
            frmRe.Proces(1);
            frmRe.AsignarValues(
                id,
                name,
                NIT,
                Rsocial,
                Tel,
                correo,
                Direccion,
                 Sector,
                 Pais,
                 City,
                descripcion,
                itemCity,
                itemPais,
                itemSector

                );

        }

        private void traerFormRegistro1()
        {
            frmRe = new FrmRegistro();
            frmRe.TopLevel = false;
            panelMenu.Controls.Add(frmRe);
            frmRe.Show();
            frmRe.Proces(0);
        }

        private void FrmBusqueda_Click(object sender, EventArgs e)
        {// para cerrar el panel
            panelMenu.Visible = false;
            frmRe.Close();

        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            cambioBusqueda();
            completyDgv();
        }

        private void cambioBusqueda()
        {
            if (lblcategoria.Text == "Clientes")
            {
                ClsUsuario.number_categoria = true;
                ClsUsuario.categoria_busqueda = "Proveedores";
                lblcategoria.Text = ClsUsuario.categoria_busqueda;
            }
            else if (lblcategoria.Text == "Proveedores")
            {
                ClsUsuario.number_categoria = false;
                ClsUsuario.categoria_busqueda = "Clientes";
                lblcategoria.Text = ClsUsuario.categoria_busqueda;
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            cambioBusqueda();
            completyDgv();
        }

        private void txtNombreMenu_KeyUp(object sender, KeyEventArgs e)
        {
            //validate.SoloLetras2(e);
            uno = 1;
            Search_If();
        }

        private void txtRsocialMenu_KeyUp(object sender, KeyEventArgs e)
        {
            RSocial = txtRsocialMenu.Text;
            dos = 2;
            Search_If();
        }

        private void txtNombreMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }

        private void txtRsocialMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.SoloLetras(e);
        }



        //private void Search_If()
        //{
            /*
             * por temas de eficiencia, en la busqueda, se da prioridad 
             * a obtener el texto directamente de las cajas sin un 
             * intermediario
             */

            //if (txtNombreMenu.Text != "")//NombreContacto !=""
            //{
            //    dataGridView1.DataSource= ObjBu.FiltroOne(txtNombreMenu.Text);
            //}

            //if (txtNombreMenu.Text != "" && txtRsocialMenu.Text!="")
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroOneTwo(
            //        txtNombreMenu.Text,
            //        txtRsocialMenu.Text);
            //}

            //if (txtNombreMenu.Text != "" && txtRsocialMenu.Text != "" && itemSector != 0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroOneThree(txtNombreMenu.Text,
            //        txtRsocialMenu.Text,
            //        itemSector);

            //}

            //if (txtNombreMenu.Text != "" && txtRsocialMenu.Text != "" 
            //    && itemSector != 0 && itemPais !=0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroOneFour(txtNombreMenu.Text,
            //        txtRsocialMenu.Text,
            //        itemSector,
            //        itemPais);
            //    MessageBox.Show(" pasando");

            //}

            //if (txtNombreMenu.Text != "" && txtRsocialMenu.Text != ""
            //    && itemSector != 0 && itemPais != 0 && itemCity !=0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroOneFive(txtNombreMenu.Text,
            //        txtRsocialMenu.Text,
            //        itemSector,
            //        itemCity,
            //        itemPais);

            //}

            

            //if (itemSector != 0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroThree(itemSector);
            //}

            //if (itemPais != 0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroFour(itemPais);

            //}

            //if (itemPais != 0 && itemCity !=0)
            //{
            //    dataGridView1.DataSource = ObjBu.FiltroFourFive(itemPais,itemCity);
            //    //MessageBox.Show(itemCity.ToString() + " pasando");

            //}
        //}

        int contador=0;
        private void Search_If()
        {
            contador =uno + dos +cinco + nueve+ once;
            //label2.Text = contador.ToString();  desechar
            ////  pruebas
            //lblSocial.Text = txtRsocialMenu.Text;
            //lblsector.Text = itemSector.ToString();
            //lblpais.Text = itemPais.ToString();
            //lblciudad.Text = itemCity.ToString();
            //

            switch (contador)
            {
                case (1):
                    dataGridView1.DataSource = ObjBu.FiltroOne(txtNombreMenu.Text);
                    ocultarCamposDGV();
                    //contador = 0;
                    break;
                case (3):
                    dataGridView1.DataSource = ObjBu.FiltroOneTwo(
                    txtNombreMenu.Text,
                    txtRsocialMenu.Text);
                    break;
                case (8):
                    dataGridView1.DataSource = ObjBu.FiltroOneThree(txtNombreMenu.Text,
                    txtRsocialMenu.Text,
                    itemSector);
                    //----
                    //dataGridView1.DataSource = ObjBu.FiltroOneFive2(txtNombreMenu.Text,
                    //txtRsocialMenu.Text,
                    //itemSector,
                    //0,0
                    ///*itemCity,
                    //itemPais*/);
                    break;
                case (17):
                    dataGridView1.DataSource = ObjBu.FiltroOneFour(txtNombreMenu.Text,
                    txtRsocialMenu.Text,
                    itemSector,
                    itemPais);
                    break;
                case (28):
                    dataGridView1.DataSource = ObjBu.FiltroOneFive(txtNombreMenu.Text,
                    txtRsocialMenu.Text,
                    itemSector,
                    itemCity,
                    itemPais);
                    break;
                case (2):
                    dataGridView1.DataSource = ObjBu.FiltroTwo(
                    txtRsocialMenu.Text);
                    ocultarCamposDGV(); //  ----
                    break;
                case (7):
                    dataGridView1.DataSource = ObjBu.FiltroTwoThree(
                    txtRsocialMenu.Text,
                    itemSector);
                    break;
                case (16):
                    dataGridView1.DataSource = ObjBu.FiltroTwoFour(
                    txtRsocialMenu.Text,
                    itemSector,
                    itemPais);
                    break;
                case (27):
                    dataGridView1.DataSource = ObjBu.FiltroTwoFive(
                    txtRsocialMenu.Text,
                    itemSector,
                    itemCity,
                    itemPais);
                    break;
                case (5):
                    dataGridView1.DataSource = ObjBu.FiltroThree(itemSector);
                    ocultarCamposDGV(); //  ----
                    break;
                case (14):
                    dataGridView1.DataSource = ObjBu.FiltroThreeFour(
                    itemSector,
                    itemPais);
                    break;
                case (25):
                    dataGridView1.DataSource = ObjBu.FiltroThreeFive(
                    itemSector,
                    itemCity,
                    itemPais);
                    break;
                case (9):
                    dataGridView1.DataSource = ObjBu.FiltroFour(itemPais);
                    ocultarCamposDGV(); //  ----
                    break;
                case (20):
                    dataGridView1.DataSource = ObjBu.FiltroFourFive(itemPais, itemCity);
                    break;
                //                EXTRA                                  EXTRA
                case (6):
                    dataGridView1.DataSource = ObjBu.FiltroThreeOne(
                    txtNombreMenu.Text,
                    itemSector);
                    ocultarCamposDGV(); //  ----
                    //lblcategoria.Text = contador.ToString();
                    break;
                case (15):
                    dataGridView1.DataSource = ObjBu.FiltroFourOne(
                    txtNombreMenu.Text,
                    itemSector,
                    itemPais);
                    break;
                case (26):
                    dataGridView1.DataSource = ObjBu.FiltroFiveOne(
                    txtNombreMenu.Text,
                    itemSector,
                    itemCity,
                    itemPais);
                    break;
                case (12):
                    dataGridView1.DataSource = ObjBu.FiltroOneTFour(txtNombreMenu.Text,
                    txtRsocialMenu.Text,
                    itemPais);
                    break;
                case (23):
                    dataGridView1.DataSource = ObjBu.FiltroOneTFive(txtNombreMenu.Text,
                    txtRsocialMenu.Text,
                    itemCity,
                    itemPais);
                    break;
                case (11):
                    dataGridView1.DataSource = ObjBu.FiltroFourTwo(
                    txtRsocialMenu.Text,
                    itemPais);
                    break;
                case (22):
                    dataGridView1.DataSource = ObjBu.FiltroFiveTwo(
                    txtRsocialMenu.Text,
                    itemCity,
                    itemPais);
                    break;

                case (10):
                    dataGridView1.DataSource = ObjBu.FiltroOFive(
                    txtNombreMenu.Text,
                    itemPais);
                    //MessageBox.Show(" pasando 10");

                    break;
                case (21):
                    dataGridView1.DataSource = ObjBu.FiltroOFive1(
                    txtNombreMenu.Text,
                    itemCity,
                    itemPais);
                    //MessageBox.Show(" pasando 21");
                    break;



            }



        }

        // NOTA IMPORTNTE
        /*
         *  en los store procedure, era innecesario usar
         *  LIKE para las consultas, solo serviría para las cajas de text
         *  ya que con los cbox uso la pk.
         *      CORREGIR LOS SP, QUITARLES EL LIKE :(
         */


        /*
         --	EXTRAS  //////     >continuar corrigiendo y añadir esto,  falta completar los filtros.

  	create proc sp_filtroFiveOne
@nombre varchar(35),
@sector tinyint,
@ciudad tinyint,
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Nombre like '%'+RTRIM(@nombre)+'%' and
 c.id_sector= @sector  and
 c.id_ubicacion =@ciudad and 
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre

  --////////////

    	create proc sp_filtroFourOne
@nombre varchar(35),
@sector tinyint,
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Nombre like '%'+RTRIM(@nombre)+'%' and
 c.id_sector= @sector  and
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre

  --////////////

      	create proc sp_filtroThreeOne
@nombre varchar(35),
@sector tinyint,
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Nombre like '%'+RTRIM(@nombre)+'%' and
 c.id_sector= @sector ) and
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre

  --////////////////




   create proc sp_filtroFiveTwo
@r_social varchar(20),
@ciudad tinyint,
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Razón_Social like '%'+RTRIM(@r_social)+'%' and
 c.id_ubicacion =@ciudad and 
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre

  --////////////

  create proc sp_filtroFourTwo
@r_social varchar(20),
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Razón_Social like '%'+RTRIM(@r_social)+'%' and
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre


        --//////////////


 	create proc sp_filtroOneTFive
@nombre varchar(35),
@r_social varchar(20),
@ciudad tinyint,
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Nombre like '%'+RTRIM(@nombre)+'%' and
 c.Razón_Social like '%'+RTRIM(@r_social)+'%' and
 c.id_ubicacion =@ciudad and 
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre;

        --//////////////

   	create proc sp_filtroOneTFour
@nombre varchar(35),
@r_social varchar(20),
@pais tinyint,    
@id_categoria bit
 as 
 select c.Nombre, c.Razón_Social,s.nombre_sector as Sector,c.Correo,
 c.Telefono as Teléfono,ci.NCiudad as Ciudad,p.Npais as País
 from contacto as c,sector as s, Ciudad as ci, Pais as p --			 from 
 where 
 (c.Nombre like '%'+RTRIM(@nombre)+'%' and
 c.Razón_Social like '%'+RTRIM(@r_social)+'%' and
 p.id = @pais) and 
 (c.id_sector=s.id and c.id_ubicacion=ci.id and ci.id_pais=p.id) and  --default
 c.id_categoria=@id_categoria 
  order by c.Nombre;


         */


    }
}
