using System;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    public partial class UC_Horario_Dia : UserControl
    {
        public UC_Horario_Dia()
        {
            InitializeComponent();
            comboBox_Horario_Dia1.SelectedIndex = comboBox_Horario_Dia1.FindStringExact("Lunes");
        }

        public string Obtener_Horario_Dia()
        {
            String Dia = comboBox_Horario_Dia1.Text;
            String Hora = numericUpDown_Hora.Text;
            String Minutos = numericUpDown_Minutos.Text;
            if (Hora.Length == 1)
            {
                Hora = "0" + Hora;
            }

            if (Minutos.Length == 1)
            {
                Minutos = "0" + Minutos;
            }

            //-- {Dia,HH:MM,HH:MM}[&Dia,HH:MM,HH:MM][&...]...
            String HorarioDelDia = Dia + "," + Hora + ":" + Minutos;
            return HorarioDelDia;
        }
    }
}