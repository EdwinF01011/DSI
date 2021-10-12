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
        string Nombre { get; set; }
        string Razón_Social { get; set; }
        string Telefono { get; set; }
        string Direccion { get; set; }
        string Correo { get; set; }
        string Descripcion { get; set; }
        byte id_sector { get; set; }
        byte id_ubicacion { get; set; }
        bool id_categoria { get; set; }
        bool id_estado { get; set; }
        string ruta_carpeta { get; set; }

    }
}
