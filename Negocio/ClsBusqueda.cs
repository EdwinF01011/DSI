using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DSI.Datos;
using DSI.Datos;

namespace DSI.Negocio
{
    public class ClsBusqueda
    {
        Clscontacto ObjC = new Clscontacto();
        //public bool categoriaContact = ClsUsuario.number_categoria;


        public IList<Pais> BuscarPais()// usado en FrmUbicacion.cs y Frmbusqueda.cs
        {
            using (DSIEntities1 BD =new DSIEntities1())
            {
                var Bpais = (from l in BD.Pais
                             select l).ToList();
                return Bpais;
            }
        }

        public IList<Ciudad> BuscarCiudad(Byte itemPais)//  usado en FrmBusqueda.cs
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var BCity= (from l in BD.Ciudad
                            where l.id_pais==itemPais
                             select l).ToList();
                return BCity;
            }
        }

        public IList BuscarCiudad()//   usado en FrmUbicacion.cs
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var BLugares =BD.sp_buscarLugares().ToList();
                return BLugares;
            }
        }

        public IList<sector> BuscarSector()
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var Bsector = (from l in BD.sector
                             select l).ToList();
                return Bsector;
            }
        }

        //public IList BuscarFiltro()
        //{
        //    bool categoriaContact = ClsUsuario.number_categoria;

        //    Clscontacto ObjC = new Clscontacto();
        //    using (DSIEntities1 BD = new DSIEntities1())
        //    {
        //        var Bpais = BD.sp_consultaContactoFiltro(
        //            ObjC.Nombre,
        //            ObjC.Razón_Social,
        //            ObjC.id_sector,
        //            ObjC.id_ubicacion,
        //            ObjC.id_ubicacionPais,
        //            categoriaContact.ToString()
        //            //ObjC.id_ubicacionPais
        //            ).ToList();

        //        return Bpais;
        //    }
        //}





        //             ( ﾉ ﾟｰﾟ)ﾉ  filtros superFiltrados  ＼(ﾟｰﾟ＼)
        //             ( ﾉ ﾟｰﾟ)ﾉ  filtros superFiltrados  ＼(ﾟｰﾟ＼)  
        //             ( ﾉ ﾟｰﾟ)ﾉ  filtros superFiltrados  ＼(ﾟｰﾟ＼)  
        //             ( ﾉ ﾟｰﾟ)ﾉ  filtros superFiltrados  ＼(ﾟｰﾟ＼)  
        //             
        //                      (￣﹃￣)            (￣﹃￣)
        //                                                            

        public IList consultaTodo()                    //       ԅ(¯﹃¯ԅ) todo
        {
            using (DSIEntities1 BD =new DSIEntities1())
            {
                var Busqueda = BD.sp_consultaTodo(
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOne(string name)                    //       ԅ(¯﹃¯ԅ)
        {
            using (DSIEntities1 BD =new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroOne(name,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneTwo(string name,string Rsocial)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroOneTwo(
                    name,
                    Rsocial,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneThree(string name, string Rsocial, Byte itemSector)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroOneThree(
                    name,
                    Rsocial,
                    itemSector.ToString(),
                    ClsUsuario.number_categoria).ToList();
                //MessageBox.Show(categoriaContact.ToString());
                return Busqueda;
            }
        }

        public IList FiltroOneFour(string name, string Rsocial, Byte itemSector,Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroOneFour(
                    name,
                    Rsocial,
                    itemSector.ToString(),
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneFive(string name, string Rsocial, Byte itemSector, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var Busqueda = BD.sp_filtroOneFive(
                    name,
                    Rsocial,
                    itemSector,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneFive2(string name, string Rsocial, Byte itemSector, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                MessageBox.Show("one five 2 " );

                //MessageBox.Show("one five2 " + itemCity.ToString());
                var Busqueda = BD.sp_filtroOneFive(
                    name,
                    Rsocial,
                    itemSector,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        // 2 2 2 2 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        public IList FiltroTwo(string Rsocial)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroTwo(
                    Rsocial,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroTwoThree(string Rsocial, Byte itemSector)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroTwoThree(
                    Rsocial,
                    itemSector.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroTwoFour(string Rsocial, Byte itemSector, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroTwoFour(
                    Rsocial,
                    itemSector.ToString(),
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroTwoFive(string Rsocial, Byte itemSector, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroTwoFive(
                    Rsocial,
                    itemSector,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        // 3 3 3 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        public IList FiltroThree(Byte idSector)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroThree(
                    idSector,
                    ClsUsuario.number_categoria).ToList();     
                return Busqueda;
            }
        }

        public IList FiltroThreeFour(Byte itemSector, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroThreeFour(
                    itemSector.ToString(),
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroThreeFive(Byte itemSector, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroThreeFive(
                    itemSector.ToString(),
                    itemCity.ToString(),
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        // 4 4 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        public IList FiltroFour(Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFour(
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroFourFive(Byte itemPais, Byte itemCity)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFourFive(
                    itemCity.ToString(),
                    itemPais.ToString(),
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }
        //  EXTRAS   EXTRAS  EXTRAS                                  EXTRAS （︶^︶) 

        public IList FiltroFiveOne(string name, Byte itemSector, Byte itemPais, Byte itemCity)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFiveOne(
                    name,
                    itemSector,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroFourOne(string name, Byte itemSector, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFourOne(
                    name,
                    itemSector,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroThreeOne(string name, Byte itemSector)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroThreeOne(
                    name,
                    itemSector,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroFiveTwo(string Rsocial, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFiveTwo(
                    Rsocial,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroFourTwo(string Rsocial, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                //MessageBox.Show(Clscontacto.Nombre);
                var Busqueda = BD.sp_filtroFourTwo(
                    Rsocial,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneTFour(string name, string Rsocial,  Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var Busqueda = BD.sp_filtroOneTFour(
                    name,
                    Rsocial,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

        public IList FiltroOneTFive(string name, string Rsocial, Byte itemCity, Byte itemPais)
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var Busqueda = BD.sp_filtroOneTFive(
                    name,
                    Rsocial,
                    itemCity,
                    itemPais,
                    ClsUsuario.number_categoria).ToList();
                return Busqueda;
            }
        }

    }
}
