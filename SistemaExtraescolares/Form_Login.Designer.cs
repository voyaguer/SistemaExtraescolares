namespace SistemaExtraescolares
{
    partial class Form_Login
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
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TextBox_Usuario = new System.Windows.Forms.TextBox();
            this.Panel_Principal = new System.Windows.Forms.Panel();
            this.Label_Alerta = new System.Windows.Forms.Label();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.Button_Ingresar = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Registrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Principal.SuspendLayout();
            this.Panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.Location = new System.Drawing.Point(58, 17);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(129, 39);
            this.Label_Usuario.TabIndex = 0;
            this.Label_Usuario.Text = "Usuario";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(28, 67);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(163, 39);
            this.Label_Password.TabIndex = 1;
            this.Label_Password.Text = "Password";
            // 
            // TextBox_Usuario
            // 
            this.TextBox_Usuario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Usuario.Location = new System.Drawing.Point(192, 14);
            this.TextBox_Usuario.Name = "TextBox_Usuario";
            this.TextBox_Usuario.Size = new System.Drawing.Size(330, 47);
            this.TextBox_Usuario.TabIndex = 2;
            // 
            // Panel_Principal
            // 
            this.Panel_Principal.Controls.Add(this.label2);
            this.Panel_Principal.Controls.Add(this.label1);
            this.Panel_Principal.Controls.Add(this.Button_Registrarse);
            this.Panel_Principal.Controls.Add(this.Label_Alerta);
            this.Panel_Principal.Controls.Add(this.Panel_Login);
            this.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.Panel_Principal.Name = "Panel_Principal";
            this.Panel_Principal.Size = new System.Drawing.Size(1264, 681);
            this.Panel_Principal.TabIndex = 3;
            this.Panel_Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Principal_Paint);
            // 
            // Label_Alerta
            // 
            this.Label_Alerta.AutoSize = true;
            this.Label_Alerta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alerta.Location = new System.Drawing.Point(13, 12);
            this.Label_Alerta.Name = "Label_Alerta";
            this.Label_Alerta.Size = new System.Drawing.Size(0, 22);
            this.Label_Alerta.TabIndex = 6;
            // 
            // Panel_Login
            // 
            this.Panel_Login.AutoSize = true;
            this.Panel_Login.Controls.Add(this.Label_Usuario);
            this.Panel_Login.Controls.Add(this.Button_Ingresar);
            this.Panel_Login.Controls.Add(this.Label_Password);
            this.Panel_Login.Controls.Add(this.TextBox_Password);
            this.Panel_Login.Controls.Add(this.TextBox_Usuario);
            this.Panel_Login.Location = new System.Drawing.Point(290, 198);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(556, 200);
            this.Panel_Login.TabIndex = 5;
            // 
            // Button_Ingresar
            // 
            this.Button_Ingresar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Ingresar.Location = new System.Drawing.Point(192, 118);
            this.Button_Ingresar.Name = "Button_Ingresar";
            this.Button_Ingresar.Size = new System.Drawing.Size(330, 67);
            this.Button_Ingresar.TabIndex = 4;
            this.Button_Ingresar.Text = "Ingresar";
            this.Button_Ingresar.UseVisualStyleBackColor = true;
            this.Button_Ingresar.Click += new System.EventHandler(this.Button_Ingresar_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.Location = new System.Drawing.Point(192, 64);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '✌';
            this.TextBox_Password.Size = new System.Drawing.Size(330, 47);
            this.TextBox_Password.TabIndex = 3;
            // 
            // Button_Registrarse
            // 
            this.Button_Registrarse.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Registrarse.Location = new System.Drawing.Point(528, 542);
            this.Button_Registrarse.Name = "Button_Registrarse";
            this.Button_Registrarse.Size = new System.Drawing.Size(229, 57);
            this.Button_Registrarse.TabIndex = 7;
            this.Button_Registrarse.Text = "Registrarse";
            this.Button_Registrarse.UseVisualStyleBackColor = true;
            this.Button_Registrarse.Click += new System.EventHandler(this.Button_Registrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "\"Para tener acceso necesitas estar registrado\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Si eres un docente acude al departamento de administracion para ser dado de alta" +
    " en el sistema)";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Principal);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.Panel_Principal.ResumeLayout(false);
            this.Panel_Principal.PerformLayout();
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TextBox_Usuario;
        private System.Windows.Forms.Panel Panel_Principal;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Button Button_Ingresar;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Label Label_Alerta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Registrarse;
    }
}