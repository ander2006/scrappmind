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
using DTO;
using CAD;

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

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            DTOUsuario adm = new DTOUsuario();
            adm.Cedula = txtCedula.Text;
            adm.Usuario = txtUsuario.Text;
            adm.Clave = txtContrasena.Text;

            int valorA;

            if (RadioAdministrador.IsChecked==true)
            {
                valorA = 1;
            }
            else
            {
                valorA = 0;    
            }
            adm.Administrador = valorA;
            int valorP;

            if (Radiooperativo.IsChecked==true)
            {
                valorP = 1;
            }
            else
            {
                valorP = 0;
            }
            adm.Operativo = valorP;

            
           
            CADUsuario datocamp = new CADUsuario();
            datocamp.ingresarUsuario(adm);

            this.Hide();
            Usuarios ventana = new Usuarios();

            ventana.Show();

        }

      

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (FlyoutEliminarusurio.IsOpen == true)
            {
                FlyoutEditUsuario.IsOpen = false;

                DataRowView datarow = (DataRowView)dataGrid.SelectedItem;
                int index = dataGrid.CurrentCell.Column.DisplayIndex;
                string cellvalue = datarow.Row.ItemArray[1].ToString();
                txtCedulaD.Text = cellvalue;

                SqlCommand cmd = new SqlCommand(); // sentencias sql
                cmd.Connection = con;
                cmd.CommandText = "prc_BuscarUsuario";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", txtCedulaD.Text);
                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {

                    txtUsuarioD.Text = sdr["usuario"].ToString();
                    txtContrasenaD.Text = sdr["contrasena"].ToString();
                    string administrador = sdr["administrador"].ToString();
                    int Administrador2 = Convert.ToInt16(administrador);
                    bool adm;
                    if (Administrador2 == 1)
                    {


                        RadioAdministradorD.IsChecked = true;
                    }


                    string operativo = sdr["operativo"].ToString();
                    int operativo2 = Convert.ToInt16(operativo);
                    if (operativo2 == 1)

                    {

                        RadiooperativoD.IsChecked = true;
                    }



                }

                //cerrar conexiòn
                con.Close();


            

        }
            else { 
            FlyoutEditUsuario.IsOpen = true;

            DataRowView datarow = (DataRowView)dataGrid.SelectedItem;
            int index = dataGrid.CurrentCell.Column.DisplayIndex;
            string cellvalue = datarow.Row.ItemArray[1].ToString();
            txtCedulaE.Text = cellvalue;

            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_BuscarUsuario";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", txtCedulaE.Text);
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                txtUsuarioE.Text = sdr["usuario"].ToString();
                txtContrasenaE.Text = sdr["contrasena"].ToString();
                string administrador = sdr["administrador"].ToString();
                int Administrador2 = Convert.ToInt16(administrador);
                bool adm;
                if (Administrador2 == 1)
                {


                    RadioAdministradorE.IsChecked = true;
                }
               

                    string operativo = sdr["operativo"].ToString();
                    int operativo2 = Convert.ToInt16(operativo);
                    if (operativo2 == 1)

                    {

                        RadiooperativoE.IsChecked = true;
                    }
                  

                
            }

            //cerrar conexiòn
            con.Close();


            }

        }

        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void dataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DTOUsuario adm = new DTOUsuario();
            adm.Cedula = txtCedulaE.Text;
            adm.Usuario = txtUsuarioE.Text;
            adm.Clave = txtContrasenaE.Text;

            int valorA;

            if (RadioAdministradorE.IsChecked == true)
            {
                valorA = 1;
            }
            else
            {
                valorA = 0;
            }
            adm.Administrador = valorA;
            int valorP;

            if (RadiooperativoE.IsChecked == true)
            {
                valorP = 1;
            }
            else
            {
                valorP = 0;
            }
            adm.Operativo = valorP;



            CADUsuario datocamp = new CADUsuario();
            datocamp.EditarUsuario(adm);

            this.Hide();
            Usuarios ventana = new Usuarios();

            ventana.Show();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            FlyoutEditUsuario.IsOpen = true;

        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            FlyoutEliminarusurio.IsOpen = true;
          
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_BorrarPersona";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", txtCedulaD.Text);

            con.Open();

            cmd.ExecuteNonQuery();
            //cerrar conexiòn
            con.Close();

            this.Hide();
            Usuarios ventana = new Usuarios();

            ventana.Show();
            //
        }

        private void Tile_Click_5(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_Buscarfiltro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", txtbuscar.Text);

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

        }

        private void Tile_Click_6(object sender, RoutedEventArgs e)
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
        }
    }
}
