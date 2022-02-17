using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI.Datos;

namespace DSI.Negocio
{
    public class ClsUsuario
    {
        public static string nameUsuario;
        public static Byte idUsuario;
        public static Byte rolUsuario;//    para los accesos a componentes del sistema.
        public static string categoria_busqueda;//indica qué se va buscar cliente, proveedor 
        public static bool number_categoria;
        public static bool estado;// 0: --> ; 1: --x;

        public IList selectUsuario()
        {
            using (DSIEntities1 bd = new DSIEntities1())// llena el dgview de FrmConfiguration/Usuarios
            {
                return  bd.sp_selectUsuarios().Where(x=>x.id!=idUsuario).ToList();
            }
        }

        public void insertUsuario(string name, string cc, string pass, bool rol, bool estado, string mail)
        {
            using (DSIEntities1 bd= new DSIEntities1())
            {
                bd.sp_createUsuario(name, cc, pass, rol, estado,mail);
            }
        }

        public void updateUsuario(string name)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                //bd.sp_updateUsuario(idUsuario, name, cc, pass);
                var query = (from l in bd.Usuarios
                             where l.id == idUsuario
                             select l).FirstOrDefault();
                query.Nombre = name;
                bd.SaveChanges();
            }
            MessageBox.Show("updateUsuario(string name)");
        }

        public void updateUsuarioII(string cc)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                //bd.sp_updateUsuario(idUsuario, name, cc, pass);
                var query = (from l in bd.Usuarios
                                where l.id == idUsuario
                                select l).FirstOrDefault();
                query.CC = cc;
                bd.SaveChanges();
                MessageBox.Show("updateUsuarioII(string cc)");
            }
        }

        public void updateUsuarioIII(string pass)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var query = (from l in bd.Usuarios
                             where l.id == idUsuario
                             select l).FirstOrDefault();
                if (query!= null)
                {
                    query.pass = pass;
                    bd.SaveChanges();
                    MessageBox.Show("updateUsuarioIII(string pass)");
                }
                
            }       
        }
        public void updateUsuarioIIIContra(Byte userId,string pass)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var query = (from l in bd.Usuarios
                             where l.id == userId
                             select l).FirstOrDefault();
                if (query != null)
                {
                    query.pass = pass;
                    bd.SaveChanges();
                    MessageBox.Show("updateUsuarioIIIConstra(string pass)");
                }

            }
        }

        public void updateUsuarioIV(string mail)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var query = (from l in bd.Usuarios
                             where l.id == idUsuario
                             select l).FirstOrDefault();
                query.Email = mail;
                bd.SaveChanges();
                MessageBox.Show("updateUsuarioIV(string mail)");
            }
        }

        public void updateUsuarioV( string name, string cc, string pass, string mail)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                //bd.sp_updateUsuario(idUsuario , name, cc, pass);
                bd.sp_updateUsuario2(idUsuario, name, cc, pass, mail);

            }
        }

        public void disableUsuario(string id, string estado)
        {
            Byte idB = Byte.Parse(id);
            bool estadoB = bool.Parse(estado);
            using (DSIEntities1 bd = new DSIEntities1())
            {
                bd.sp_disableUsuario(idB, estadoB);
                    //MessageBox.Show("go go go,  bro");
            }
        }

        public bool verifyUser(string cc)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var verify=bd.Usuarios.Where(x => x.CC == cc).FirstOrDefault();
                if (verify != null)
                {
                    return true;// si existe
                }
                else
                    return false;
            }
        }

        public bool verifyMail(string mail)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                var verify = bd.Usuarios.Where(x => x.Email == mail).FirstOrDefault();
                if (verify != null)
                {
                    return true;// si existe
                }
                else
                    return false;
            }
        }


    }

    public class Usuario2//     para crear una lista e iterar un datagridview
    {
        public string idUsuario;
        public string estado;
    }

    //  demás funciones
    


}
