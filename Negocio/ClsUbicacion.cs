using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI.Datos;

namespace DSI.Negocio
{
    public class ClsUbicacion
    {
        public void InsertPais(string Npais)
        {
            using (DSIEntities1 db =new DSIEntities1())
            {
                db.sp_insertPais(Npais);
            }
        }

        public void updatePais(Byte id,string Npais)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_updatePais(id,Npais);
            }
        }

        public void InsertCity(string Ncity,Byte idPais)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_insertCiudad(idPais,Ncity);
            }
        }

        public void UpdateCity(string Ncity, Byte id)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                db.sp_updateCiudad(id, Ncity);
            }
        }
        //------------------------------------------------------------------------------------
        public bool verifyPais(string namePais)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                var ver = db.Pais.Where(x => x.Npais == namePais).FirstOrDefault();
                if (ver!=null)
                {
                    return true;// si ya existe un país con este nombre
                }
                else
                {
                    return false;
                }
            }
        }

        public bool verifyCity(string nameCity)
        {
            using (DSIEntities1 db = new DSIEntities1())
            {
                var ver = db.Ciudad.Where(x => x.NCiudad == nameCity).FirstOrDefault();
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
