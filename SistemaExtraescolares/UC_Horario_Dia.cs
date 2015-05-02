using System;
using System.Windows.Forms;

namespace SistemaExtraescolares
{
    public partial class UC_Horario_Dia : UserControl
    {
        public String Horario { get; set; }

        public UC_Horario_Dia()
        {
            InitializeComponent();
            comboBox_Horario_Dia1.SelectedIndex = comboBox_Horario_Dia1.FindStringExact("Lunes");
        }

        public void Obtener_Horario_Dia()
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
            String HorarioDelDia = Dia + "," + Hora + ":" + Minutos + ",";

            Hora = numericUpDown_Hora2.Text;
            Minutos = numericUpDown_Minutos2.Text;
            if (Hora.Length == 1)
            {
                Hora = "0" + Hora;
            }

            if (Minutos.Length == 1)
            {
                Minutos = "0" + Minutos;
            }
            HorarioDelDia += Hora + ":" + Minutos;
            Horario = HorarioDelDia;
        }
    }
}