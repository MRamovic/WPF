using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;


namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Artikli> Lista = new ObservableCollection<Artikli>();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = Lista;
            

            
        }

        
        private void Click_bt_Izlaz(object sender, RoutedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li zelite da izadjete?", "Exit", 
                                                        MessageBoxButtons.YesNo , MessageBoxIcon.Question );

            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Dovidjenja!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            else if (dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Odustali ste!");
                }
        }

        private void Click_bt_Ponisti(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Izbrisi(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Izdaj(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Kafa(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Pice(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Hrana(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Kolaci(object sender, RoutedEventArgs e)
        {

        }

        private void Click_bt_Artikli(object sender, RoutedEventArgs e)
        {
            DodajArtikle dodajArtikle = new DodajArtikle();
            dodajArtikle.Visibility = Visibility.Visible;
        }
    }
}
