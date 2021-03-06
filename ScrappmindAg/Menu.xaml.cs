﻿using System;
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

namespace ScrappmindAg
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Usuarios ventana = new Usuarios();

            ventana.Show();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Administrador ventana = new Administrador();

            ventana.Show();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reporte ventana = new Reporte();

            ventana.Show();
        }
    }
}
