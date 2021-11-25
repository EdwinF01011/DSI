using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using DSI.Datos;


namespace DSI.Negocio
{
    public class ClsContactosCrud
    {
        //public IList LeerContacto()
        //{
        //    using (DSIEntities1 BD = new DSIEntities1())
        //    {
        //        //var busqueda = (from c in BD.contacto
        //        //                 select new {Nombre=c.Nombre,
        //        //                     Razón_Social = c.Razón_Social,
        //        //                 Sector=c.sector,
        //        //                 Correo=c.Correo,   
        //        //                 Teléfono=c.Telefono}).ToList();
        //        ////Falta el pais y ciudad, hacerlo por proc-almacenado
        //        //return busqueda;//espere 
        //    }

        //    //using (DSIEntities1 BD =new DSIEntities1())
        //    //{
        //    //    var busqueda = (from c in BD.contacto
        //    //                    select c).ToList();
        //    //}

        //}
        public IList ReadContacto()
        {
            bool categoriaContact = ClsUsuario.number_categoria;

            using (DSIEntities1 BD = new DSIEntities1())
            {
                var busqueda = BD.sp_consultaContacto2(categoriaContact).ToList();
                
                return busqueda;
            }
            
        }

    }
}
