using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI.Datos;

namespace DSI.Negocio
{
    public class ClsSector
    {
        public IList TraerSectores()
        {
            using (DSIEntities1 db= new DSIEntities1())
            {
                var bsector = (from s in db.sector
                               select s).ToList();
                return bsector;
            }
            
        }

        public void InsertSector(String sector)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_insertSector(sector);
                //return bsector;
            }
        }

        public void UpdateSector(int id,String sector)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_updateSector(id, sector);
            }
        }
    }
}
