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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using DTO;
using CAD;
using System.Data;

namespace ScrappmindAg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

     

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            DTOUsuario user = new DTOUsuario();
            user.Usuario = txtUsuario.Text;
            user.Clave = txtContrasena.Text;
            CADUsuario datoUser = new CADUsuario();
            DataTable dt = datoUser.autenticarUsuario(user);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Menu ventana = new Menu();

                ventana.Show();

            }
        }
    }
}
