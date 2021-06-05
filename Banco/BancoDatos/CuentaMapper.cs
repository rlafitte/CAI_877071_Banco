using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using BancoDatos;
using BancoEntidades.Entidades;

namespace BancoDatos
{
    public class CuentaMapper
    {
        public Cuenta Traer(int idCliente)
        {
            string json2 = WebHelper.Get("api/v1/cuenta/" + idCliente.ToString());
            Cuenta resultado = Map(json2);
            return resultado;
        }

        private Cuenta Map(string json2)
        {
            Cuenta _c = JsonConvert.DeserializeObject<Cuenta>(json2);
            return _c;

        }
    }
}
