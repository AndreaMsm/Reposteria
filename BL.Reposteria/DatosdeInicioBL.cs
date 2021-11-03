using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Reposteria.SeguridadBL;

namespace BL.Reposteria
{
    public class DatosdeInicioBL: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new CategoriaBL();
            categoria1.Descripcion = "Chocolate";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new CategoriaBL();
            categoria2.Descripcion = "Frutas";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new CategoriaBL();
            categoria3.Descripcion = "Queso";
            contexto.Categorias.Add(categoria3);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Pasteles";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Budines";
            contexto.Tipos.Add(tipo2);
            

            base.Seed(contexto);
        }
    }
}
