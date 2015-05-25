using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    class Alumno_Manejador
    {
        String ConnectionString;
        SqlConnection Connection;

        public Alumno_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        public Alumno[] GetList()
        {
            Alumno[] Alumnos = new Alumno[0];
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
                        Alum.ApellidoP = DataReader["ApellidoP"].ToString();
                        Alum.ApellidoM = DataReader["ApellidoM"].ToString();
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

        public void Agregar_Alumno(Alumno Nuevo_Alumno)
        {
            try
            {
                Connection.Open();
                String Query = "insert into Alumnos(NumeroDeControl,Nombre, ApellidoP, ApellidoM, Edad, Sexo,Semestre, Carrera, Email, Telefono,IDUsuario) " +
                    "values (@_NumeroDeControl, @_Nombre, @_ApellidoP, @_ApellidoM, @_Edad, @_Sexo,@_Semestre,@_Carrera, @_Email, @_Telefono,@_IDUsuario);";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_NumeroDeControl", Nuevo_Alumno.NumeroDeControl);
                Command.Parameters.AddWithValue("@_Nombre", Nuevo_Alumno.Nombre);
                Command.Parameters.AddWithValue("@_ApellidoP", Nuevo_Alumno.ApellidoP);
                Command.Parameters.AddWithValue("@_ApellidoM", Nuevo_Alumno.ApellidoM);
                Command.Parameters.AddWithValue("@_Edad", Nuevo_Alumno.Edad);
                Command.Parameters.AddWithValue("@_Sexo", Nuevo_Alumno.Sexo);
                Command.Parameters.AddWithValue("@_Semestre", Nuevo_Alumno.Semestre);
                Command.Parameters.AddWithValue("@_Carrera", Nuevo_Alumno.Carrera);
                Command.Parameters.AddWithValue("@_Email", Nuevo_Alumno.Email);
                Command.Parameters.AddWithValue("@_Telefono", Nuevo_Alumno.Telefono);
                Command.Parameters.AddWithValue("@_IDUsuario", Nuevo_Alumno.IDUsuario);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void Actualizar(Alumno A)
        {
            try
            {
                Connection.Open();
                String Query = "update Alumnos set NumeroDeControl = @NumeroDeControl, Nombre = @Nombre, ApellidoP = @ApellidoP, ApellidoM = @ApellidoM," +
                    "Edad = @Edad, Sexo = @Sexo, Semestre = @Semestre, Carrera = @Carrera, Email = @Email, Telefono = @Telefono where IDAlumno = @IDAlumno;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@NumeroDeControl", A.NumeroDeControl);
                Command.Parameters.AddWithValue("@Nombre", A.Nombre);
                Command.Parameters.AddWithValue("@ApellidoP", A.ApellidoP);
                Command.Parameters.AddWithValue("@ApellidoM", A.ApellidoM);
                Command.Parameters.AddWithValue("@Edad", A.Edad);
                Command.Parameters.AddWithValue("@Sexo", A.Sexo);
                Command.Parameters.AddWithValue("@Semestre", A.Semestre);
                Command.Parameters.AddWithValue("@Carrera", A.Carrera);
                Command.Parameters.AddWithValue("@Email", A.Email);
                Command.Parameters.AddWithValue("@Telefono", A.Telefono);
                Command.Parameters.AddWithValue("@IDAlumno", A.IDAlumno);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                Connection.Open();
                String Query = "delete from Alumnos where IDAlumno = @IDAlumno;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@IDAlumno", id);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
