using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI.Datos;

namespace DSI.Negocio
{
    public class ClsDocumentos
    {


        public List<Documentos> consultaDoc()
        {
            using (DSIEntities1 db=new DSIEntities1())
            {
                var doc = (from l in db.Documentos
                           where l.id_contacto== Clscontacto.idContanto
                           select l).ToList();
                return doc;
            }
        }

        public void InsertDocu(string nameD,string ruta,string obsr,int idContacto)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_insertDocu(nameD,ruta,obsr,idContacto);
            }
        }

        public void DeleteDoc(Int16 idDc)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_deleteDocu(idDc);
            }
        }
        
    
    }
}
