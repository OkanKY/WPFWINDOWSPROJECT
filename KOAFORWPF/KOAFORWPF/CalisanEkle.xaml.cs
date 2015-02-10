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
    /// Interaction logic for CalisanEkle.xaml
    /// </summary>
    public partial class CalisanEkle : Window
    { 
       
        public CalisanEkle()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tarihPicker.SelectedDate = DateTime.Now.AddDays(1);
        }

        private void ekleButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean kontrol = true;
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
            if (tarihPicker.SelectedDate.Value == null)
            {
                kontrol = false;
                MessageBox.Show("Lütfen Tarih Giriniz");
            }
            CALISAN tablo = new CALISAN();
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
                Admin.AddtabloCalisan(tablo);
                MessageBox.Show("Kişi Eklendi");
               
                DialogResult = true;//birazdaha bak
               
            }
        }
    }
}
