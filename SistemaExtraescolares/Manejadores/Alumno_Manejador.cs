using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaExtraescolares
{
    class Alumno_Manejador
    {
        public Alumno[] GetList()
        {
            Alumno[] Alumnos = new Alumno[0];
            String ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            try
            {
                Connection.Open();
                String Query = "select * from Alumnos;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                using (var DataReader = Command.ExecuteReader())
                {
                    List<Alumno> Lista = new List<Alumno>();
                    Alumno Alum;
                    while (DataReader.Read())
                    {
                        Alum = new Alumno();
                        Alum.IDAlumno = Convert.ToInt32(DataReader["IDAlumno"]);
                        Alum.NumeroDeControl = DataReader["NumeroDeControl"].ToString();
                        Alum.Nombre = DataReader["Nombre"].ToString();
                        Alum.Apellidos = DataReader["Apellidos"].ToString();
                        Alum.Edad = Convert.ToInt32(DataReader["Edad"]);
                        Alum.Sexo = Convert.ToChar(DataReader["Sexo"]);
                        Alum.Semestre = Convert.ToInt32(DataReader["Semestre"]);
                        Alum.Carrera = DataReader["Carrera"].ToString();
                        Alum.Email = DataReader["Email"].ToString();
                        Alum.Telefono = DataReader["Telefono"].ToString();
                        Alum.IDUsuario = Convert.ToInt32(DataReader["IDUsuario"]);
                        Lista.Add(Alum);
                    }
                    Alumnos = Lista.ToArray();
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Connection.Close();
            }
            return Alumnos;
        }
    }
}
