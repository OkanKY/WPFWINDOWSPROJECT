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
    /// Interaction logic for UrunGuncelle.xaml
    /// </summary>
    public partial class UrunGuncelle : Window
    {
        private URUN tablo;
        public UrunGuncelle(URUN tablo)
        {
            InitializeComponent();
            this.tablo = tablo;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            isimBox.Text = tablo.UrunAd;
            fiyatBox.Text = tablo.UrunFiyat.ToString();
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
                    tablo.UrunAd = isimBox.Text.Trim();
                    tablo.UrunFiyat = number;
                    Admin.UpdatetabloUrun(tablo);
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
