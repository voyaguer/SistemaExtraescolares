﻿namespace SistemaExtraescolares
{
    partial class Form_Alumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabControl_Principal = new System.Windows.Forms.TabControl();
            this.TabPage_Inicio = new System.Windows.Forms.TabPage();
            this.Button_Salir = new System.Windows.Forms.Button();
            this.TabPage_Actividades = new System.Windows.Forms.TabPage();
            this.ListBox_Actividades_Alumnos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Grupos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Actividades = new System.Windows.Forms.ListBox();
            this.TextBox_BuscarActividad = new System.Windows.Forms.TextBox();
            this.TabPage_Alumnos = new System.Windows.Forms.TabPage();
            this.gbx_Add_Alumno = new System.Windows.Forms.GroupBox();
            this.btn_Add_Alumno = new System.Windows.Forms.Button();
            this.tbx_semestre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_carrera = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_nControl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_apellidos = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_apellidos2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.TabControl_Principal.SuspendLayout();
            this.TabPage_Inicio.SuspendLayout();
            this.TabPage_Actividades.SuspendLayout();
            this.TabPage_Alumnos.SuspendLayout();
            this.gbx_Add_Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl_Principal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 681);
            this.panel1.TabIndex = 0;
            // 
            // TabControl_Principal
            // 
            this.TabControl_Principal.Controls.Add(this.TabPage_Inicio);
            this.TabControl_Principal.Controls.Add(this.TabPage_Actividades);
            this.TabControl_Principal.Controls.Add(this.TabPage_Alumnos);
            this.TabControl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl_Principal.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Principal.Name = "TabControl_Principal";
            this.TabControl_Principal.SelectedIndex = 0;
            this.TabControl_Principal.Size = new System.Drawing.Size(1012, 681);
            this.TabControl_Principal.TabIndex = 1;
            this.TabControl_Principal.SelectedIndexChanged += new System.EventHandler(this.TabControl_Principal_SelectedIndexChanged);
            // 
            // TabPage_Inicio
            // 
            this.TabPage_Inicio.Controls.Add(this.Button_Salir);
            this.TabPage_Inicio.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Inicio.Name = "TabPage_Inicio";
            this.TabPage_Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Inicio.Size = new System.Drawing.Size(1004, 644);
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
            // 
            // TabPage_Actividades
            // 
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Alumnos);
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Grupos);
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Actividades);
            this.TabPage_Actividades.Controls.Add(this.TextBox_BuscarActividad);
            this.TabPage_Actividades.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Actividades.Name = "TabPage_Actividades";
            this.TabPage_Actividades.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Actividades.Size = new System.Drawing.Size(1004, 644);
            this.TabPage_Actividades.TabIndex = 1;
            this.TabPage_Actividades.Text = "Actividades";
            this.TabPage_Actividades.UseVisualStyleBackColor = true;
            // 
            // ListBox_Actividades_Alumnos
            // 
            this.ListBox_Actividades_Alumnos.FormattingEnabled = true;
            this.ListBox_Actividades_Alumnos.ItemHeight = 24;
            this.ListBox_Actividades_Alumnos.Location = new System.Drawing.Point(800, 43);
            this.ListBox_Actividades_Alumnos.Name = "ListBox_Actividades_Alumnos";
            this.ListBox_Actividades_Alumnos.Size = new System.Drawing.Size(450, 580);
            this.ListBox_Actividades_Alumnos.TabIndex = 4;
            this.ListBox_Actividades_Alumnos.Visible = false;
            // 
            // ListBox_Actividades_Grupos
            // 
            this.ListBox_Actividades_Grupos.FormattingEnabled = true;
            this.ListBox_Actividades_Grupos.HorizontalScrollbar = true;
            this.ListBox_Actividades_Grupos.ItemHeight = 24;
            this.ListBox_Actividades_Grupos.Location = new System.Drawing.Point(304, 43);
            this.ListBox_Actividades_Grupos.Name = "ListBox_Actividades_Grupos";
            this.ListBox_Actividades_Grupos.Size = new System.Drawing.Size(490, 580);
            this.ListBox_Actividades_Grupos.TabIndex = 3;
            this.ListBox_Actividades_Grupos.Visible = false;
            // 
            // ListBox_Actividades_Actividades
            // 
            this.ListBox_Actividades_Actividades.FormattingEnabled = true;
            this.ListBox_Actividades_Actividades.ItemHeight = 24;
            this.ListBox_Actividades_Actividades.Location = new System.Drawing.Point(8, 43);
            this.ListBox_Actividades_Actividades.Name = "ListBox_Actividades_Actividades";
            this.ListBox_Actividades_Actividades.Size = new System.Drawing.Size(290, 580);
            this.ListBox_Actividades_Actividades.TabIndex = 2;
            // 
            // TextBox_BuscarActividad
            // 
            this.TextBox_BuscarActividad.Location = new System.Drawing.Point(8, 6);
            this.TextBox_BuscarActividad.Name = "TextBox_BuscarActividad";
            this.TextBox_BuscarActividad.Size = new System.Drawing.Size(290, 29);
            this.TextBox_BuscarActividad.TabIndex = 1;
            // 
            // TabPage_Alumnos
            // 
            this.TabPage_Alumnos.Controls.Add(this.gbx_Add_Alumno);
            this.TabPage_Alumnos.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Alumnos.Name = "TabPage_Alumnos";
            this.TabPage_Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Alumnos.Size = new System.Drawing.Size(1004, 644);
            this.TabPage_Alumnos.TabIndex = 4;
            this.TabPage_Alumnos.Text = "Mi Perfil";
            this.TabPage_Alumnos.UseVisualStyleBackColor = true;
            // 
            // gbx_Add_Alumno
            // 
            this.gbx_Add_Alumno.Controls.Add(this.tbx_apellidos2);
            this.gbx_Add_Alumno.Controls.Add(this.label1);
            this.gbx_Add_Alumno.Controls.Add(this.btn_Add_Alumno);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_semestre);
            this.gbx_Add_Alumno.Controls.Add(this.label13);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_carrera);
            this.gbx_Add_Alumno.Controls.Add(this.label12);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_nControl);
            this.gbx_Add_Alumno.Controls.Add(this.label11);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_email);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_telefono);
            this.gbx_Add_Alumno.Controls.Add(this.label9);
            this.gbx_Add_Alumno.Controls.Add(this.label10);
            this.gbx_Add_Alumno.Controls.Add(this.comboBox1);
            this.gbx_Add_Alumno.Controls.Add(this.numericUpDown1);
            this.gbx_Add_Alumno.Controls.Add(this.label7);
            this.gbx_Add_Alumno.Controls.Add(this.label8);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_apellidos);
            this.gbx_Add_Alumno.Controls.Add(this.tbx_nombre);
            this.gbx_Add_Alumno.Controls.Add(this.label5);
            this.gbx_Add_Alumno.Controls.Add(this.label6);
            this.gbx_Add_Alumno.Location = new System.Drawing.Point(36, 34);
            this.gbx_Add_Alumno.Name = "gbx_Add_Alumno";
            this.gbx_Add_Alumno.Size = new System.Drawing.Size(294, 501);
            this.gbx_Add_Alumno.TabIndex = 4;
            this.gbx_Add_Alumno.TabStop = false;
            this.gbx_Add_Alumno.Text = "Alumno";
            // 
            // btn_Add_Alumno
            // 
            this.btn_Add_Alumno.Location = new System.Drawing.Point(42, 409);
            this.btn_Add_Alumno.Name = "btn_Add_Alumno";
            this.btn_Add_Alumno.Size = new System.Drawing.Size(194, 37);
            this.btn_Add_Alumno.TabIndex = 13;
            this.btn_Add_Alumno.Text = "Modificar Perfil";
            this.btn_Add_Alumno.UseVisualStyleBackColor = true;
            this.btn_Add_Alumno.Click += new System.EventHandler(this.btn_Add_Alumno_Click);
            // 
            // tbx_semestre
            // 
            this.tbx_semestre.Location = new System.Drawing.Point(105, 287);
            this.tbx_semestre.Name = "tbx_semestre";
            this.tbx_semestre.Size = new System.Drawing.Size(153, 29);
            this.tbx_semestre.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Semestre";
            // 
            // tbx_carrera
            // 
            this.tbx_carrera.Location = new System.Drawing.Point(105, 252);
            this.tbx_carrera.Name = "tbx_carrera";
            this.tbx_carrera.Size = new System.Drawing.Size(153, 29);
            this.tbx_carrera.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "Carrera";
            // 
            // tbx_nControl
            // 
            this.tbx_nControl.Location = new System.Drawing.Point(105, 40);
            this.tbx_nControl.Name = "tbx_nControl";
            this.tbx_nControl.Size = new System.Drawing.Size(153, 29);
            this.tbx_nControl.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "N.Control";
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(105, 322);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(153, 29);
            this.tbx_email.TabIndex = 11;
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Location = new System.Drawing.Point(105, 357);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(153, 29);
            this.tbx_telefono.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Email";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBox1.Location = new System.Drawing.Point(105, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 32);
            this.comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 179);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 29);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Edad";
            // 
            // tbx_apellidos
            // 
            this.tbx_apellidos.Location = new System.Drawing.Point(105, 111);
            this.tbx_apellidos.Name = "tbx_apellidos";
            this.tbx_apellidos.Size = new System.Drawing.Size(153, 29);
            this.tbx_apellidos.TabIndex = 6;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(105, 76);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(153, 29);
            this.tbx_nombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "ApellidoP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "ApellidoM";
            // 
            // tbx_apellidos2
            // 
            this.tbx_apellidos2.Location = new System.Drawing.Point(105, 144);
            this.tbx_apellidos2.Name = "tbx_apellidos2";
            this.tbx_apellidos2.Size = new System.Drawing.Size(153, 29);
            this.tbx_apellidos2.TabIndex = 33;
            // 
            // Form_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Alumno";
            this.Text = "Form_Alumno";
            this.Load += new System.EventHandler(this.Form_Alumno_Load);
            this.panel1.ResumeLayout(false);
            this.TabControl_Principal.ResumeLayout(false);
            this.TabPage_Inicio.ResumeLayout(false);
            this.TabPage_Actividades.ResumeLayout(false);
            this.TabPage_Actividades.PerformLayout();
            this.TabPage_Alumnos.ResumeLayout(false);
            this.gbx_Add_Alumno.ResumeLayout(false);
            this.gbx_Add_Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabControl_Principal;
        private System.Windows.Forms.TabPage TabPage_Inicio;
        private System.Windows.Forms.Button Button_Salir;
        private System.Windows.Forms.TabPage TabPage_Actividades;
        private System.Windows.Forms.ListBox ListBox_Actividades_Alumnos;
        private System.Windows.Forms.ListBox ListBox_Actividades_Grupos;
        private System.Windows.Forms.ListBox ListBox_Actividades_Actividades;
        private System.Windows.Forms.TextBox TextBox_BuscarActividad;
        private System.Windows.Forms.TabPage TabPage_Alumnos;
        private System.Windows.Forms.GroupBox gbx_Add_Alumno;
        private System.Windows.Forms.Button btn_Add_Alumno;
        private System.Windows.Forms.TextBox tbx_semestre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_carrera;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_nControl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_apellidos;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_apellidos2;
        private System.Windows.Forms.Label label1;
    }
}