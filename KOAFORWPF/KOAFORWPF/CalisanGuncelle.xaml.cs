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
    /// Interaction logic for CalisanGuncelle.xaml
    /// </summary>
    public partial class CalisanGuncelle : Window
    {
        private CALISAN tablo;
        public CalisanGuncelle(CALISAN tablo)
        {
            InitializeComponent();
            this.tablo = tablo;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            isimBox.Text= tablo.Isim.ToString();
            soyisimBox.Text = tablo.Soyisim.ToString();
            if (tablo.Cinsiyet == 'E')
            {
                erkekRadio.IsChecked = true;
                bayanRadio.IsChecked = false;
            }
            else
            {
                erkekRadio.IsChecked = false;
                bayanRadio.IsChecked = false;
            }
            tarihPicker.SelectedDate = tablo.Isbaslangic;
        }

        private void ekleButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean kontrol=true;
            if (isimBox.Text.Trim() == "")
            {
                kontrol = false;
                MessageBox.Show("Boş İsim Girilemez");
            }
            if (soyisimBox.Text.Trim() == "")
            {
                kontrol = false;
                MessageBox.Show("Boş Soyİsim Girilemez");
            }
            if(tarihPicker.SelectedDate.Value==null)
            {
                kontrol = false;
                MessageBox.Show("Lütfen Tarih Giriniz");
            }

            if (erkekRadio.IsChecked == true)
            {
                tablo.Cinsiyet = 'E';
            }
            else
                tablo.Cinsiyet = 'K';
            if (kontrol)
            {
                tablo.Isbaslangic = tarihPicker.SelectedDate.Value;
                tablo.Isim = isimBox.Text.Trim();
                tablo.Soyisim = soyisimBox.Text.Trim();
                Admin.UpdatetabloCalisan(tablo);
                MessageBox.Show("Calişan Güncellendi");
                DialogResult = true;//birazdaha bak
            }
        }

        private void cikisButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
