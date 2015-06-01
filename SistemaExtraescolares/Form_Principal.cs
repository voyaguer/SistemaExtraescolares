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
    public partial class Form_Principal : Form, IComunicacion
    {
        public int ID_Alu;
        public Form_Principal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            Form_Login _Login = new Form_Login(this);
            Control _Controls = _Login.Controls[0];
            this.Controls.Add(_Controls);
        }

        public void Salir()
        {
            this.Controls.Clear();
            Form_Login _Login = new Form_Login(this);
            Control _Controls = _Login.Controls[0];
            this.Controls.Add(_Controls);
        }

        public void Cargar_Principal(int Rango, String Usuario, String Password)
        {
            /*
             * Alumno = 0
             * Docente = 1
             * Administrador = 2
             * Registarse = 3
             * Login = 4
             */
            this.Controls.Clear();
            if (Rango == 0)
            {
                //Form_Alumno _Alumno = new Form_Alumno(Rango);
                //Control _Controls = _Alumno.Controls[0];
                //this.Controls.Add(_Controls);
            }
            else if (Rango == 1)
            {
                Form_Docente _Docente = new Form_Docente(IDDocente, Usuario, Password);
                Control _Controls = _Docente.Controls[0];
                this.Controls.Add(_Controls);
            }
            else if (Rango == 2)
            {
                Form_Administrador _Administrador = new Form_Administrador(this);
                Control _Controls = _Administrador.Controls[0];
                this.Controls.Add(_Controls);
            }
            else if (Rango == 3)
            {
                Form_Registrarse _Registrarse = new Form_Registrarse(this);
                Control _Controls = _Registrarse.Controls[0];
                this.Controls.Add(_Controls);
            }
            else if (Rango == 4)
            {
                Form_Login _Login = new Form_Login(this);
                Control _Controls = _Login.Controls[0];
                this.Controls.Add(_Controls);
            }
        }

        public void Cargar_Alumnos(int Rango)
        {
            this.Controls.Clear();
            Form_Alumno _Alumno = new Form_Alumno(Rango);
            Control _Controls = _Alumno.Controls[0];
            this.Controls.Add(_Controls);
        }

        public int IDDocente { get; set; }
    }
}
