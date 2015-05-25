using System;

namespace SistemaExtraescolares
{
    class Alumno
    {
        public Int32 IDAlumno { get; set; }
        public String NumeroDeControl { get; set; }
        public String Nombre { get; set; }
        public String ApellidoP { get; set; }
        public String ApellidoM { get; set; }
        public Int32 Edad { get; set; }
        public Char Sexo { get; set; }
        public Int32 Semestre { get; set; }
        public String Carrera { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }
        public Int32 IDUsuario { get; set; }
        public String NombreCompleto
        {
            get { return Nombre + " " + ApellidoP + " " + ApellidoM; }
        }

        public Alumno()
        {
            IDAlumno = 0;
            NumeroDeControl = String.Empty;
            Nombre = String.Empty;
            ApellidoP = String.Empty;
            ApellidoM = String.Empty;
            Edad = 0;
            Sexo = ' ';
            Semestre = 0;
            Carrera = String.Empty;
            Email = String.Empty;
            Telefono = String.Empty;
            IDUsuario = 0;
        }

        public override String ToString()
        {
            return NombreCompleto;
        }
    }
}
