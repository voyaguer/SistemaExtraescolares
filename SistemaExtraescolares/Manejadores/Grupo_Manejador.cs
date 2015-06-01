using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    class Grupo_Manejador
    {
        private String ConnectionString;
        private SqlConnection Connection;

        public Grupo_Manejador()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        public Grupo[] GetList()
        {
            Grupo[] Grupos = new Grupo[0];
            try
            {
                Connection.Open();
                String Query = "select * from Grupos;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                using (var DataReader = Command.ExecuteReader())
                {
                    List<Grupo> Lista = new List<Grupo>();
                    Grupo Grup;
                    while (DataReader.Read())
                    {
                        Grup = new Grupo();
                        Grup.IDGrupo = Convert.ToInt32(DataReader["IDGrupo"]);
                        Grup.IDActividad = Convert.ToInt32(DataReader["IDActividad"]);
                        Grup.CicloEscolar_Anho = Convert.ToInt32(DataReader["CicloEscolar_Anho"]);
                        Grup.CicloEscolar_MesPrimero = Convert.ToInt32(DataReader["CicloEscolar_MesPrimero"]);
                        Grup.CicloEscolar_MesUltimo = Convert.ToInt32(DataReader["CicloEscolar_MesUltimo"]);
                        Grup.Capacidad = Convert.ToInt32(DataReader["Capacidad"]);
                        Grup.Horario = DataReader["Horario"].ToString();
                        Lista.Add(Grup);
                    }
                    Grupos = Lista.ToArray<Grupo>();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return Grupos;
        }
        public Grupo[] GetList(Int32 IDDocente)
        {
            Grupo[] Grupos = new Grupo[0];
            try
            {
                Connection.Open();
                String Query = "select * from Grupos where IDDocente=@_IDocente;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_IDocente", IDDocente);
                
                using (var DataReader = Command.ExecuteReader())
                {
                    List<Grupo> Lista = new List<Grupo>();
                    Grupo Grup;
                    while (DataReader.Read())
                    {
                        Grup = new Grupo();
                        Grup.IDGrupo = Convert.ToInt32(DataReader["IDGrupo"]);
                        Grup.IDActividad = Convert.ToInt32(DataReader["IDActividad"]);
                        Grup.CicloEscolar_Anho = Convert.ToInt32(DataReader["CicloEscolar_Anho"]);
                        Grup.CicloEscolar_MesPrimero = Convert.ToInt32(DataReader["CicloEscolar_MesPrimero"]);
                        Grup.CicloEscolar_MesUltimo = Convert.ToInt32(DataReader["CicloEscolar_MesUltimo"]);
                        Grup.Capacidad = Convert.ToInt32(DataReader["Capacidad"]);
                        Grup.Horario = DataReader["Horario"].ToString();
                        Lista.Add(Grup);
                    }
                    Grupos = Lista.ToArray<Grupo>();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return Grupos;
        }
        public void Agregar_Grupo(Grupo nuevo_Grupo)
        {
            try
            {
                Connection.Open();
                String Query = "insert into Grupos(IDActividad, CicloEscolar_Anho, CicloEscolar_MesPrimero, CicloEscolar_MesUltimo, Capacidad, Horario) " +
                    "values (@_IDActividad, @_CicloEscolar_Anho, @_CicloEscolar_MesPrimero, @_CicloEscolar_MesUltimo, @_Capacidad, @_Horario);";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_IDActividad", nuevo_Grupo.IDActividad);
                Command.Parameters.AddWithValue("@_CicloEscolar_Anho", nuevo_Grupo.CicloEscolar_Anho);
                Command.Parameters.AddWithValue("@_CicloEscolar_MesPrimero", nuevo_Grupo.CicloEscolar_MesPrimero);
                Command.Parameters.AddWithValue("@_CicloEscolar_MesUltimo", nuevo_Grupo.CicloEscolar_MesUltimo);
                Command.Parameters.AddWithValue("@_Capacidad", nuevo_Grupo.Capacidad);
                Command.Parameters.AddWithValue("@_Horario", nuevo_Grupo.Horario);

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Write(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public void AsignarListaDeAlumnos(ref Grupo[] Grupos)
        {
            try
            {
                Connection.Open();
                String Query = "select IDGrupo, IDAlumno from Listas;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                using (var DataReader = Command.ExecuteReader())
                {
                    while (DataReader.Read())
                    {
                        Grupos.Single(Gru => Gru.IDGrupo == Convert.ToInt32(DataReader["IDGrupo"])).ListaAlumnos.Add(Convert.ToInt32(DataReader["IDAlumno"]));
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Connection.Close();
            }
        }
        public void EliminarGrupo(Int32 ID_Grupo_A_Eliminar){
            try
            {
                Connection.Open();
                String Query = "delete from Grupos where IDGrupo = @_IDGrupo;";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@_IDGrupo", ID_Grupo_A_Eliminar);
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.Write(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}