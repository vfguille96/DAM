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

namespace PROG_REL9_Ej3_Vera_Guillermo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txbxEscribirNumero.Focus();
            GenerarNumeroDefecto();
        }

        // Declaramos el entero para tener un número aleatorio.
        int numRandom = 0;
        int intentos = 0;

        private void btnGenerarNumero_Click(object sender, RoutedEventArgs e)
        {
            GenerarNumeroDefecto();
        }

        private void GenerarNumeroDefecto()
        {
            GenerarRandom();
            intentos = 0;

            // Desmarcamos el checkbox para no ver el resultado, si está marcado
            DesmarcarChbx();
        }

        private int GenerarRandom()
        {
            Random rnd = new Random();
            numRandom = rnd.Next(0, 101);

            return numRandom;
        }

        private void chbxVerNumero_Click(object sender, RoutedEventArgs e)
        {
            VerNumeroChbx();
        }

        private void VerNumeroChbx()
        {
            if (chbxVerNumero.IsChecked == true)
            {
                txtbkNumero.Visibility = Visibility.Visible;
                txtbkNumero.Text = "=> " + numRandom;
            }

            if (chbxVerNumero.IsChecked == false)
            {
                txtbkNumero.Visibility = Visibility.Hidden;
            }
        }

        private void btnProbar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                intentos += 1;

                if (txbxEscribirNumero == null)
                {
                    MessageBox.Show("Escribe un número a comprobar", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                if (int.Parse(txbxEscribirNumero.Text.ToString()) > 100 || int.Parse(txbxEscribirNumero.Text.ToString()) < 0)
                {
                    MessageBox.Show("Escribe un número entre 1 y 100 a comprobar", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                if (numRandom == int.Parse(txbxEscribirNumero.Text.ToString()))
                {
                    MessageBox.Show("Acertaste en " + intentos + " intentos.");

                    // Resetear random
                    GenerarNumeroDefecto();

                    // Desmarcamos el checkbox para no ver el resultado, si está marcado.
                    DesmarcarChbx();

                    // Limpiamos el texto de ayuda al resultado.
                    LimpiarTxbkResultado();

                    // Limpiamos el valor introducido
                    txbxEscribirNumero.Text = string.Empty;
                    txbxEscribirNumero.Focus();

                } else
                {
                    if (numRandom > int.Parse(txbxEscribirNumero.Text.ToString()))
                    {
                        txbkResultado.Text = "NO, el numero buscado es MAYOR";
                    } else
                    {
                        txbkResultado.Text = "NO, el numero buscado es MENOR";
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Escribe un número entre 1 y 100 a comprobar", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DesmarcarChbx()
        {
            if (chbxVerNumero.IsChecked == true)
            {
                txtbkNumero.Visibility = Visibility.Hidden;
                chbxVerNumero.IsChecked = false;
            }
        }

        private void LimpiarTxbkResultado()
        {
            txbkResultado.Text = string.Empty;
        }
    }
}
