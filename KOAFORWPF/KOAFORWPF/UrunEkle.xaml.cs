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

namespace KOAFORWPF
{
    /// <summary>
    /// Interaction logic for UrunEkle.xaml
    /// </summary>
    public partial class UrunEkle : Window
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ekleButton_Click(object sender, RoutedEventArgs e)
        {
            double number;

            if (isimBox.Text.Trim() == "")
            {
                MessageBox.Show("Boş İsim Girilemez");
            }
            else
                if (!double.TryParse(fiyatBox.Text.Trim(), out number))
                {
                    MessageBox.Show("Sayi giriniz ");

                }
                else
                {
                    URUN tablo = new URUN();
                    tablo.UrunAd = isimBox.Text.Trim();
                    tablo.UrunFiyat = number;
                    Admin.AddtabloUrun(tablo);
                    MessageBox.Show("Urun  Eklendi");
                    DialogResult = true;//birazdaha bak
                }
        }

        private void cikisButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

 
    }
}
