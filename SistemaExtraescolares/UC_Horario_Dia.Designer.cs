namespace SistemaExtraescolares
{
    partial class UC_Horario_Dia
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Dia = new System.Windows.Forms.Label();
            this.comboBox_Horario_Dia1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Hora = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Minutos = new System.Windows.Forms.NumericUpDown();
            this.label_DosPuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Dia
            // 
            this.label_Dia.AutoSize = true;
            this.label_Dia.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dia.Location = new System.Drawing.Point(3, 0);
            this.label_Dia.Name = "label_Dia";
            this.label_Dia.Size = new System.Drawing.Size(45, 22);
            this.label_Dia.TabIndex = 13;
            this.label_Dia.Text = "Día:";
            // 
            // comboBox_Horario_Dia1
            // 
            this.comboBox_Horario_Dia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Horario_Dia1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Horario_Dia1.FormattingEnabled = true;
            this.comboBox_Horario_Dia1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboBox_Horario_Dia1.Location = new System.Drawing.Point(7, 25);
            this.comboBox_Horario_Dia1.Name = "comboBox_Horario_Dia1";
            this.comboBox_Horario_Dia1.Size = new System.Drawing.Size(121, 30);
            this.comboBox_Horario_Dia1.TabIndex = 12;
            // 
            // numericUpDown_Hora
            // 
            this.numericUpDown_Hora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Hora.Location = new System.Drawing.Point(7, 61);
            this.numericUpDown_Hora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_Hora.Name = "numericUpDown_Hora";
            this.numericUpDown_Hora.Size = new System.Drawing.Size(41, 31);
            this.numericUpDown_Hora.TabIndex = 14;
            // 
            // numericUpDown_Minutos
            // 
            this.numericUpDown_Minutos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Minutos.Location = new System.Drawing.Point(75, 61);
            this.numericUpDown_Minutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_Minutos.Name = "numericUpDown_Minutos";
            this.numericUpDown_Minutos.Size = new System.Drawing.Size(41, 31);
            this.numericUpDown_Minutos.TabIndex = 15;
            // 
            // label_DosPuntos
            // 
            this.label_DosPuntos.AutoSize = true;
            this.label_DosPuntos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DosPuntos.Location = new System.Drawing.Point(54, 63);
            this.label_DosPuntos.Name = "label_DosPuntos";
            this.label_DosPuntos.Size = new System.Drawing.Size(15, 22);
            this.label_DosPuntos.TabIndex = 16;
            this.label_DosPuntos.Text = ":";
            // 
            // UC_Horario_Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_DosPuntos);
            this.Controls.Add(this.numericUpDown_Minutos);
            this.Controls.Add(this.numericUpDown_Hora);
            this.Controls.Add(this.label_Dia);
            this.Controls.Add(this.comboBox_Horario_Dia1);
            this.Name = "UC_Horario_Dia";
            this.Size = new System.Drawing.Size(142, 97);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Dia;
        private System.Windows.Forms.ComboBox comboBox_Horario_Dia1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hora;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minutos;
        private System.Windows.Forms.Label label_DosPuntos;
    }
}
