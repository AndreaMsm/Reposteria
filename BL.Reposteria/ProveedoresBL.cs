using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
   public class ProveedoresBL
    {
        Contexto _contexto;
       public BindingList<Proveedor> ListaProveedores { get; set; }

        public ProveedoresBL()
        {
            _contexto = new Contexto();
            ListaProveedores = new BindingList<Proveedor>();          
        }

        public BindingList<Proveedor> ObtenerProveedores()
        {
            _contexto.Proveedores.Load();
            ListaProveedores = _contexto.Proveedores.Local.ToBindingList();

            return ListaProveedores;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProveedor(Proveedor proveedor)
        {
            var resultado = Validar(proveedor);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProveedor()
        {
            var nuevoProveedor = new Proveedor();
            ListaProveedores.Add(nuevoProveedor);
        }

        public bool EliminarProveedor(int id)
        {
            foreach (var proveedor in ListaProveedores)
            {
                if (proveedor.Id == id)
                {
                    ListaProveedores.Remove(proveedor);
                    _contexto.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        private Resultado Validar(Proveedor proveedor)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (proveedor == null)
            {
                resultado.Mensaje = "Ingrese un proveedor";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(proveedor.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del proveedor";
                resultado.Exitoso = false;
            }

            if (proveedor.Telefono == "")
            {
                resultado.Mensaje = "Ingrese el telefono del proveedor";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(proveedor.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese la direccion del proveedor";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int LocalidadId { get; set; }
        public Localidad Localidad { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }

        public Proveedor()
        {
            Activo = true;
            FechaEntrega = DateTime.Now;
        }
    }
}
