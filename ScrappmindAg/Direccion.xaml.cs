using System;
using DTO;
using CAD;
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

namespace ScrappmindAg
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            DTODireccion dir = new DTODireccion();
            dir.Codigo = Convert.ToInt32(txtcodigo.Text);
            dir.Direccion = txtdireccion.Text;
            CADDireccion datodir = new CADDireccion();
            datodir.guardarDireccion(dir);
        }
    }
}
