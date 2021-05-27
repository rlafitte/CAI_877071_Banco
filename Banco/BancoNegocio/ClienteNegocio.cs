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
    }
}
