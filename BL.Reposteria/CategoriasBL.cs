using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class CategoriasBL
    {
        Contexto _contexto;
        public BindingList<CategoriaBL> ListaCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListaCategorias = new BindingList<CategoriaBL>();
        }

        public BindingList<CategoriaBL> ObtenerCategorias()
        {
            _contexto.Categorias.Load();
            ListaCategorias = _contexto.Categorias.Local.ToBindingList();

            return ListaCategorias;
        }
    }

    public class CategoriaBL
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
