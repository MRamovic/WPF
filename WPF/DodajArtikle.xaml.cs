﻿using System;
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
    /// Interaction logic for DodajArtikle.xaml
    /// </summary>
    public partial class DodajArtikle : Window
    {
        public DodajArtikle()
        {
            InitializeComponent();
            //dg_dodaj.ItemsSource=Lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor();
            editor.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor();
            editor.Visibility = Visibility.Visible;
        }
    }
}
