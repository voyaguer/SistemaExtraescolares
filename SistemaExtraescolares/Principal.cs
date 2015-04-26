

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
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            Login _Login = new Login(this);
            Control _Controls = _Login.Controls[0];
            this.Controls.Add(_Controls);
        }

        public void Salir()
        {
            this.Controls.Clear();
            Login _Login = new Login(this);
            Control _Controls = _Login.Controls[0];
            this.Controls.Add(_Controls);
        }

        public void Cargar_Principal(int Rango)
        {
            /*
             * Alumno = 0
             * Docente = 1
             * Administrador = 2
             */
            this.Controls.Clear();
            if (Rango == 0)
            {
                Alumno _Alumno = new Alumno();
                Control _Controls = _Alumno.Controls[0];
                this.Controls.Add(_Controls);
            }
            else if (Rango == 1)
            {

            }
            else if (Rango == 2)
            {
                Administrador _Administrador = new Administrador(this);
                Control _Controls = _Administrador.Controls[0];
                this.Controls.Add(_Controls);
            }
        }
    }
}
