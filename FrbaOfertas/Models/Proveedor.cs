using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Models
{
    public class Proveedor : BaseData
    {
        public int id { get; set; }
        public string cuit { get; set; }
        public string razon_social { get; set; }
        public string domicilio { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public string ciudad { get; set; }
        public string rubro { get; set; }

        public Proveedor(DataRow row) {
            Row = row;

            id = GetValue<int>("proveedor_id");
            cuit = GetValue<string>("cuit");
            razon_social = GetValue<string>("razon_social");
            domicilio = GetValue<string>("domicilio");
            mail = GetValue<string>("mail");
            telefono = GetValue<string>("telefono");
            ciudad = GetValue<string>("ciudad");
            rubro = GetValue<string>("rubro");
        }
    }
}
