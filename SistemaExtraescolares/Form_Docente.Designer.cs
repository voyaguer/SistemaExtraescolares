namespace SistemaExtraescolares
{
    partial class Form_Docente
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
            this.TabControl_Docente = new System.Windows.Forms.TabControl();
            this.TabPage_Inicio = new System.Windows.Forms.TabPage();
            this.button_CambiarContrasenia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PassNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PassRepetir = new System.Windows.Forms.TextBox();
            this.label_passAnterior = new System.Windows.Forms.Label();
            this.textBox_passAnterior = new System.Windows.Forms.TextBox();
            this.Button_Salir = new System.Windows.Forms.Button();
            this.TabPage_Actividades = new System.Windows.Forms.TabPage();
            this.ListBox_Actividades_Alumnos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Grupos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Actividades = new System.Windows.Forms.ListBox();
            this.TextBox_BuscarActividad = new System.Windows.Forms.TextBox();
            this.TabPage_Alumnos = new System.Windows.Forms.TabPage();
            this.RadioButton_Nombre = new System.Windows.Forms.RadioButton();
            this.RadioButton_NumeroControl = new System.Windows.Forms.RadioButton();
            this.TextBox_BuscarAlumno = new System.Windows.Forms.TextBox();
            this.ListBox_Alumnos = new System.Windows.Forms.ListBox();
            this.TabPage_Listas = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Grupo = new System.Windows.Forms.Label();
            this.comboBox_ListaGrupo = new System.Windows.Forms.ComboBox();
            this.label_Bienvenido = new System.Windows.Forms.Label();
            this.TabControl_Docente.SuspendLayout();
            this.TabPage_Inicio.SuspendLayout();
            this.TabPage_Actividades.SuspendLayout();
            this.TabPage_Alumnos.SuspendLayout();
            this.TabPage_Listas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Docente
            // 
            this.TabControl_Docente.Controls.Add(this.TabPage_Inicio);
            this.TabControl_Docente.Controls.Add(this.TabPage_Actividades);
            this.TabControl_Docente.Controls.Add(this.TabPage_Alumnos);
            this.TabControl_Docente.Controls.Add(this.TabPage_Listas);
            this.TabControl_Docente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl_Docente.Location = new System.Drawing.Point(0, 0);
            this.TabControl_Docente.Name = "TabControl_Docente";
            this.TabControl_Docente.SelectedIndex = 0;
            this.TabControl_Docente.Size = new System.Drawing.Size(1264, 681);
            this.TabControl_Docente.TabIndex = 2;
            this.TabControl_Docente.SelectedIndexChanged += new System.EventHandler(this.TabControl_Docente_SelectedIndexChanged);
            // 
            // TabPage_Inicio
            // 
            this.TabPage_Inicio.Controls.Add(this.label_Bienvenido);
            this.TabPage_Inicio.Controls.Add(this.button_CambiarContrasenia);
            this.TabPage_Inicio.Controls.Add(this.label2);
            this.TabPage_Inicio.Controls.Add(this.textBox_PassNuevo);
            this.TabPage_Inicio.Controls.Add(this.label1);
            this.TabPage_Inicio.Controls.Add(this.textBox_PassRepetir);
            this.TabPage_Inicio.Controls.Add(this.label_passAnterior);
            this.TabPage_Inicio.Controls.Add(this.textBox_passAnterior);
            this.TabPage_Inicio.Controls.Add(this.Button_Salir);
            this.TabPage_Inicio.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Inicio.Name = "TabPage_Inicio";
            this.TabPage_Inicio.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Inicio.Size = new System.Drawing.Size(1256, 644);
            this.TabPage_Inicio.TabIndex = 0;
            this.TabPage_Inicio.Text = "Inicio";
            this.TabPage_Inicio.UseVisualStyleBackColor = true;
            // 
            // button_CambiarContrasenia
            // 
            this.button_CambiarContrasenia.Location = new System.Drawing.Point(214, 236);
            this.button_CambiarContrasenia.Name = "button_CambiarContrasenia";
            this.button_CambiarContrasenia.Size = new System.Drawing.Size(277, 37);
            this.button_CambiarContrasenia.TabIndex = 7;
            this.button_CambiarContrasenia.Text = "Cambiar Contraseña";
            this.button_CambiarContrasenia.UseVisualStyleBackColor = true;
            this.button_CambiarContrasenia.Click += new System.EventHandler(this.button_CambiarContrasenia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña Nueva:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_PassNuevo
            // 
            this.textBox_PassNuevo.Location = new System.Drawing.Point(214, 126);
            this.textBox_PassNuevo.Name = "textBox_PassNuevo";
            this.textBox_PassNuevo.PasswordChar = '*';
            this.textBox_PassNuevo.Size = new System.Drawing.Size(277, 29);
            this.textBox_PassNuevo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repetir Contraseña:";
            // 
            // textBox_PassRepetir
            // 
            this.textBox_PassRepetir.Location = new System.Drawing.Point(214, 172);
            this.textBox_PassRepetir.Name = "textBox_PassRepetir";
            this.textBox_PassRepetir.PasswordChar = '*';
            this.textBox_PassRepetir.Size = new System.Drawing.Size(277, 29);
            this.textBox_PassRepetir.TabIndex = 3;
            // 
            // label_passAnterior
            // 
            this.label_passAnterior.AutoSize = true;
            this.label_passAnterior.Location = new System.Drawing.Point(26, 78);
            this.label_passAnterior.Name = "label_passAnterior";
            this.label_passAnterior.Size = new System.Drawing.Size(182, 24);
            this.label_passAnterior.TabIndex = 2;
            this.label_passAnterior.Text = "Contraseña Anterior:";
            // 
            // textBox_passAnterior
            // 
            this.textBox_passAnterior.Location = new System.Drawing.Point(214, 75);
            this.textBox_passAnterior.Name = "textBox_passAnterior";
            this.textBox_passAnterior.PasswordChar = '*';
            this.textBox_passAnterior.Size = new System.Drawing.Size(277, 29);
            this.textBox_passAnterior.TabIndex = 1;
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
            this.TabPage_Actividades.Size = new System.Drawing.Size(1256, 644);
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
            this.ListBox_Actividades_Grupos.SelectedIndexChanged += new System.EventHandler(this.ListBox_Actividades_Grupos_SelectedIndexChanged);
            // 
            // ListBox_Actividades_Actividades
            // 
            this.ListBox_Actividades_Actividades.FormattingEnabled = true;
            this.ListBox_Actividades_Actividades.ItemHeight = 24;
            this.ListBox_Actividades_Actividades.Location = new System.Drawing.Point(8, 43);
            this.ListBox_Actividades_Actividades.Name = "ListBox_Actividades_Actividades";
            this.ListBox_Actividades_Actividades.Size = new System.Drawing.Size(290, 580);
            this.ListBox_Actividades_Actividades.TabIndex = 2;
            this.ListBox_Actividades_Actividades.SelectedIndexChanged += new System.EventHandler(this.ListBox_Actividades_Actividades_SelectedIndexChanged);
            // 
            // TextBox_BuscarActividad
            // 
            this.TextBox_BuscarActividad.Location = new System.Drawing.Point(8, 6);
            this.TextBox_BuscarActividad.Name = "TextBox_BuscarActividad";
            this.TextBox_BuscarActividad.Size = new System.Drawing.Size(290, 29);
            this.TextBox_BuscarActividad.TabIndex = 1;
            this.TextBox_BuscarActividad.TextChanged += new System.EventHandler(this.TextBox_BuscarActividad_TextChanged);
            // 
            // TabPage_Alumnos
            // 
            this.TabPage_Alumnos.Controls.Add(this.RadioButton_Nombre);
            this.TabPage_Alumnos.Controls.Add(this.RadioButton_NumeroControl);
            this.TabPage_Alumnos.Controls.Add(this.TextBox_BuscarAlumno);
            this.TabPage_Alumnos.Controls.Add(this.ListBox_Alumnos);
            this.TabPage_Alumnos.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Alumnos.Name = "TabPage_Alumnos";
            this.TabPage_Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Alumnos.Size = new System.Drawing.Size(1256, 644);
            this.TabPage_Alumnos.TabIndex = 4;
            this.TabPage_Alumnos.Text = "Alumnos";
            this.TabPage_Alumnos.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Nombre
            // 
            this.RadioButton_Nombre.AutoSize = true;
            this.RadioButton_Nombre.Location = new System.Drawing.Point(8, 79);
            this.RadioButton_Nombre.Name = "RadioButton_Nombre";
            this.RadioButton_Nombre.Size = new System.Drawing.Size(97, 28);
            this.RadioButton_Nombre.TabIndex = 2;
            this.RadioButton_Nombre.TabStop = true;
            this.RadioButton_Nombre.Text = "Nombre";
            this.RadioButton_Nombre.UseVisualStyleBackColor = true;
            // 
            // RadioButton_NumeroControl
            // 
            this.RadioButton_NumeroControl.AutoSize = true;
            this.RadioButton_NumeroControl.Location = new System.Drawing.Point(8, 43);
            this.RadioButton_NumeroControl.Name = "RadioButton_NumeroControl";
            this.RadioButton_NumeroControl.Size = new System.Drawing.Size(191, 28);
            this.RadioButton_NumeroControl.TabIndex = 1;
            this.RadioButton_NumeroControl.TabStop = true;
            this.RadioButton_NumeroControl.Text = "Numero De Control";
            this.RadioButton_NumeroControl.UseVisualStyleBackColor = true;
            // 
            // TextBox_BuscarAlumno
            // 
            this.TextBox_BuscarAlumno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox_BuscarAlumno.Location = new System.Drawing.Point(8, 6);
            this.TextBox_BuscarAlumno.Name = "TextBox_BuscarAlumno";
            this.TextBox_BuscarAlumno.Size = new System.Drawing.Size(191, 29);
            this.TextBox_BuscarAlumno.TabIndex = 0;
            this.TextBox_BuscarAlumno.TextChanged += new System.EventHandler(this.TextBox_BuscarAlumno_TextChanged);
            // 
            // ListBox_Alumnos
            // 
            this.ListBox_Alumnos.FormattingEnabled = true;
            this.ListBox_Alumnos.ItemHeight = 24;
            this.ListBox_Alumnos.Location = new System.Drawing.Point(215, 6);
            this.ListBox_Alumnos.Name = "ListBox_Alumnos";
            this.ListBox_Alumnos.Size = new System.Drawing.Size(293, 604);
            this.ListBox_Alumnos.TabIndex = 3;
            // 
            // TabPage_Listas
            // 
            this.TabPage_Listas.Controls.Add(this.dataGridView1);
            this.TabPage_Listas.Controls.Add(this.label_Grupo);
            this.TabPage_Listas.Controls.Add(this.comboBox_ListaGrupo);
            this.TabPage_Listas.Location = new System.Drawing.Point(4, 33);
            this.TabPage_Listas.Name = "TabPage_Listas";
            this.TabPage_Listas.Size = new System.Drawing.Size(1256, 644);
            this.TabPage_Listas.TabIndex = 5;
            this.TabPage_Listas.Text = "Listas";
            this.TabPage_Listas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 449);
            this.dataGridView1.TabIndex = 2;
            // 
            // label_Grupo
            // 
            this.label_Grupo.AutoSize = true;
            this.label_Grupo.Location = new System.Drawing.Point(22, 31);
            this.label_Grupo.Name = "label_Grupo";
            this.label_Grupo.Size = new System.Drawing.Size(68, 24);
            this.label_Grupo.TabIndex = 1;
            this.label_Grupo.Text = "Grupo:";
            // 
            // comboBox_ListaGrupo
            // 
            this.comboBox_ListaGrupo.FormattingEnabled = true;
            this.comboBox_ListaGrupo.Location = new System.Drawing.Point(96, 28);
            this.comboBox_ListaGrupo.Name = "comboBox_ListaGrupo";
            this.comboBox_ListaGrupo.Size = new System.Drawing.Size(517, 32);
            this.comboBox_ListaGrupo.TabIndex = 0;
            // 
            // label_Bienvenido
            // 
            this.label_Bienvenido.AutoSize = true;
            this.label_Bienvenido.Location = new System.Drawing.Point(75, 20);
            this.label_Bienvenido.Name = "label_Bienvenido";
            this.label_Bienvenido.Size = new System.Drawing.Size(110, 24);
            this.label_Bienvenido.TabIndex = 8;
            this.label_Bienvenido.Text = "Bienvenido ";
            // 
            // Form_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TabControl_Docente);
            this.Name = "Form_Docente";
            this.Text = "Form_Docente";
            this.Load += new System.EventHandler(this.Form_Docente_Load);
            this.TabControl_Docente.ResumeLayout(false);
            this.TabPage_Inicio.ResumeLayout(false);
            this.TabPage_Inicio.PerformLayout();
            this.TabPage_Actividades.ResumeLayout(false);
            this.TabPage_Actividades.PerformLayout();
            this.TabPage_Alumnos.ResumeLayout(false);
            this.TabPage_Alumnos.PerformLayout();
            this.TabPage_Listas.ResumeLayout(false);
            this.TabPage_Listas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Docente;
        private System.Windows.Forms.TabPage TabPage_Inicio;
        private System.Windows.Forms.Button button_CambiarContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PassNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PassRepetir;
        private System.Windows.Forms.Label label_passAnterior;
        private System.Windows.Forms.TextBox textBox_passAnterior;
        private System.Windows.Forms.Button Button_Salir;
        private System.Windows.Forms.TabPage TabPage_Actividades;
        private System.Windows.Forms.ListBox ListBox_Actividades_Alumnos;
        private System.Windows.Forms.ListBox ListBox_Actividades_Grupos;
        private System.Windows.Forms.ListBox ListBox_Actividades_Actividades;
        private System.Windows.Forms.TextBox TextBox_BuscarActividad;
        private System.Windows.Forms.TabPage TabPage_Alumnos;
        private System.Windows.Forms.RadioButton RadioButton_Nombre;
        private System.Windows.Forms.RadioButton RadioButton_NumeroControl;
        private System.Windows.Forms.TextBox TextBox_BuscarAlumno;
        private System.Windows.Forms.ListBox ListBox_Alumnos;
        private System.Windows.Forms.TabPage TabPage_Listas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Grupo;
        private System.Windows.Forms.ComboBox comboBox_ListaGrupo;
        private System.Windows.Forms.Label label_Bienvenido;
    }
}