using BancoEntidades.Entidades;
using BancoEntidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDatos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("cliente");
            List<Cliente> resultado = MapList(json);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }
        private List<Cuenta> MapCuenta(string json)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lst;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Post("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.id.ToString());
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Ape);
            n.Add("direccion", cliente.Direccion);
            n.Add("DNI", cliente.DNI);
            n.Add("fechaNacimiento", "2000-01-01");
            n.Add("usuario", "1");
            return n;
        }

        public List<Cuenta> TraerCuentaVeterinaria_ID(string s)
        {
            string json = WebHelper.Get("cuenta/" + s.ToString());
            List<Cuenta> resultado = MapCuenta(json);
            return resultado;
        }



        public List<Cuenta> TraerCuentasVeterinaria()
        {
            string json = WebHelper.Get("cuenta");
            List<Cuenta> resultado = MapCuenta(json);
            return resultado;
        }

        public TransactionResult InsertarCuenta(Cuenta c)
        {
            NameValueCollection obj = ReverseCuenta(c);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseCuenta(Cuenta cu)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cu.id.ToString());
            n.Add("nroCuenta", cu.NroCuenta.ToString());
            n.Add("descripcion", "877071");
            n.Add("saldo", cu.Saldo.ToString());
            n.Add("fechaApertura", cu.FechaApertura.ToString());
            n.Add("fechaModificacion", "2000-01-01");
            n.Add("activo", cu.Activo.ToString());
            n.Add("idCliente", cu.idCliente.ToString());
            return n;
        }
    }
}
