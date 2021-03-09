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
    /// Lógica de interacción para RRegistrarDueno1.xaml
    /// </summary>
    public partial class RRegistrarDueno1 : Window
    {
        public RRegistrarDueno1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuRecepcionista w = new MenuRecepcionista();
            w.Show();
            this.Hide();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
