using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls.Dialogs;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ScrappmindAg
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : MetroWindow
    {
        static string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
        SqlConnection con = new SqlConnection(cadena);

        public Usuarios()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_ListarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            // tabla virtual; permite almacenar datos que vienen en la consulta
            DataTable dt = new DataTable();
            // adaptador: permite ejecutar consultas y descargar
            //su resultado es un objeto (datatable)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            // ejecuta la consulta
            //En este punto dt contiene los resultador de la consulta
            sda.Fill(dt);
            // llena el datagridiew con los datos del dt ( tabla vistual)
            dataGrid.ItemsSource = dt.DefaultView;
            sda.Update(dt);



            //cerrar conexiòn
            con.Close();
            //  
        }
        

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_ListarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            // tabla virtual; permite almacenar datos que vienen en la consulta
            DataTable dt = new DataTable();
            // adaptador: permite ejecutar consultas y descargar
            //su resultado es un objeto (datatable)
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            // ejecuta la consulta
            //En este punto dt contiene los resultador de la consulta
            sda.Fill(dt);
            // llena el datagridiew con los datos del dt ( tabla vistual)
            dataGrid.ItemsSource = dt.DefaultView;
            sda.Update(dt);



            //cerrar conexiòn
            con.Close();
            //  

        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Flyoutusuario.IsOpen = true;
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu ventana = new Menu();

            ventana.Show();
        }
    }
}
