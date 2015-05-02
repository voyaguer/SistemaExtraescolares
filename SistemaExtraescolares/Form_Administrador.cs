﻿using System;
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
                    break;
                case 2:
                    Cargar_Grupos();
                    break;
                case 3:
                    Cargar_Docentes();
                    break;
                case 4:
                    Cargar_Alumnos();
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
            ListBox_Actividades.Items.Clear();
            foreach (Actividad Act in Actividades)
            {
                ListBox_Actividades.Items.Add(Act);
            }
            Actividades_ConDatos = true;
        }

        void Cargar_Grupos()
        {

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
                ListBox_Alumnos.Items.Clear();
                foreach (var Alum in Alumnos)
                {
                    ListBox_Alumnos.Items.Add(Alum);
                }
            }
            Alumnos_ConDatos = true;
            RadioButton_NumeroControl.Checked = true;
        }

        private void TextBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox_Actividades_MouseUp(object sender, MouseEventArgs e)
        {
            Int32 Index = ListBox_Actividades.IndexFromPoint(e.Location);
            if (Index == -1)
            {
                ListBox_Actividades.SelectedIndex = -1;
            }
            else
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    IndiceSeleccionado = Index;
                    ListBox_Actividades.SelectedIndex = Index;
                    ListBox Lista = (ListBox)sender;
                    ContextMenuStrip_Actividad.Show(Lista.PointToScreen(e.Location));
                }
            }
        }

        private void ToolStripMenuItem_Actividad_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Actividad_Borrar_Click(object sender, EventArgs e)
        {
            Int32 IDActividad = ((Actividad)ListBox_Actividades.Items[IndiceSeleccionado]).IDActividad;
            (new Actividad_Manejador()).Borrar(IDActividad);
            Actividades_ConDatos = false;
            Cargar_Actividades();
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

        private void TextBox_BuscarAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox_BuscarAlumno_Leave(object sender, EventArgs e)
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
            ListBox_Actividades.Items.Clear();
            foreach (Actividad Act in array_Act)
            {
                ListBox_Actividades.Items.Add(Act);
            }
            if (array_Act.Count() != 0)
            {
                ListBox_Actividades.SelectedIndex = 0;
            }
        }

    }
}