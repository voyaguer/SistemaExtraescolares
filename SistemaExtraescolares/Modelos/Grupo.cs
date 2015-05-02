using System;
using System.Collections.Generic;

namespace SistemaExtraescolares
{
    class Grupo
    {
        public Int32 IDActividad { get; set; }

        public Int32 IDGrupo { get; set; }

        public Int32 CicloEscolar_Anho { get; set; }

        public Int32 CicloEscolar_MesPrimero { get; set; }

        public Int32 CicloEscolar_MesUltimo { get; set; }

        public Int32 Capacidad { get; set; }

        public String Horario { get; set; }

        public String NombreActividad { get; set; }

        public List<Int32> ListaAlumnos { get; set; }

        public Grupo()
        {
            IDGrupo = 0;
            IDActividad = 0;

            Horario = String.Empty;
            Capacidad = 0;
            CicloEscolar_Anho = 0;
            CicloEscolar_MesPrimero = 0;
            CicloEscolar_MesUltimo = 0;

            NombreActividad = String.Empty;
            ListaAlumnos = new List<Int32>();
        }

        public Grupo(Int32 _IDActividad, Int32 _CicloEscolar_Anho,
            Int32 _CicloEscolar_MesPrimero, Int32 _CicloEscolar_MesUltimo, Int32 _Capacidad, String _Horario)
        {
            this.IDActividad = _IDActividad;
            this.CicloEscolar_Anho = _CicloEscolar_Anho;
            this.CicloEscolar_MesPrimero = _CicloEscolar_MesPrimero;
            this.CicloEscolar_MesUltimo = _CicloEscolar_MesUltimo;
            this.Capacidad = _Capacidad;
            this.Horario = _Horario;
        }

        public override String ToString()
        {
            return NombreActividad + " - " + Horario;
        }
    }
}