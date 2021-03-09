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

namespace ProyectoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int res;
            res = 1;
            if (res == 1)
            {
                MenuRecepcionista w = new MenuRecepcionista();
                w.Show();
                this.Hide();
            }
            else if (res == 2)
            {
                MessageBox.Show("Contraseña equivocada");
            }
            else if (res == 3)
            {
                MessageBox.Show("No se encontro al usuario");
            }
        }
    }
}
