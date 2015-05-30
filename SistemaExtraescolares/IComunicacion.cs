using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExtraescolares
{
    public interface IComunicacion
    {
        void Salir();
        void Cargar_Principal(int Rango);
        void Cargar_Alumnos(int rango);
    }
}
