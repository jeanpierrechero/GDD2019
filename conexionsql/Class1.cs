using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace conexionsql
{
    public class utilidades
    {
        public static DataSet ejecutar(string instruccion)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-EV1UF1N\\SQLSERVER2012;Initial Catalog=GD2C2019;User ID=gd;Password=gd2019");
            conexion.Open();
            DataSet a = new DataSet();
            SqlDataAdapter m = new SqlDataAdapter(instruccion, conexion);
            m.Fill(a);
            conexion.Close();
            return a;

        }
    }
}
