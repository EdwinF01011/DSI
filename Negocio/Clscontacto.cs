using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI.Datos;

namespace DSI.Negocio
{
    public class Clscontacto
    {
        public static Int16 idContanto { get; set; }
        //public static string Razón_Social { get; set; }


        //int id { get; set; }
        //string Nombre { get; set; }
        //string NIT { get; set; }
        //string RazSocial { get; set; }
        //string Telefono { get; set; }
        //string Correo { get; set; }
        //string Direccion { get; set; }
        //string Descripcion { get; set; }
        //string Ubicacion { get; set; }

        //bool id_estado { get; set; }

        //string Pais { get; set; }
        //bool id_categoria { get; set; }
        //string ruta_carpeta { get; set; }// no usar este, todavía

        //estas no se están usando, igualmente dejarlas
        //public static string id_sector { get; set; }
        //public static string id_ubicacion { get; set; }
        //public static string id_ubicacionPais { get; set; }

        public bool verifyNit(string nit)// verificar si yá existe un contacto con ese NIT
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var reques = (from l in bd.contacto
                              where l.NIT == nit && l.id_categoria== ClsUsuario.number_categoria
                              select l).FirstOrDefault();
                if(reques != null)
                {
                    return true;
                }else
                    return false;
            }
        }


        public void InsertContacto(
            string Nombre,
            string NIT,
            string RazSocial,
            string Telefono,
            string Correo,
            string Direccion,
            string Descripcion,
            Byte id_sector,
            Byte Ubicacion,
            bool id_estado)
        {
            bool x= ClsUsuario.number_categoria;// usar

            
            using (DSIEntities1 bd =new DSIEntities1())
            {
                bd.sp_insertContacto(
                     Nombre,
                     RazSocial,
                     NIT,
                     Telefono,
                     Direccion,
                     Correo,
                     Descripcion,
                     id_sector,
                     Ubicacion,
                     ClsUsuario.number_categoria,
                    id_estado
                    );
            }
        }

        public void UpdateContacto(
            int id,
            string Nombre,
            string NIT,
            string RazSocial,
            string Telefono,
            string Correo,
            string Direccion,
            string Descripcion,
            Byte id_sector,
            Byte Ubicacion,
            bool id_estado
            )
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                bd.sp_updateContacto(
                    id,
                    Nombre,
                     RazSocial,
                     NIT,
                     Telefono,
                     Direccion,
                     Correo,
                     Descripcion,
                     id_sector,
                     Ubicacion,
                     ClsUsuario.number_categoria,
                    id_estado
                    );
            }
        }

    }


}
