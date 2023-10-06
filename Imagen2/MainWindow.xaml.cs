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

namespace Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonAlta_Checked(object sender, RoutedEventArgs e)
        {
            if(botonAlta.IsChecked == true)
                imagen.Opacity = 1;
        }

        private void BotonMedia_Checked(object sender, RoutedEventArgs e)
        {
            if (botonMedia.IsChecked == true)
                imagen.Opacity = 0.6;
        }

        private void BotonBaja_Checked(object sender, RoutedEventArgs e)
        {
            if (botonBaja.IsChecked == true)
                imagen.Opacity = 0.3;
        }

        private void BotonRelleno_Checked(object sender, RoutedEventArgs e)
        {
            if (botonRelleno.IsChecked == true)
                imagen.Stretch = Stretch.Fill;
        }

        private void BotonUniforme_Checked(object sender, RoutedEventArgs e)
        {
            if (botonUniforme.IsChecked == true)
                imagen.Stretch = Stretch.Uniform;
        }

        private void BotonRellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            if (botonRellenoUniforme.IsChecked == true)
                imagen.Stretch = Stretch.UniformToFill;
        }

        private void BotonSinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            if (botonSinAjuste.IsChecked == true)
                imagen.Stretch = Stretch.None;
        }
    }
}
