using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Models
{
    public class Cliente : BaseData
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string ciudad { get; set; }
        public string codigo_postal { get; set; }

        public Cliente(DataRow row) {
            Row = row;

            id = GetValue<int>("cliente_id");
            nombre = GetValue<string>("cliente_nombre");
            apellido = GetValue<string>("cliente_apellido");
            dni = GetValue<string>("cliente_dni");
            mail = GetValue<string>("cliente_mail");
            telefono = GetValue<string>("cliente_telefono");
            direccion = GetValue<string>("cliente_direccion");
            fecha_nacimiento = (DateTime) row["fecha_nacimiento"];
            ciudad = GetValue<string>("ciudad");
            codigo_postal = GetValue<string>("codigo_postal");
        }
    }
}
