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
            {// obj anónimo xd
                var bsector = (from s in db.sector
                               select new { Id = s.id, Nombre = s.nombre_sector}).OrderBy(s=> s.Nombre).ToList();
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

        public bool verifySector(string nameSector)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                var ver = db.sector.Where(x => x.nombre_sector == nameSector).FirstOrDefault();
                if (ver != null)
                {
                    return true;// si ya existe una ciudad con este nombre
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
