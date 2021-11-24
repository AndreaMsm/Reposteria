using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class SexosBL
    {
        Contexto _contexto;
        public BindingList<Sexo> ListaSexos { get; set; }

        public SexosBL()
        {
            _contexto = new Contexto();
            ListaSexos = new BindingList<Sexo>();
        }

        public BindingList<Sexo> ObtenerSexos()
        {
            _contexto.Sexos.Load();
            ListaSexos = _contexto.Sexos.Local.ToBindingList();

            return ListaSexos;
        }
    }

          

    public class Sexo
    {
        public int Id { get; set; }
        public string Sexos { get; set; }
    }
}
