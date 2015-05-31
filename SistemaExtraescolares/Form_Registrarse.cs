using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    public partial class Form_Registrarse : Form
    {
        IComunicacion Delegado;


        public Form_Registrarse(IComunicacion Del)
        {
            InitializeComponent();
            Delegado = Del;
        }

        private void btn_Add_Alumno_Click(object sender, EventArgs e)
        {

                String Nombre = "", ApellidoPaterno = "", ApellidoMaterno = "", Email = "", Telefono = "", N_control = "", Semestre = "", Carrera = "";
                int Edad = 0;
                int ID = 2;
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
                    ApellidoPaterno = tbx_apellidos.Text;
                    ApellidoPaterno = tbx_apellidos2.Text;
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
                    Nuevo_Alumno.ApellidoP = ApellidoPaterno;
                    Nuevo_Alumno.ApellidoM = ApellidoMaterno;
                    Nuevo_Alumno.Edad = Edad;
                    Nuevo_Alumno.Sexo = Sexo;
                    Nuevo_Alumno.Carrera = Carrera;
                    Nuevo_Alumno.Semestre = Convert.ToInt32(Semestre);
                    Nuevo_Alumno.Email = Email;
                    Nuevo_Alumno.Telefono = Telefono;
                    Nuevo_Alumno.IDUsuario = ID;

                    // N_control, Nombre, Apellidos, Edad, Sexo, Semestre, Carrera, Email, Telefono,ID
                    Alumno_Manejador Manejador_Doc = new Alumno_Manejador();

                    Manejador_Doc.Agregar_Alumno(Nuevo_Alumno);

                    tbx_nControl.Clear();
                    tbx_nombre.Clear();
                    tbx_apellidos.Clear();
                    tbx_email.Clear();
                    tbx_carrera.Clear();
                    tbx_semestre.Clear();
                    tbx_telefono.Clear();
                    numericUpDown1.Value = 0;
                    comboBox1.Text = "";

                }
        }

        private void Button_Regresar_Login_Click(object sender, EventArgs e)
        {
            Delegado.Cargar_Principal(4);
        }
    }
}
