using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaExtraescolares
{
    public partial class Form_Login : Form
    {
        IComunicacion Delegado;
        String ConnectionString;
        SqlConnection Connection;

        public Form_Login(IComunicacion Del)
        {
            InitializeComponent();
            Delegado = Del;
            ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        private void Panel_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Ingresar_Click(object sender, EventArgs e)
        {
            String Usuario = TextBox_Usuario.Text;
            String Password = TextBox_Password.Text;
            try
            {
                Connection.Open();
                String Query = "select * from Usuarios where Usuario = @Usuario and Passwrd = @Passwrd;";
                SqlParameter[] Data = new SqlParameter[2];
                Data[0] = new SqlParameter("@Usuario", Usuario);
                Data[1] = new SqlParameter("@Passwrd", Password);
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddRange(Data);
                using (var DataReader = Command.ExecuteReader())
                {
                    if (DataReader.Read())
                    {
                        Int32 Rango = Convert.ToInt32(DataReader["Rango"]);
                        Delegado.Cargar_Principal(Rango);
                    }
                    else
                    {
                        Label_Alerta.Text = "Mejor suerte para la próxima!";
                    }
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Label_Alerta.Text = ex.Message;
                Connection.Close();
            }
        }
    }
}
