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

namespace ProyectoParcial
{
    /// <summary>
    /// Lógica de interacción para RBuscarMascota.xaml
    /// </summary>
    public partial class RBuscarMascota : Window
    {
        public RBuscarMascota()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MenuRecepcionista w = new MenuRecepcionista();
            w.Show();
            this.Hide();
        }
    }
}
