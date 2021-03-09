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
    /// Lógica de interacción para RRegistrarMascota.xaml
    /// </summary>
    public partial class RRegistrarMascota : Window
    {
        public RRegistrarMascota()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuRecepcionista w = new MenuRecepcionista();
            w.Show();
            this.Hide();
        }
    }
}
