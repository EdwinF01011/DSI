using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.Negocio
{
    public class Clscontacto
    {
        int id { get; set; }
        //public static string Nombre { get; set; }
        //public static string Razón_Social { get; set; }
        string Telefono { get; set; }
        string Direccion { get; set; }
        string Correo { get; set; }
        string Descripcion { get; set; }
        string Ciudad { get; set; }
        string Pais { get; set; }
        bool id_categoria { get; set; }
        bool id_estado { get; set; }
        string ruta_carpeta { get; set; }// no usar este, todavía

        //estas no se están usando, igualmente dejarlas
        //public static string id_sector { get; set; }
        //public static string id_ubicacion { get; set; }
        //public static string id_ubicacionPais { get; set; }

    }
}
