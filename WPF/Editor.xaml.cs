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
using System.Collections.ObjectModel;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Click_bt_Izlaz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Click_bt_Sacuvaj(object sender, RoutedEventArgs e)
        {
            if (DataContext is ObservableCollection<Artikli> kolekcija)
            {
                if (string.IsNullOrEmpty (txt_naziv.Text) &&
                    string.IsNullOrEmpty(txt_kolicina.Text) &&
                    string.IsNullOrEmpty(txt_cena.Text))
                {
                    MessageBox.Show("Greska u unosu!");
                }else
                {
                    kolekcija.Add(new Artikli(txt_naziv.Text, int.Parse(txt_kolicina.Text), decimal.Parse(txt_cena.Text)));
                }
            }
            else
            {
                BindingOperations.GetBindingExpression(txt_naziv, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(txt_kolicina, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(txt_cena, TextBox.TextProperty).UpdateSource();
                this.Close();
            }
            this.Close();
        }
    }
}
