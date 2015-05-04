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
    public partial class Form_Administrador : Form
    {
        IComunicacion Delegado;
        Boolean Actividades_ConDatos = false;
        Boolean Grupos_ConDatos = false;
        Boolean Docentes_ConDatos = false;
        Boolean Alumnos_ConDatos = false;
        Actividad[] Actividades;
        Alumno[] Alumnos;
        Grupo[] Grupos;
       
        Int32 IndiceSeleccionado;

        public Form_Administrador(IComunicacion Del)
        {
            InitializeComponent();
            Delegado = Del;
        }

        private void Button_Salir_Click(object sender, EventArgs e)
        {
            Delegado.Salir();
        }

        private void TabControl_Principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl_Principal.SelectedIndex)
            {
                case 1:
                    Cargar_Actividades();
                    Cargar_PestañaActividades();
                    break;
                case 2:
                    Cargar_Grupos();
                    Cargar_PestañaGrupos();
                    break;
                case 3:
                    Cargar_Docentes();
                    break;
                case 4:
                    Cargar_Alumnos();
                    Cargar_PestañaAlumnos();
                    break;
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
                Grupos = (new Grupo_Manejador()).GetList();
                foreach (Grupo Grup in Grupos)
                {
                    Grup.NombreActividad = Actividades.Single(Act => Act.IDActividad == Grup.IDActividad).Nombre;
                }
                (new Grupo_Manejador()).AsignarListaDeAlumnos(ref Grupos);
                Cargar_Alumnos();
            }
        }

        void Cargar_PestañaGrupos()
        {
            Cargar_Actividades();
            comboBox_Actividades.Items.Clear();
            foreach (Actividad Act in Actividades)
            {
                comboBox_Actividades.Items.Add(Act);
            }

            comboBox_MesPrimero.SelectedIndex = comboBox_MesPrimero.FindStringExact("Enero");
            comboBox_MesUltimo.SelectedIndex = comboBox_MesPrimero.FindStringExact("Febrero");
            comboBox_Actividades.SelectedIndex = 0;
        }

        void Cargar_Docentes()
        {

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

        void Cargar_PestañaAlumnos()
        {
            ListBox_Alumnos.Items.Clear();
            foreach (var Alum in Alumnos)
            {
                ListBox_Alumnos.Items.Add(Alum);
            }
            RadioButton_NumeroControl.Checked = true;
        }

        private void ToolStripMenuItem_Actividad_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Actividad_Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere borrar esta actividad?", "Confirmación",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
            Int32 IDActividad = ((Actividad)ListBox_Actividades_Actividades.Items[IndiceSeleccionado]).IDActividad;
            (new Actividad_Manejador()).Borrar(IDActividad);
            Actividades_ConDatos = false;
            Cargar_Actividades();
            }
        }

        private void RadioButton_NumeroControl_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_NumeroControl.Checked)
            {
                TextBox_BuscarAlumno.Text = "Numero De Control";
                TextBox_BuscarAlumno.ForeColor = Color.LightGray;
            }
        }

        private void RadioButton_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Nombre.Checked)
            {
                TextBox_BuscarAlumno.Text = "Nombre";
                TextBox_BuscarAlumno.ForeColor = Color.LightGray;
            }
        }

        private void ListBox_Alumnos_MouseUp(object sender, MouseEventArgs e)
        {
            Int32 Index = ListBox_Alumnos.IndexFromPoint(e.Location);
            if (Index == -1)
            {
                ListBox_Alumnos.SelectedIndex = -1;
            }
            else
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    IndiceSeleccionado = Index;
                    ListBox_Alumnos.SelectedIndex = Index;
                    ListBox Lista = (ListBox)sender;
                    ContextMenuStrip_Alumno.Show(Lista.PointToScreen(e.Location));
                }
            }
        }

        private void ToolStripMenuItem_Alumno_Modificar_Click(object sender, EventArgs e)
        {

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

        private void button_Agregar_Grupo_Click_1(object sender, EventArgs e)
        {
            Int32 Actividad_ID = ((Actividad)comboBox_Actividades.SelectedItem).IDActividad;
            uC_Horario_Dia1.Obtener_Horario_Dia();
            String Horario = uC_Horario_Dia1.Horario;
            Int32 Ciclo_Escolar = Convert.ToInt32(numericUpDown_CicloEscolar_Anho.Value);
            Int32 Mes_Primero = Convert.ToInt32(comboBox_MesPrimero.SelectedValue) + 1;
            Int32 Mes_Ultimo = Convert.ToInt32(comboBox_MesUltimo.SelectedValue) + 1;
            Int32 Capacidad = Convert.ToInt32(numericUpDown_Capacidad_Grupo.Value);
            if (checkBox_Dia2.Checked)
            {
                uC_Horario_Dia2.Obtener_Horario_Dia();
                Horario += "&"+uC_Horario_Dia2.Horario;
            }
            if (checkBox_Dia3.Checked)
            {
                uC_Horario_Dia3.Obtener_Horario_Dia();
                Horario += "&" + uC_Horario_Dia3.Horario;
            }


            Grupo Nuevo_Grupo = new Grupo(Actividad_ID, Ciclo_Escolar, Mes_Primero, Mes_Ultimo, Capacidad, Horario);
            Grupo_Manejador Manejador = new Grupo_Manejador();

            Manejador.Agregar_Grupo(Nuevo_Grupo);
        }

        private void ListBox_Actividades_Actividades_MouseUp(object sender, MouseEventArgs e)
        {
            Int32 Index = ListBox_Actividades_Actividades.IndexFromPoint(e.Location);
            if (Index == -1)
            {
                ListBox_Actividades_Actividades.SelectedIndex = -1;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    IndiceSeleccionado = Index;
                    ListBox_Actividades_Actividades.SelectedIndex = Index;
                    ListBox Lista = (ListBox)sender;
                    ContextMenuStrip_Actividad.Show(Lista.PointToScreen(e.Location));
                }
            }
        }

        private void ListBox_Actividades_Grupos_MouseUp(object sender, MouseEventArgs e)
        {
            Int32 Index = ListBox_Actividades_Grupos.IndexFromPoint(e.Location);
            if (Index == -1)
            {
                ListBox_Actividades_Grupos.SelectedIndex = -1;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    IndiceSeleccionado = Index;
                    ListBox_Actividades_Grupos.SelectedIndex = Index;
                    ListBox Lista = (ListBox)sender;
                    ContextMenuStrip_Grupo.Show(Lista.PointToScreen(e.Location));
                }
            }
        }

        private void ListBox_Actividades_Alumnos_MouseUp(object sender, MouseEventArgs e)
        {
            Int32 Index = ListBox_Actividades_Alumnos.IndexFromPoint(e.Location);
            if (Index == -1)
            {
                ListBox_Actividades_Alumnos.SelectedIndex = -1;
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    IndiceSeleccionado = Index;
                    ListBox_Actividades_Alumnos.SelectedIndex = Index;
                    ListBox Lista = (ListBox)sender;
                    ContextMenuStrip_Alumno.Show(Lista.PointToScreen(e.Location));
                }
            }
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

        private void checkBox_Dia2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Dia2.Checked)
            {
                uC_Horario_Dia2.Enabled = true;
            }
            else
            {
                uC_Horario_Dia2.Enabled = false;
            }
        }

        private void checkBox_Dia3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Dia3.Checked)
            {
                uC_Horario_Dia3.Enabled = true;
            }
            else
            {
                uC_Horario_Dia3.Enabled = false;
            }
        }

        private void button_Agrega_Docente_Click(object sender, EventArgs e)
        {
            String Nombre="", ApellidoP="", ApellidoM="", Email="", Telefono="";
            Int32 Edad=0;
            Char Sexo = '0';

            if ((textBox_Nombre.Text != null) || (textBox_ApellidoP.Text != null) || (textBox_ApellidoM.Text != null)
                || (textBox_Telefono.Text != null) || (comboBox_Sexo.SelectedItem != null) || numericUpDown_Edad.Value !=null)
            {
                Nombre = textBox_Nombre.Text;
                ApellidoP = textBox_ApellidoP.Text;
                ApellidoM = textBox_ApellidoM.Text;
                Edad = Convert.ToInt32(numericUpDown_Edad.Value);
                Sexo = Convert.ToChar(comboBox_Sexo.Text);
                Email = textBox_Email.Text;
                Telefono = textBox_Telefono.Text;
            }
            else
            {
                MessageBox.Show("Llene todos los datos porfavor");
            }

            Docente Nuevo_Docente = new Docente(Nombre, ApellidoP, ApellidoM, Edad, Sexo, Email, Telefono);

            Docente_Manejador Manejador_Doc = new Docente_Manejador();

            Manejador_Doc.Agregar_Docente(Nuevo_Docente);

            textBox_Nombre.Clear();
            textBox_ApellidoP.Clear();
            textBox_ApellidoM.Clear();
            numericUpDown_Edad.Value = 0;
            comboBox_Sexo.Text = "";
            textBox_Email.Clear();
            textBox_Telefono.Clear();

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
}