using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class LocalidadesBL
    {
        Contexto _contexto;
        public BindingList<Localidad> ListaLocalidades { get; set; }

        public LocalidadesBL()
        {
            _contexto = new Contexto();
            ListaLocalidades = new BindingList<Localidad>();
        }

        public BindingList<Localidad> ObtenerLocalidades()
        {
            _contexto.Localidades.Load();
            ListaLocalidades = _contexto.Localidades.Local.ToBindingList();

            return ListaLocalidades;
        }
    }

    public class Localidad
    {
        public int Id { get; set; }
        public string Localidades { get; set; }
    }
}
