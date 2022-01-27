﻿using System;
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
            using (DSIEntities1 bd = new DSIEntities1())
            {
                return  bd.sp_selectUsuarios().ToList();
            }
        }

        public void insertUsuario(string name, string cc, string pass, bool rol, bool estado)
        {
            using (DSIEntities1 bd= new DSIEntities1())
            {
                bd.sp_createUsuario(name, cc, pass, rol, estado);
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
                query.pass = pass;
                bd.SaveChanges();
                MessageBox.Show("updateUsuarioIII(string pass)");
            }
        }

        public void updateUsuarioIV( string name, string cc, string pass)
        {
            using (DSIEntities1 bd = new DSIEntities1())
            {
                bd.sp_updateUsuario(idUsuario , name, cc, pass);
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
    }

    public class Usuario2//     para crear una lista e iterar un datagridview
    {
        public string idUsuario;
        public string estado;
    }


}
