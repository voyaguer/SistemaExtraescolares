using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaExtraescolares
{
    class Actividad
    {
        public Int32 IDActividad { get; set; }
        public String Nombre { get; set; }

        public Actividad()
        {
            IDActividad = 0;
            Nombre = String.Empty;
        }

        public override String ToString()
        {
            return Nombre;
        }
    }
}
