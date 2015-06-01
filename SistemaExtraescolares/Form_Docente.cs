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
    public partial class Form_Docente : Form
    {
        Boolean Actividades_ConDatos = false;
        Boolean Grupos_ConDatos = false;
        //Boolean Docentes_ConDatos = false;
        Boolean Alumnos_ConDatos = false;
        Actividad[] Actividades;
        Alumno[] Alumnos;
        Grupo[] Grupos;
        Int32 IDDocente = 0;
        String password = "";
        string Alumno_ModificarAgregar;
        private string Usuario;
        private string Password;
        Int32 IDDocentes=0;
        public Form_Docente(Int32 IDDocente, string Usuario, string Password)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.Password = Password;
            this.IDDocentes = IDDocente;
            label_Bienvenido.Text = "Bienvenido " + Usuario;
        }

        public Form_Docente()
        {
            // TODO: Complete member initialization
            
        }

        private void button_CambiarContrasenia_Click(object sender, EventArgs e)
        {

            try
            {
                if (password == textBox_passAnterior.Text)
                {
                    if (textBox_PassNuevo.Text == textBox_PassRepetir.Text)
                    {
                        Docente_Manejador _Docente = new Docente_Manejador();
                        //_Docente.CambiarPass(IDDocente, textBox_PassNuevo.Text);
                        _Docente.CambiarPass(this.IDDocente, textBox_PassNuevo.Text);
                        MessageBox.Show("Contraseña cambiada");
                    }
                    else
                    {
                        MessageBox.Show("La contraseña verifique la contraseña nueva");
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide con con contraseña anterior, intruduzca su antigua contraseña");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique los datos");
            }
        }

        private void Form_Docente_Load(object sender, EventArgs e)
        {

        }

        private void TabControl_Docente_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl_Docente.SelectedIndex)
            {
                case 1:
                    Cargar_Actividades();
                    Cargar_PestañaActividades();
                    break;
                case 2:
                    Cargar_Alumnos();
                    Cargar_PestañaAlumnos();
                    break;
                case 3:
                    //Cargar_Grupos();
                    //Cargar_PestañaListas();
                    break;
                default:
                    break;
            }
        }
        private void Cargar_PestañaListas()
        {
            foreach (Grupo Grup in Grupos)
            {
                comboBox_ListaGrupo.Items.Add(Grup);
            }
            try
            {
                comboBox_ListaGrupo.SelectedIndex = 0;
            }
            catch (Exception)
            {

                //throw;
            }



        }
        void Cargar_PestañaAlumnos()
        {
            ListBox_Alumnos.Items.Clear();
            foreach (var Alum in Alumnos)
            {
                ListBox_Alumnos.Items.Add(Alum);
            }
            RadioButton_NumeroControl.Checked = true;


        }
        void Cargar_Alumnos()
        {
            if (!Alumnos_ConDatos)
            {
                Alumnos = (new Alumno_Manejador()).GetList();
                var array_Alumnos = from _Alumno in Alumnos
                                    orderby _Alumno.NumeroDeControl descending
                                    select _Alumno;
                Alumnos = array_Alumnos.ToArray();
            }
            Alumnos_ConDatos = true;
        }
        void Cargar_PestañaActividades()
        {
            ListBox_Actividades_Actividades.Items.Clear();
            foreach (Actividad Act in Actividades)
            {
                ListBox_Actividades_Actividades.Items.Add(Act);
            }
            Cargar_Grupos();
            Cargar_Alumnos();
        }
        void Cargar_Grupos()
        {
            if (!Grupos_ConDatos)
            {
                Cargar_Actividades();
                Grupos = (new Grupo_Manejador()).GetList(this.IDDocente);
                foreach (Grupo Grup in Grupos)
                {
                    Grup.NombreActividad = Actividades.Single(Act => Act.IDActividad == Grup.IDActividad).Nombre;
                }
                (new Grupo_Manejador()).AsignarListaDeAlumnos(ref Grupos);
                Cargar_Alumnos();
            }
        }
        void Cargar_Actividades()
        {
            if (!Actividades_ConDatos)
            {
                Actividades = (new Actividad_Manejador()).GetList();
                var array_Act = from _Actividad in Actividades
                                orderby _Actividad.Nombre ascending
                                select _Actividad;
                Actividades = array_Act.ToArray();
            }
            Actividades_ConDatos = true;
        }

        private void ListBox_Actividades_Actividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Actividades_Actividades.SelectedIndex == -1)
            {
                ListBox_Actividades_Grupos.SelectedIndex = -1;
                ListBox_Actividades_Grupos.Visible = false;
                ListBox_Actividades_Alumnos.SelectedIndex = -1;
                ListBox_Actividades_Alumnos.Visible = false;
            }
            else
            {
                ListBox_Actividades_Alumnos.Visible = false;
                ListBox_Actividades_Grupos.Visible = true;
                ListBox Lista = (ListBox)sender;
                ListBox_Actividades_Grupos.Items.Clear();
                foreach (Grupo Gru in Grupos)
                {
                    if (Gru.IDActividad == ((Actividad)Lista.SelectedItem).IDActividad)
                    {
                        ListBox_Actividades_Grupos.Items.Add(Gru);
                    }
                }
            }
        }

        private void ListBox_Actividades_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Actividades_Grupos.SelectedIndex == -1)
            {
                ListBox_Actividades_Alumnos.SelectedIndex = -1;
                ListBox_Actividades_Alumnos.Visible = false;
            }
            else
            {
                ListBox_Actividades_Alumnos.Visible = true;
                ListBox Lista = (ListBox)sender;
                ListBox_Actividades_Alumnos.Items.Clear();
                foreach (Alumno Alu in Alumnos)
                {
                    if (((Grupo)Lista.SelectedItem).ListaAlumnos.Contains(Alu.IDAlumno))
                    {
                        ListBox_Actividades_Alumnos.Items.Add(Alu);
                    }
                }
            }
        }

        private void TextBox_BuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            if (RadioButton_NumeroControl.Checked)
            {
                String Texto = TextBox_BuscarAlumno.Text.ToLower();
                var array_Alum = from Alum in Alumnos
                                 where (Alum.NumeroDeControl.ToString()).StartsWith(Texto)
                                 select Alum;
                ListBox_Alumnos.Items.Clear();
                foreach (Alumno Alum in array_Alum)
                {
                    ListBox_Alumnos.Items.Add(Alum);
                }
                if (array_Alum.Count() != 0)
                {
                    ListBox_Alumnos.SelectedIndex = 0;
                }
            }
            else if (RadioButton_Nombre.Checked)
            {
                String Texto = TextBox_BuscarAlumno.Text.ToLower();
                var array_Alum = from Alum in Alumnos
                                 where (Alum.NombreCompleto.ToLower()).Contains(Texto)
                                 select Alum;
                ListBox_Alumnos.Items.Clear();
                foreach (Alumno Alum in array_Alum)
                {
                    ListBox_Alumnos.Items.Add(Alum);
                }
                if (array_Alum.Count() != 0)
                {
                    ListBox_Alumnos.SelectedIndex = 0;
                }
            }
        }

        private void TextBox_BuscarActividad_TextChanged(object sender, EventArgs e)
        {
            String Texto = TextBox_BuscarActividad.Text.ToLower();
            var array_Act = from _Actividad in Actividades
                            where (_Actividad.Nombre.ToLower()).Contains(Texto)
                            select _Actividad;
            ListBox_Actividades_Actividades.Items.Clear();
            foreach (Actividad Act in array_Act)
            {
                ListBox_Actividades_Actividades.Items.Add(Act);
            }
            if (array_Act.Count() != 0)
            {
                ListBox_Actividades_Actividades.SelectedIndex = 0;
            }
        }


    }
}
