using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();

        }

        public BindingList<Cliente> ObtenerClientes()
        {
            ListaClientes = new BindingList<Cliente>(
               _contexto.Clientes.OrderBy(o => o.Nombre).ToList()
               );

            return ListaClientes;
            
        }

        public BindingList<Cliente> ObtenerClientes(string buscar)
        {
            var query = _contexto.Clientes
                .Where(p => p.Nombre.ToLower()
                .Contains(buscar.ToLower()) == true)
                .ToList();

            var resultado = new BindingList<Cliente>(query);

            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
          
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente );
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un cliente valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (cliente == null)
            {
                resultado.Mensaje = "Ingrese un cliente";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del cliente";
                resultado.Exitoso = false;
            }

            if (cliente.Telefono == "")
            {
                resultado.Mensaje = "Ingrese el telefono del cliente";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Dirección) == true)
            {
                resultado.Mensaje = "Ingrese la direccion del cliente";
                resultado.Exitoso = false;
            } 

            return resultado;
        }
       
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo  { get; set; }
        public string Telefono { get; set; }
        public string Dirección { get; set; }
        public int SexoId { get; set; }
        public Sexo Sexo { get; set; }
        public bool Activo { get; set; }
    }
}
