using System;
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
        public List<contacto> LeerContacto()
        {
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var busqueda = (from c in BD.contacto
                                 select c).ToList();
                return busqueda;//espere
            }

        }
    }
}
