using DSI.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI.Negocio
{
    public class ClsLogin
    {
        public bool BuscarUsuario(string usuario, string pass)
        {
            // 8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918
            string passE = ClsEncrytp.GetSHA256(pass);
            using (DSIEntities1 BD = new DSIEntities1())
            {
                var busqueda = (from l in BD.Usuarios
                                where l.CC == usuario && l.pass == passE
                                select l).FirstOrDefault();
                if (busqueda != null)
                {
                    return true;
                }
                else
                    return false;
                
            }
            

        }




    }



}
