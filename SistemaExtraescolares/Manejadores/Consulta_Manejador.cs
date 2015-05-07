using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SistemaExtraescolares
{
    class Consulta_Manejador
    {
        String ConnectionString;
        SqlConnection Connection;

        public Consulta_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);

        }

        public DataTable Obtener_actividades()
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Actividades ", ConnectionString);
            da.Fill(dtb);
            return (dtb);
        }

        public DataTable Obtener_alumnos()
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Alumnos ", ConnectionString);
            da.Fill(dtb);
            return (dtb);
        }

        public DataTable Obtener_grupos()
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Grupos ", ConnectionString);
            da.Fill(dtb);
            return (dtb);
        }

        public DataTable Obtener_docentes()
        {
            DataTable dtb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Docentes ", ConnectionString);
            da.Fill(dtb);
            return (dtb);
        }
    }
}
