using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemaExtraescolares
{
    class Actividad_Manejador
    {

        String ConnectionString;
        SqlConnection Connection;

        public Actividad_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        public Actividad[] GetList()
        {
            Actividad[] Actividades = new Actividad[0];
            try
            {
                Connection.Open();
                String Query = "select * from Actividades;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                using (var DataReader = Command.ExecuteReader())
                {
                    List<Actividad> Lista = new List<Actividad>();
                    Actividad Act;
                    while(DataReader.Read())
                    {
                        Act = new Actividad();
                        Act.IDActividad = Convert.ToInt32(DataReader["IDActividad"]);
                        Act.Nombre = DataReader["Nombre"].ToString();
                        Lista.Add(Act);
                    }
                    Actividades = Lista.ToArray<Actividad>();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Connection.Close();
            }
            return Actividades;
        }

        public void Borrar(Int32 Index)
        {
            try
            {
                Connection.Open();
                String Query = "delete from Actividades where IDActividad = @IDActividad;";
                SqlParameter Data = new SqlParameter("@IDActividad", Index);
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.Add(Data);
                Command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                Connection.Close();
            }
        }
    }
}