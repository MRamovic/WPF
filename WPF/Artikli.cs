using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    class Artikli : INotifyPropertyChanged
    {
        private string naziv;
        private int kolicina;
        private decimal cena;

        public string Naziv
        {
            get => naziv;

            set
            {
                naziv = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Naziv"));       
            }
        }

        public int Kolicina
        {
            get => kolicina;

            set
            {
                kolicina = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Kolicina"));
            }
        }

        public decimal Cena
        {
            get => cena;

            set
            {
                cena = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cena"));
            }
        }

        public Artikli (string n, int k, decimal c)
        {
            Naziv = n;
            Kolicina = k;
            Cena = c;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
