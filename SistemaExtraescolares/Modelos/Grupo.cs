using System;

namespace SistemaExtraescolares
{
    internal class Grupo
    {
        private int IDActividad { get; set; }

        public Int32 IDGrupo { get; set; }

        public Int32 CicloEscolar_Anho { get; set; }

        public Int32 CicloEscolar_MesPrimero { get; set; }

        public Int32 CicloEscolar_MesUltimo { get; set; }

        public Int32 Capacidad { get; set; }

        public string Horario { get; set; }

        public Grupo()
        {
            IDGrupo = 0;
            IDActividad = 0;

            Horario = String.Empty;
            Capacidad = 0;
            CicloEscolar_Anho = 0;
            CicloEscolar_MesPrimero = 0;
            CicloEscolar_MesUltimo = 0;
        }

        public override String ToString()
        {
            return IDGrupo.ToString();
        }
    }
}