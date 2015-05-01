using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SistemaExtraescolares
{
    public class Grupo_Manejador
    {
        private String ConnectionString;
        private SqlConnection Connection;

        public Grupo_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        public void Agregar_Grupo(Grupo nuevo_Grupo)
        {
            try
            {
                Connection.Open();
                //String Query = "delete from Actividades where IDActividad = @IDActividad;";
                //SqlParameter Data = new SqlParameter("@IDActividad", Index);
                //SqlCommand Command = new SqlCommand(Query, Connection);
                //Command.Parameters.Add(Data);
                //Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}