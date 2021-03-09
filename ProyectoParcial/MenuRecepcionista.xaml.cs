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

namespace ProyectoParcial
{
    /// <summary>
    /// Lógica de interacción para MenuRecepcionista.xaml
    /// </summary>
    public partial class MenuRecepcionista : Window
    {
        public MenuRecepcionista()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RBuscarMascota w = new RBuscarMascota();
            w.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RBuscarDueno w = new RBuscarDueno();
            w.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RRegistrarDueno1 w = new RRegistrarDueno1();
            w.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RRegistrarMascota w = new RRegistrarMascota();
            w.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            RAgendarCita w = new RAgendarCita();
            w.Show();
            this.Hide();
        }
    }
}
