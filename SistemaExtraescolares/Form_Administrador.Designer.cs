namespace SistemaExtraescolares
{
    partial class Form_Administrador
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
            this.ListBox_Actividades_Alumnos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Grupos = new System.Windows.Forms.ListBox();
            this.ListBox_Actividades_Actividades = new System.Windows.Forms.ListBox();
            this.TextBox_BuscarActividad = new System.Windows.Forms.TextBox();
            this.TabPage_Grupos = new System.Windows.Forms.TabPage();
            this.groupBox_Agregar_Grupo = new System.Windows.Forms.GroupBox();
            this.button_Agregar_Grupo = new System.Windows.Forms.Button();
            this.label_Horario_Grupo = new System.Windows.Forms.Label();
            this.numericUpDown_Capacidad_Grupo = new System.Windows.Forms.NumericUpDown();
            this.label_Capacidad_Grupo = new System.Windows.Forms.Label();
            this.comboBox_MesUltimo = new System.Windows.Forms.ComboBox();
            this.label_MesUltimo = new System.Windows.Forms.Label();
            this.comboBox_MesPrimero = new System.Windows.Forms.ComboBox();
            this.label_MesPrimero = new System.Windows.Forms.Label();
            this.numericUpDown_CicloEscolar_Anho = new System.Windows.Forms.NumericUpDown();
            this.label_CicloEscolar_Anho = new System.Windows.Forms.Label();
            this.comboBox_Actividades = new System.Windows.Forms.ComboBox();
            this.TabPage_Docentes = new System.Windows.Forms.TabPage();
            this.TabPage_Alumnos = new System.Windows.Forms.TabPage();
            this.RadioButton_Nombre = new System.Windows.Forms.RadioButton();
            this.RadioButton_NumeroControl = new System.Windows.Forms.RadioButton();
            this.TextBox_BuscarAlumno = new System.Windows.Forms.TextBox();
            this.ListBox_Alumnos = new System.Windows.Forms.ListBox();
            this.TabPage_Reportes = new System.Windows.Forms.TabPage();
            this.TabPage_Consultas = new System.Windows.Forms.TabPage();
            this.ContextMenuStrip_Actividad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Actividad_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Actividad_Borrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_Alumno = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Alumno_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_Grupo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uC_Horario_Dia1 = new SistemaExtraescolares.UC_Horario_Dia();
            this.panel1.SuspendLayout();
            this.TabControl_Principal.SuspendLayout();
            this.TabPage_Inicio.SuspendLayout();
            this.TabPage_Actividades.SuspendLayout();
            this.TabPage_Grupos.SuspendLayout();
            this.groupBox_Agregar_Grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacidad_Grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CicloEscolar_Anho)).BeginInit();
            this.TabPage_Alumnos.SuspendLayout();
            this.ContextMenuStrip_Actividad.SuspendLayout();
            this.ContextMenuStrip_Alumno.SuspendLayout();
            this.ContextMenuStrip_Grupo.SuspendLayout();
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
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Alumnos);
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Grupos);
            this.TabPage_Actividades.Controls.Add(this.ListBox_Actividades_Actividades);
            this.TabPage_Actividades.Controls.Add(this.TextBox_BuscarActividad);
            this.TabPage_Actividades.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Actividades.Name = "TabPage_Actividades";
            this.TabPage_Actividades.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Actividades.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Actividades.TabIndex = 1;
            this.TabPage_Actividades.Text = "Actividades";
            this.TabPage_Actividades.UseVisualStyleBackColor = true;
            // 
            // ListBox_Actividades_Alumnos
            // 
            this.ListBox_Actividades_Alumnos.FormattingEnabled = true;
            this.ListBox_Actividades_Alumnos.ItemHeight = 22;
            this.ListBox_Actividades_Alumnos.Location = new System.Drawing.Point(720, 43);
            this.ListBox_Actividades_Alumnos.Name = "ListBox_Actividades_Alumnos";
            this.ListBox_Actividades_Alumnos.Size = new System.Drawing.Size(530, 598);
            this.ListBox_Actividades_Alumnos.TabIndex = 4;
            this.ListBox_Actividades_Alumnos.Visible = false;
            this.ListBox_Actividades_Alumnos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox_Actividades_Alumnos_MouseUp);
            // 
            // ListBox_Actividades_Grupos
            // 
            this.ListBox_Actividades_Grupos.FormattingEnabled = true;
            this.ListBox_Actividades_Grupos.ItemHeight = 22;
            this.ListBox_Actividades_Grupos.Location = new System.Drawing.Point(304, 43);
            this.ListBox_Actividades_Grupos.Name = "ListBox_Actividades_Grupos";
            this.ListBox_Actividades_Grupos.Size = new System.Drawing.Size(410, 598);
            this.ListBox_Actividades_Grupos.TabIndex = 3;
            this.ListBox_Actividades_Grupos.Visible = false;
            this.ListBox_Actividades_Grupos.SelectedIndexChanged += new System.EventHandler(this.ListBox_Actividades_Grupos_SelectedIndexChanged);
            this.ListBox_Actividades_Grupos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox_Actividades_Grupos_MouseUp);
            // 
            // ListBox_Actividades_Actividades
            // 
            this.ListBox_Actividades_Actividades.FormattingEnabled = true;
            this.ListBox_Actividades_Actividades.ItemHeight = 22;
            this.ListBox_Actividades_Actividades.Location = new System.Drawing.Point(8, 43);
            this.ListBox_Actividades_Actividades.Name = "ListBox_Actividades_Actividades";
            this.ListBox_Actividades_Actividades.Size = new System.Drawing.Size(290, 598);
            this.ListBox_Actividades_Actividades.TabIndex = 2;
            this.ListBox_Actividades_Actividades.SelectedIndexChanged += new System.EventHandler(this.ListBox_Actividades_Actividades_SelectedIndexChanged);
            this.ListBox_Actividades_Actividades.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox_Actividades_Actividades_MouseUp);
            // 
            // TextBox_BuscarActividad
            // 
            this.TextBox_BuscarActividad.Location = new System.Drawing.Point(8, 6);
            this.TextBox_BuscarActividad.Name = "TextBox_BuscarActividad";
            this.TextBox_BuscarActividad.Size = new System.Drawing.Size(290, 31);
            this.TextBox_BuscarActividad.TabIndex = 1;
            this.TextBox_BuscarActividad.TextChanged += new System.EventHandler(this.TextBox_BuscarActividad_TextChanged);
            // 
            // TabPage_Grupos
            // 
            this.TabPage_Grupos.Controls.Add(this.groupBox_Agregar_Grupo);
            this.TabPage_Grupos.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Grupos.Name = "TabPage_Grupos";
            this.TabPage_Grupos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Grupos.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Grupos.TabIndex = 2;
            this.TabPage_Grupos.Text = "Grupos";
            this.TabPage_Grupos.UseVisualStyleBackColor = true;
            // 
            // groupBox_Agregar_Grupo
            // 
            this.groupBox_Agregar_Grupo.Controls.Add(this.uC_Horario_Dia1);
            this.groupBox_Agregar_Grupo.Controls.Add(this.button_Agregar_Grupo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.label_Horario_Grupo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.numericUpDown_Capacidad_Grupo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.label_Capacidad_Grupo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.comboBox_MesUltimo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.label_MesUltimo);
            this.groupBox_Agregar_Grupo.Controls.Add(this.comboBox_MesPrimero);
            this.groupBox_Agregar_Grupo.Controls.Add(this.label_MesPrimero);
            this.groupBox_Agregar_Grupo.Controls.Add(this.numericUpDown_CicloEscolar_Anho);
            this.groupBox_Agregar_Grupo.Controls.Add(this.label_CicloEscolar_Anho);
            this.groupBox_Agregar_Grupo.Controls.Add(this.comboBox_Actividades);
            this.groupBox_Agregar_Grupo.Location = new System.Drawing.Point(74, 54);
            this.groupBox_Agregar_Grupo.Name = "groupBox_Agregar_Grupo";
            this.groupBox_Agregar_Grupo.Size = new System.Drawing.Size(677, 395);
            this.groupBox_Agregar_Grupo.TabIndex = 0;
            this.groupBox_Agregar_Grupo.TabStop = false;
            this.groupBox_Agregar_Grupo.Text = "Agregar Grupo";
            // 
            // button_Agregar_Grupo
            // 
            this.button_Agregar_Grupo.Location = new System.Drawing.Point(437, 331);
            this.button_Agregar_Grupo.Name = "button_Agregar_Grupo";
            this.button_Agregar_Grupo.Size = new System.Drawing.Size(172, 40);
            this.button_Agregar_Grupo.TabIndex = 27;
            this.button_Agregar_Grupo.Text = "Agregar Grupo";
            this.button_Agregar_Grupo.UseVisualStyleBackColor = true;
            this.button_Agregar_Grupo.Click += new System.EventHandler(this.button_Agregar_Grupo_Click_1);
            // 
            // label_Horario_Grupo
            // 
            this.label_Horario_Grupo.AutoSize = true;
            this.label_Horario_Grupo.Location = new System.Drawing.Point(354, 150);
            this.label_Horario_Grupo.Name = "label_Horario_Grupo";
            this.label_Horario_Grupo.Size = new System.Drawing.Size(97, 22);
            this.label_Horario_Grupo.TabIndex = 26;
            this.label_Horario_Grupo.Text = "- Horario -";
            // 
            // numericUpDown_Capacidad_Grupo
            // 
            this.numericUpDown_Capacidad_Grupo.Location = new System.Drawing.Point(187, 141);
            this.numericUpDown_Capacidad_Grupo.Name = "numericUpDown_Capacidad_Grupo";
            this.numericUpDown_Capacidad_Grupo.Size = new System.Drawing.Size(122, 31);
            this.numericUpDown_Capacidad_Grupo.TabIndex = 25;
            this.numericUpDown_Capacidad_Grupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Capacidad_Grupo
            // 
            this.label_Capacidad_Grupo.AutoSize = true;
            this.label_Capacidad_Grupo.Location = new System.Drawing.Point(52, 143);
            this.label_Capacidad_Grupo.Name = "label_Capacidad_Grupo";
            this.label_Capacidad_Grupo.Size = new System.Drawing.Size(123, 22);
            this.label_Capacidad_Grupo.TabIndex = 24;
            this.label_Capacidad_Grupo.Text = "Capacidad:";
            // 
            // comboBox_MesUltimo
            // 
            this.comboBox_MesUltimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MesUltimo.FormattingEnabled = true;
            this.comboBox_MesUltimo.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox_MesUltimo.Location = new System.Drawing.Point(483, 107);
            this.comboBox_MesUltimo.Name = "comboBox_MesUltimo";
            this.comboBox_MesUltimo.Size = new System.Drawing.Size(158, 30);
            this.comboBox_MesUltimo.TabIndex = 23;
            // 
            // label_MesUltimo
            // 
            this.label_MesUltimo.AutoSize = true;
            this.label_MesUltimo.Location = new System.Drawing.Point(384, 110);
            this.label_MesUltimo.Name = "label_MesUltimo";
            this.label_MesUltimo.Size = new System.Drawing.Size(93, 22);
            this.label_MesUltimo.TabIndex = 22;
            this.label_MesUltimo.Text = "Mes final:";
            // 
            // comboBox_MesPrimero
            // 
            this.comboBox_MesPrimero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MesPrimero.FormattingEnabled = true;
            this.comboBox_MesPrimero.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox_MesPrimero.Location = new System.Drawing.Point(187, 107);
            this.comboBox_MesPrimero.Name = "comboBox_MesPrimero";
            this.comboBox_MesPrimero.Size = new System.Drawing.Size(122, 30);
            this.comboBox_MesPrimero.TabIndex = 21;
            // 
            // label_MesPrimero
            // 
            this.label_MesPrimero.AutoSize = true;
            this.label_MesPrimero.Location = new System.Drawing.Point(52, 110);
            this.label_MesPrimero.Name = "label_MesPrimero";
            this.label_MesPrimero.Size = new System.Drawing.Size(105, 22);
            this.label_MesPrimero.TabIndex = 20;
            this.label_MesPrimero.Text = "Mes inicial:";
            // 
            // numericUpDown_CicloEscolar_Anho
            // 
            this.numericUpDown_CicloEscolar_Anho.Location = new System.Drawing.Point(187, 70);
            this.numericUpDown_CicloEscolar_Anho.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown_CicloEscolar_Anho.Name = "numericUpDown_CicloEscolar_Anho";
            this.numericUpDown_CicloEscolar_Anho.Size = new System.Drawing.Size(122, 31);
            this.numericUpDown_CicloEscolar_Anho.TabIndex = 19;
            this.numericUpDown_CicloEscolar_Anho.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // label_CicloEscolar_Anho
            // 
            this.label_CicloEscolar_Anho.AutoSize = true;
            this.label_CicloEscolar_Anho.Location = new System.Drawing.Point(52, 72);
            this.label_CicloEscolar_Anho.Name = "label_CicloEscolar_Anho";
            this.label_CicloEscolar_Anho.Size = new System.Drawing.Size(130, 22);
            this.label_CicloEscolar_Anho.TabIndex = 18;
            this.label_CicloEscolar_Anho.Text = "Ciclo escolar:";
            // 
            // comboBox_Actividades
            // 
            this.comboBox_Actividades.FormattingEnabled = true;
            this.comboBox_Actividades.Location = new System.Drawing.Point(388, 40);
            this.comboBox_Actividades.Name = "comboBox_Actividades";
            this.comboBox_Actividades.Size = new System.Drawing.Size(253, 30);
            this.comboBox_Actividades.TabIndex = 17;
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
            this.TabPage_Alumnos.Controls.Add(this.RadioButton_Nombre);
            this.TabPage_Alumnos.Controls.Add(this.RadioButton_NumeroControl);
            this.TabPage_Alumnos.Controls.Add(this.TextBox_BuscarAlumno);
            this.TabPage_Alumnos.Controls.Add(this.ListBox_Alumnos);
            this.TabPage_Alumnos.Location = new System.Drawing.Point(4, 31);
            this.TabPage_Alumnos.Name = "TabPage_Alumnos";
            this.TabPage_Alumnos.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Alumnos.Size = new System.Drawing.Size(1256, 646);
            this.TabPage_Alumnos.TabIndex = 4;
            this.TabPage_Alumnos.Text = "Alumnos";
            this.TabPage_Alumnos.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Nombre
            // 
            this.RadioButton_Nombre.AutoSize = true;
            this.RadioButton_Nombre.Location = new System.Drawing.Point(8, 79);
            this.RadioButton_Nombre.Name = "RadioButton_Nombre";
            this.RadioButton_Nombre.Size = new System.Drawing.Size(102, 26);
            this.RadioButton_Nombre.TabIndex = 3;
            this.RadioButton_Nombre.TabStop = true;
            this.RadioButton_Nombre.Text = "Nombre";
            this.RadioButton_Nombre.UseVisualStyleBackColor = true;
            // 
            // RadioButton_NumeroControl
            // 
            this.RadioButton_NumeroControl.AutoSize = true;
            this.RadioButton_NumeroControl.Location = new System.Drawing.Point(8, 43);
            this.RadioButton_NumeroControl.Name = "RadioButton_NumeroControl";
            this.RadioButton_NumeroControl.Size = new System.Drawing.Size(204, 26);
            this.RadioButton_NumeroControl.TabIndex = 2;
            this.RadioButton_NumeroControl.TabStop = true;
            this.RadioButton_NumeroControl.Text = "Numero De Control";
            this.RadioButton_NumeroControl.UseVisualStyleBackColor = true;
            // 
            // TextBox_BuscarAlumno
            // 
            this.TextBox_BuscarAlumno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox_BuscarAlumno.Location = new System.Drawing.Point(8, 6);
            this.TextBox_BuscarAlumno.Name = "TextBox_BuscarAlumno";
            this.TextBox_BuscarAlumno.Size = new System.Drawing.Size(290, 31);
            this.TextBox_BuscarAlumno.TabIndex = 1;
            this.TextBox_BuscarAlumno.TextChanged += new System.EventHandler(this.TextBox_BuscarAlumno_TextChanged);
            // 
            // ListBox_Alumnos
            // 
            this.ListBox_Alumnos.FormattingEnabled = true;
            this.ListBox_Alumnos.ItemHeight = 22;
            this.ListBox_Alumnos.Location = new System.Drawing.Point(304, 6);
            this.ListBox_Alumnos.Name = "ListBox_Alumnos";
            this.ListBox_Alumnos.Size = new System.Drawing.Size(530, 620);
            this.ListBox_Alumnos.TabIndex = 0;
            this.ListBox_Alumnos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox_Alumnos_MouseUp);
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
            this.ContextMenuStrip_Actividad.Size = new System.Drawing.Size(126, 48);
            // 
            // ToolStripMenuItem_Actividad_Modificar
            // 
            this.ToolStripMenuItem_Actividad_Modificar.Name = "ToolStripMenuItem_Actividad_Modificar";
            this.ToolStripMenuItem_Actividad_Modificar.Size = new System.Drawing.Size(125, 22);
            this.ToolStripMenuItem_Actividad_Modificar.Text = "Modificar";
            this.ToolStripMenuItem_Actividad_Modificar.Click += new System.EventHandler(this.ToolStripMenuItem_Actividad_Modificar_Click);
            // 
            // ToolStripMenuItem_Actividad_Borrar
            // 
            this.ToolStripMenuItem_Actividad_Borrar.Name = "ToolStripMenuItem_Actividad_Borrar";
            this.ToolStripMenuItem_Actividad_Borrar.Size = new System.Drawing.Size(125, 22);
            this.ToolStripMenuItem_Actividad_Borrar.Text = "Borrar";
            this.ToolStripMenuItem_Actividad_Borrar.Click += new System.EventHandler(this.ToolStripMenuItem_Actividad_Borrar_Click);
            // 
            // ContextMenuStrip_Alumno
            // 
            this.ContextMenuStrip_Alumno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Alumno_Modificar});
            this.ContextMenuStrip_Alumno.Name = "ContextMenuStrip_Alumno";
            this.ContextMenuStrip_Alumno.Size = new System.Drawing.Size(126, 26);
            // 
            // ToolStripMenuItem_Alumno_Modificar
            // 
            this.ToolStripMenuItem_Alumno_Modificar.Name = "ToolStripMenuItem_Alumno_Modificar";
            this.ToolStripMenuItem_Alumno_Modificar.Size = new System.Drawing.Size(125, 22);
            this.ToolStripMenuItem_Alumno_Modificar.Text = "Modificar";
            this.ToolStripMenuItem_Alumno_Modificar.Click += new System.EventHandler(this.ToolStripMenuItem_Alumno_Modificar_Click);
            // 
            // ContextMenuStrip_Grupo
            // 
            this.ContextMenuStrip_Grupo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.ContextMenuStrip_Grupo.Name = "ContextMenuStrip_Grupo";
            this.ContextMenuStrip_Grupo.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // uC_Horario_Dia1
            // 
            this.uC_Horario_Dia1.Horario = null;
            this.uC_Horario_Dia1.Location = new System.Drawing.Point(51, 178);
            this.uC_Horario_Dia1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uC_Horario_Dia1.Name = "uC_Horario_Dia1";
            this.uC_Horario_Dia1.Size = new System.Drawing.Size(231, 193);
            this.uC_Horario_Dia1.TabIndex = 28;
            // 
            // Form_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Administrador";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.TabControl_Principal.ResumeLayout(false);
            this.TabPage_Inicio.ResumeLayout(false);
            this.TabPage_Actividades.ResumeLayout(false);
            this.TabPage_Actividades.PerformLayout();
            this.TabPage_Grupos.ResumeLayout(false);
            this.groupBox_Agregar_Grupo.ResumeLayout(false);
            this.groupBox_Agregar_Grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacidad_Grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CicloEscolar_Anho)).EndInit();
            this.TabPage_Alumnos.ResumeLayout(false);
            this.TabPage_Alumnos.PerformLayout();
            this.ContextMenuStrip_Actividad.ResumeLayout(false);
            this.ContextMenuStrip_Alumno.ResumeLayout(false);
            this.ContextMenuStrip_Grupo.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TextBox_BuscarActividad;
        private System.Windows.Forms.ListBox ListBox_Actividades_Actividades;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Actividad;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Actividad_Modificar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Actividad_Borrar;
        private System.Windows.Forms.ListBox ListBox_Alumnos;
        private System.Windows.Forms.TextBox TextBox_BuscarAlumno;
        private System.Windows.Forms.RadioButton RadioButton_Nombre;
        private System.Windows.Forms.RadioButton RadioButton_NumeroControl;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Alumno;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Alumno_Modificar;
        private System.Windows.Forms.GroupBox groupBox_Agregar_Grupo;
        private System.Windows.Forms.Button button_Agregar_Grupo;
        private System.Windows.Forms.Label label_Horario_Grupo;
        private System.Windows.Forms.NumericUpDown numericUpDown_Capacidad_Grupo;
        private System.Windows.Forms.Label label_Capacidad_Grupo;
        private System.Windows.Forms.ComboBox comboBox_MesUltimo;
        private System.Windows.Forms.Label label_MesUltimo;
        private System.Windows.Forms.ComboBox comboBox_MesPrimero;
        private System.Windows.Forms.Label label_MesPrimero;
        private System.Windows.Forms.NumericUpDown numericUpDown_CicloEscolar_Anho;
        private System.Windows.Forms.Label label_CicloEscolar_Anho;
        private System.Windows.Forms.ComboBox comboBox_Actividades;
        private UC_Horario_Dia uC_Horario_Dia1;
        private System.Windows.Forms.ListBox ListBox_Actividades_Grupos;
        private System.Windows.Forms.ListBox ListBox_Actividades_Alumnos;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Grupo;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}