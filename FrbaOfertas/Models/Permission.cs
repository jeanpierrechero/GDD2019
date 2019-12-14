using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexionsql;
using System.Data;

namespace FrbaOfertas.Models
{
    class Permission : BaseData
    {
        public Permission() { 
        }

        public static Boolean hasPermission(int rol_id, string funcionalidad) {

            string a = string.Format("select CRISPI.hasPermission ('{0}','{1}')",rol_id,funcionalidad);
            DataSet ds = utilidades.ejecutar(a);
            int valor = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            Boolean _bool = valor == 1;

            return _bool;
        }
    }
}
