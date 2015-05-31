using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemaExtraescolares
{
    public partial class Form_Alumno : Form
    {
        Alumno[] Alumnos;
        Boolean Alumnos_ConDatos = false;
        public int ID_Alu;
        String ConnectionString;
        SqlConnection Connection;


        public Form_Alumno(int ID)
        {
            int ID_Alu = ID;
            Cargar_ID(ID);
            InitializeComponent();
            
        }
           
        private void TabControl_Principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl_Principal.SelectedIndex)
            {
                case 2:
                    Cargar_Perfil();
                break;
            }
        }


        void Cargar_ID(int ID)
        {
            ID_Alu = ID;
        }

        void Cargar_Perfil()
        {
            
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
            String Usuario = Convert.ToString(ID_Alu);
            Connection.Open();
            String Query = "select * from Alumnos where IDAlumno = @Usuario";
            SqlParameter[] Data = new SqlParameter[1];
            Data[0] = new SqlParameter("@Usuario", Usuario);
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddRange(Data);
            using (var DataReader = Command.ExecuteReader())
            {
                if (DataReader.Read())
                {
                    String NumeroDeControl = Convert.ToString(DataReader["NumeroDeControl"]);
                    String Nombre = Convert.ToString(DataReader["Nombre"]);
                    String Apellidos = Convert.ToString(DataReader["Apellidos"]);
                    Int32 Edad = Convert.ToInt32(DataReader["Edad"]);
                    Char Sexo = Convert.ToChar(DataReader["Sexo"]);
                    Int32 Semestre = Convert.ToInt32(DataReader["Semestre"]);
                    String Carrera = Convert.ToString(DataReader["Carrera"]);
                    String Email = Convert.ToString(DataReader["Email"]);
                    String Telefono = Convert.ToString(DataReader["Telefono"]);

                    tbx_nControl.Text = NumeroDeControl;
                    tbx_nombre.Text = Nombre;
                    tbx_apellidos.Text = Apellidos;
                    tbx_email.Text = Email;
                    tbx_carrera.Text = Carrera;
                    tbx_semestre.Text = Semestre.ToString();
                    tbx_telefono.Text = Telefono;
                    numericUpDown1.Value = Edad;
                    if (Sexo == 'H')
                    {
                        comboBox1.SelectedItem = "Hombre";
                    }
                    else
                    {
                        comboBox1.SelectedItem = "Mujer";
                    }

                }
            }
            Connection.Close();
        }

        private void Form_Alumno_Load(object sender, EventArgs e)
        {

        }

        private void cbx_consultas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Alumno_Click(object sender, EventArgs e)
        {
            String Nombre = "", Apellidos = "", Email = "", Telefono = "", N_control = "", Semestre = "", Carrera = "";
            int Edad = 0;
            Char Sexo = '0';

            if ((tbx_nControl.Text == "") || (tbx_nombre.Text == "") || (tbx_apellidos.Text == "") || (tbx_telefono.Text == "") ||
               (tbx_carrera.Text == "") || (tbx_semestre.Text == "")
               || (comboBox1.SelectedIndex.Equals(-1)) || numericUpDown1.Value.ToString() == "0")
            {
                MessageBox.Show("Llene todos los datos porfavor");
            }
            else
            {
                N_control = tbx_nControl.Text;
                Nombre = tbx_nombre.Text;
                Apellidos = tbx_apellidos.Text;
                Edad = (int)Convert.ToDecimal(numericUpDown1.Value);
                if (comboBox1.Text == "Hombre")
                {
                    Sexo = 'H';
                }
                else
                {
                    Sexo = 'M';
                }
                //Sexo = Convert.ToChar(comboBox_Sexo.Text);
                Carrera = tbx_carrera.Text;
                Semestre = tbx_semestre.Text;
                Email = tbx_email.Text;
                Telefono = tbx_telefono.Text;
                Alumno Nuevo_Alumno = new Alumno();
                Nuevo_Alumno.NumeroDeControl = N_control;
                Nuevo_Alumno.Nombre = Nombre;
                Nuevo_Alumno.Apellidos = Apellidos;
                Nuevo_Alumno.Edad = Edad;
                Nuevo_Alumno.Sexo = Sexo;
                Nuevo_Alumno.Carrera = Carrera;
                Nuevo_Alumno.Semestre = Convert.ToInt32(Semestre);
                Nuevo_Alumno.Email = Email;
                Nuevo_Alumno.Telefono = Telefono;
                Nuevo_Alumno.IDAlumno = ID_Alu;

                

                // N_control, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Email, Telefono,ID
                Alumno_Manejador Manejador_Doc = new Alumno_Manejador();

                Manejador_Doc.Actualizar(Nuevo_Alumno);

                tbx_nControl.Clear();
                tbx_nombre.Clear();
                tbx_apellidos.Clear();
                tbx_email.Clear();
                tbx_carrera.Clear();
                tbx_semestre.Clear();
                tbx_telefono.Clear();
                numericUpDown1.Value = 0;
                comboBox1.Text = "";

                Cargar_Perfil();

                MessageBox.Show("TU PERFIL SE ACTUALIZO CON EXITO");

            }
        }
    }
}
