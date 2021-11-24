using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Reposteria
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Chocolate";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Frutas";
            contexto.Categorias.Add(categoria2);


            var tipo1 = new Tipo();
            tipo1.Descripcion = "Pasteles";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Budines";
            contexto.Tipos.Add(tipo2);

            var sexo1 = new Sexo();
            sexo1.Sexos = "Femenino";
            contexto.Sexos.Add(sexo1);

            var sexo2 = new Sexo();
            sexo2.Sexos = "Masculino";
            contexto.Sexos.Add(sexo2);

            var localidad1 = new Localidad();
            localidad1.Localidades = "San Pedro Sula- Cortes";
            contexto.Localidades.Add(localidad1);

            var localidad2 = new Localidad();
            localidad2.Localidades = "Tegucigalpa- Francisco Morazan";
            contexto.Localidades.Add(localidad2);

            base.Seed(contexto);
        }
    }
}
