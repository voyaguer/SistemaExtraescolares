﻿namespace SistemaExtraescolares
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl_Principal = new System.Windows.Forms.TabControl();
            this.TabPage_Inicio = new System.Windows.Forms.TabPage();
            this.Button_Salir = new System.Windows.Forms.Button();
            this.TabPage_Actividades = new System.Windows.Forms.TabPage();
            this.ListBox_Actividades = new System.Windows.Forms.ListBox();
            this.TextBox_Buscar = new System.Windows.Forms.TextBox();
            this.TabPage_Grupos = new System.Windows.Forms.TabPage();
            this.TabPage_Docentes = new System.Windows.Forms.TabPage();
            this.TabPage_Alumnos = new System.Windows.Forms.TabPage();
            this.TabPage_Reportes = new System.Windows.Forms.TabPage();
            this.TabPage_Consultas = new System.Windows.Forms.TabPage();
            this.ContextMenuStrip_Actividad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Actividad_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Actividad_Borrar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.TabControl_Principal.SuspendLayout();
            this.TabPage_Inicio.SuspendLayout();
            this.TabPage_Actividades.SuspendLayout();
            this.ContextMenuStrip_Actividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl_Principal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 0;
            // 
            // TabControl_Principal
            // 
            this.TabControl_Principal.Controls.Add(this.TabPage_Inicio);
            this.TabControl_Principal.Controls.Add(this.TabPage_Actividades);
            this.TabControl_Principal.Controls.Add(this.TabPage_Grupos);
            this.TabControl_Principal.Controls.Add(this.TabPage_Docentes);
            this.TabControl_Principal.Controls.Add(this.TabPage_Alumnos);
            this.TabControl_Principal.Controls.Add(this.TabPage_Reportes);
            this.TabControl_Principal.Controls.Add(this.TabPage_Consultas);
            this.TabControl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Principal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl_Principal.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Principal.Name = "TabControl_Principal";
            this.TabControl_Principal.SelectedIndex = 0;
            this.TabControl_Principal.Size = new System.Drawing.Size(1264, 681);
            this.TabControl_Principal.TabIndex = 0;
            this.TabControl_Principal.SelectedIndexChanged += new System.EventHandler(this.TabControl_Principal_SelectedIndexChanged);
            // 
            // TabPage_Inicio
            // 
            this.TabPage_Inicio.Controls.Add(this.Button_Salir);
            this.TabPage_Inicio.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Inicio.Name = "TabPage_Inicio";
            this.TabPage_Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Inicio.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Inicio.TabIndex = 0;
            this.TabPage_Inicio.Text = "Inicio";
            this.TabPage_Inicio.UseVisualStyleBackColor = true;
            // 
            // Button_Salir
            // 
            this.Button_Salir.Location = new System.Drawing.Point(1153, 601);
            this.Button_Salir.Name = "Button_Salir";
            this.Button_Salir.Size = new System.Drawing.Size(95, 37);
            this.Button_Salir.TabIndex = 0;
            this.Button_Salir.Text = "Salir";
            this.Button_Salir.UseVisualStyleBackColor = true;
            this.Button_Salir.Click += new System.EventHandler(this.Button_Salir_Click);
            // 
            // TabPage_Actividades
            // 
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades);
            this.TabPage_Actividades.Controls.Add(this.TextBox_Buscar);
            this.TabPage_Actividades.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Actividades.Name = "TabPage_Actividades";
            this.TabPage_Actividades.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Actividades.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Actividades.TabIndex = 1;
            this.TabPage_Actividades.Text = "Actividades";
            this.TabPage_Actividades.UseVisualStyleBackColor = true;
            // 
            // ListBox_Actividades
            // 
            this.ListBox_Actividades.FormattingEnabled = true;
            this.ListBox_Actividades.ItemHeight = 22;
            this.ListBox_Actividades.Location = new System.Drawing.Point(8, 43);
            this.ListBox_Actividades.Name = "ListBox_Actividades";
            this.ListBox_Actividades.Size = new System.Drawing.Size(290, 598);
            this.ListBox_Actividades.TabIndex = 2;
            this.ListBox_Actividades.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox_Actividades_MouseUp);
            // 
            // TextBox_Buscar
            // 
            this.TextBox_Buscar.Location = new System.Drawing.Point(8, 6);
            this.TextBox_Buscar.Name = "TextBox_Buscar";
            this.TextBox_Buscar.Size = new System.Drawing.Size(290, 31);
            this.TextBox_Buscar.TabIndex = 1;
            this.TextBox_Buscar.TextChanged += new System.EventHandler(this.TextBox_Buscar_TextChanged);
            // 
            // TabPage_Grupos
            // 
            this.TabPage_Grupos.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Grupos.Name = "TabPage_Grupos";
            this.TabPage_Grupos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Grupos.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Grupos.TabIndex = 2;
            this.TabPage_Grupos.Text = "Grupos";
            this.TabPage_Grupos.UseVisualStyleBackColor = true;
            // 
            // TabPage_Docentes
            // 
            this.TabPage_Docentes.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Docentes.Name = "TabPage_Docentes";
            this.TabPage_Docentes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Docentes.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Docentes.TabIndex = 3;
            this.TabPage_Docentes.Text = "Docentes";
            this.TabPage_Docentes.UseVisualStyleBackColor = true;
            // 
            // TabPage_Alumnos
            // 
            this.TabPage_Alumnos.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Alumnos.Name = "TabPage_Alumnos";
            this.TabPage_Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Alumnos.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Alumnos.TabIndex = 4;
            this.TabPage_Alumnos.Text = "Alumnos";
            this.TabPage_Alumnos.UseVisualStyleBackColor = true;
            // 
            // TabPage_Reportes
            // 
            this.TabPage_Reportes.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Reportes.Name = "TabPage_Reportes";
            this.TabPage_Reportes.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Reportes.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Reportes.TabIndex = 5;
            this.TabPage_Reportes.Text = "Reportes";
            this.TabPage_Reportes.UseVisualStyleBackColor = true;
            // 
            // TabPage_Consultas
            // 
            this.TabPage_Consultas.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Consultas.Name = "TabPage_Consultas";
            this.TabPage_Consultas.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Consultas.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Consultas.TabIndex = 6;
            this.TabPage_Consultas.Text = "Consultas";
            this.TabPage_Consultas.UseVisualStyleBackColor = true;
            // 
            // ContextMenuStrip_Actividad
            // 
            this.ContextMenuStrip_Actividad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Actividad_Modificar,
            this.ToolStripMenuItem_Actividad_Borrar});
            this.ContextMenuStrip_Actividad.Name = "ContextMenuStrip_Actividad";
            this.ContextMenuStrip_Actividad.Size = new System.Drawing.Size(153, 70);
            // 
            // ToolStripMenuItem_Actividad_Modificar
            // 
            this.ToolStripMenuItem_Actividad_Modificar.Name = "ToolStripMenuItem_Actividad_Modificar";
            this.ToolStripMenuItem_Actividad_Modificar.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Actividad_Modificar.Text = "Modificar";
            this.ToolStripMenuItem_Actividad_Modificar.Click += new System.EventHandler(this.ToolStripMenuItem_Actividad_Modificar_Click);
            // 
            // ToolStripMenuItem_Actividad_Borrar
            // 
            this.ToolStripMenuItem_Actividad_Borrar.Name = "ToolStripMenuItem_Actividad_Borrar";
            this.ToolStripMenuItem_Actividad_Borrar.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Actividad_Borrar.Text = "Borrar";
            this.ToolStripMenuItem_Actividad_Borrar.Click += new System.EventHandler(this.ToolStripMenuItem_Actividad_Borrar_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.TabControl_Principal.ResumeLayout(false);
            this.TabPage_Inicio.ResumeLayout(false);
            this.TabPage_Actividades.ResumeLayout(false);
            this.TabPage_Actividades.PerformLayout();
            this.ContextMenuStrip_Actividad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabControl_Principal;
        private System.Windows.Forms.TabPage TabPage_Inicio;
        private System.Windows.Forms.TabPage TabPage_Actividades;
        private System.Windows.Forms.TabPage TabPage_Grupos;
        private System.Windows.Forms.TabPage TabPage_Docentes;
        private System.Windows.Forms.TabPage TabPage_Alumnos;
        private System.Windows.Forms.TabPage TabPage_Reportes;
        private System.Windows.Forms.TabPage TabPage_Consultas;
        private System.Windows.Forms.Button Button_Salir;
        private System.Windows.Forms.TextBox TextBox_Buscar;
        private System.Windows.Forms.ListBox ListBox_Actividades;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Actividad;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Actividad_Modificar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Actividad_Borrar;
    }
}