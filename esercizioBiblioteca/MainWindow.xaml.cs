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

namespace esercizioBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca b;

        public MainWindow()
        {
            InitializeComponent();

            b = new Biblioteca("biblioteca", "via aaa");

            lblNTot.Content=Convert.ToString(b.LibriTotali());
        }

        private void bttCrea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = new Libro(txtAutore.Text, txtTitolo.Text, int.Parse(txtAnno.Text), txtEditore.Text, int.Parse(txtNPag.Text));

                b.AggiungiLibro(l);

            }catch(Exception ex)
            {
                MessageBox.Show("errore: " + ex.Message);
            }
        }

        private void bttCerca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lstLibri.ItemsSource = null;

                if (rdbTitolo.IsChecked == true)
                {
                    lstLibri.ItemsSource = (System.Collections.IEnumerable)b.RicercaPerTitolo(txtCerca.Text);
                }
                else if (rdbAutore.IsChecked == true)
                {
                    lstLibri.ItemsSource = b.RicercaLibriPerAutore(txtCerca.Text);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("errore: " + ex.Message);
            }
        }
    }
}
