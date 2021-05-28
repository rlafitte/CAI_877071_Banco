using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BancoEntidades.Entidades
{
    [DataContract]
    public class Cuenta
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "nroCuenta")]
        public int NroCuenta { get; set; }

        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }

        [DataMember(Name = "saldo")]
        public float Saldo { get; set; }
        [DataMember(Name = "fechaApertura")]
        public DateTime FechaApertura { get; set; }
        [DataMember(Name = "fechaModificacion")]
        public DateTime FechaModificacion { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "idCliente")]
        public int idCliente { get; set; }


        public override string ToString()
        {
            return string.Format("id {0}, NroCuenta: {1}, Saldo: ${2}.-", this.id, this.NroCuenta, this.Saldo);
        }
    }
}
