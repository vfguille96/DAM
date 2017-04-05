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
using System.Threading.Tasks;

namespace PROG_REL9_Ej1_Vera_Guillermo
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
            Environment.Exit(0);
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            CalcularSuma();
        }

        private void CalcularSuma()
        {
            try
            {
                double n = 0;
                n = double.Parse(tbIntroduce.Text);
                double suma = 0;


                if (n < 0)
                {
                    MessageBox.Show("El número introducido es negativo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    for (int i = 0; i <= n; i++)
                    {
                        suma = suma + i;
                    }

                    MessageBox.Show("Resultado: " + suma);
                }
            }
            catch
            {
                MessageBox.Show("Formato incorrecto.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tbIntroduce_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }


    }
}
