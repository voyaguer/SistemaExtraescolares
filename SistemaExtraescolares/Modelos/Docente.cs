using System;
using System.Collections.Generic;

namespace SistemaExtraescolares
{
    class Docente
    {
        public Int32 IDDocente { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public Int32 Edad { get; set; }
        public Char Sexo { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }
        public Int32 IDUsuario { get; set; }
        public String NombreCompleto
        {
            get { return Nombre + " " + ApellidoP+ " "+ApellidoM; }
        }

         public Docente()
        {
            IDDocente = 0;
            Nombre = String.Empty;
            ApellidoP = String.Empty;
            ApellidoM = String.Empty;
            Edad = 0;
            Sexo = ' ';
            Email = String.Empty;
            Telefono = String.Empty;
            IDUsuario = 0;
        }

         public Docente(String _Nombre, String _ApellidoP, String _ApellidoM, Int32 _Edad, Char _Sexo,
             String _Email, String _Telefono)// ID de usuario tmb?
        {
            this.Nombre = _Nombre;
            this.ApellidoP = _ApellidoP;
            this.ApellidoM = _ApellidoM;
            this.Edad = _Edad;
            this.Sexo = _Sexo;
            this.Email = _Email;
            this.Telefono = _Telefono;
        }

        public override String ToString()
        {
            return NombreCompleto;
        }
    }
}
