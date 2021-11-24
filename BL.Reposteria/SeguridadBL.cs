using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public Usuario Autorizar(string nombreUsuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (nombreUsuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }

            return null;
        }
    }


}
    


    public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contrasena { get; set; }
            
        }

    

