using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Models
{
    public class Session : BaseData
    {
        public int id { get; set; }
        public string username { get; set; }
        public int rol_id { get; set; }
        public int proveedor_id { get; set; }
        public int cliente_id { get; set; }

        public Session(DataRow row)
        {
            Row = row;

            id = GetValue<int>("id");
            username = GetValue<string>("username");
            rol_id = GetValue<int>("rol_id");
            proveedor_id = GetValue<int>("proveedor_id");
            cliente_id = GetValue<int>("cliente_id");
        }
    }
}
