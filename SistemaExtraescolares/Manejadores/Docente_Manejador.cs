using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    class Docente_Manejador
    {
        private String ConnectionString;
        private SqlConnection Connection;

        public Docente_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        public Docente[] GetList()
        {
            Docente[] Docentes = new Docente[0];
            try
            {
                Connection.Open();
                String Query = "select * from Docentes;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                using (var DataReader = Command.ExecuteReader())
                {
                    List<Docente> Lista = new List<Docente>();
                    Docente teacher;
                    while (DataReader.Read())
                    {
                        teacher = new Docente();
                        teacher.IDDocente = Convert.ToInt32(DataReader["IDDocente"]);
                        teacher.Nombre = DataReader["Nombre"].ToString();
                        teacher.ApellidoP = DataReader["ApellidoP"].ToString();
                        teacher.ApellidoM = DataReader["ApellidoM"].ToString();
                        teacher.Edad = Convert.ToInt32(DataReader["Edad"]);
                        teacher.Sexo = Convert.ToChar(DataReader["Sexo"]);
                        teacher.Email = DataReader["Email"].ToString();
                        teacher.Telefono = DataReader["Telefono"].ToString();
                        teacher.IDUsuario = Convert.ToInt32(DataReader["IDUsuario"]);
                        Lista.Add(teacher);
                    }
                    Docentes = Lista.ToArray<Docente>();
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Connection.Close();
            }
            return Docentes;
        }

        public void Agregar_Docente(Docente Nuevo_Docente)
        {
            try
            {
                Connection.Open();
                String Query = "insert into Docentes(Nombre, ApellidoP, ApellidoM, Edad, Sexo, Email, Telefono) " +
                    "values (@_Nombre, @_ApellidoP, @ApellidoM, @_Edad, @_Sexo, @_Email, @_Telefono);";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_Nombre", Nuevo_Docente.Nombre);
                Command.Parameters.AddWithValue("@_ApellidoP", Nuevo_Docente.ApellidoP);
                Command.Parameters.AddWithValue("@_ApellidoM", Nuevo_Docente.ApellidoM);
                Command.Parameters.AddWithValue("@_Edad", Nuevo_Docente.Edad);
                Command.Parameters.AddWithValue("@_Sexo", Nuevo_Docente.Sexo);
                Command.Parameters.AddWithValue("@_Email", Nuevo_Docente.Email);
                Command.Parameters.AddWithValue("@_Telefono", Nuevo_Docente.Telefono);
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

        public void Borrar_Docente(Int32 Index)
        {
            try
            {
                Connection.Open();
                String Query = "delete from Docentes where IDDocente = @IDDocente;";
                SqlParameter Data = new SqlParameter("@IDDocente", Index);
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
