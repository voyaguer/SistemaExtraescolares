﻿using System;
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

        public void Agregar_Alumno(Alumno Nuevo_Alumno)
        {
            try
            {
                Connection.Open();
                String Query = "insert into Alumnos(NumeroDeControl,Nombre, Apellidos, Edad, Sexo,Semestre, Carrera, Email, Telefono,IDUsuario) " +
                    "values (@_NumeroDeControl, @_Nombre, @_Apellidos, @_Edad, @_Sexo,@_Semestre,@_Carrera, @_Email, @_Telefono,@_IDUsuario);";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_NumeroDeControl", Nuevo_Alumno.NumeroDeControl);
                Command.Parameters.AddWithValue("@_Nombre", Nuevo_Alumno.Nombre);
                Command.Parameters.AddWithValue("@_Apellidos", Nuevo_Alumno.Apellidos);
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
    }
}
