using BancoDatos;
using BancoEntidades.Entidades;
using BancoEntidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNegocio
{
    public class ClienteNegocio
    {
        private ClienteMapper _clMap;
        private List<Cliente> _lstClientes;
        private List<Cuenta> _lstCuentas;
        public ClienteNegocio()
        {
            _clMap = new ClienteMapper();
            _lstClientes = new List<Cliente>();
        }
        public List<Cliente> Traer()
        {
            try
            {
                _lstClientes = _clMap.TraerTodos();
                return _lstClientes;
            }catch (Exception ex)
            {
                throw new Exception("Error al recuperar clientes.");
            }
        }

        public TransactionResult Agregar(Cliente c)
        {
           
            return _clMap.Insertar(c);
        }

        public List<Cuenta> TraerCuentas()
        {
            try
            {
                _lstCuentas = _clMap.TraerCuentasVeterinaria();
                return _lstCuentas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar clientes.");
            }
        }

        public void AgregarCuenta(Cuenta i)
        {
            _clMap.InsertarCuenta(i);
        }

        public object TraerCuentaPorID(string s)
        {
            try
            {
                _lstCuentas = _clMap.TraerCuentaVeterinaria_ID(s);
                return _lstCuentas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar clientes.");
            }
        }
    }
}
