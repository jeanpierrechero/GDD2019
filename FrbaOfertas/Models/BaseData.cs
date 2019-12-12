using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Models
{
    public abstract class BaseData
    {
        public DataRow Row { get; set; }

        public T GetValue<T>(string name)
        {
            try
            {
                return Row[name] != DBNull.Value ? (T)Row[name] : default(T);
            }
            catch (Exception)
            {
                return default(T);
            }

        }

    }
}