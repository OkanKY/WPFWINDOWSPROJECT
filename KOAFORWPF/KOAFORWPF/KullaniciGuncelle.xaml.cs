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
    /// Interaction logic for KullaniciGuncelle.xaml
    /// </summary>
    public partial class KullaniciGuncelle : Window
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, RoutedEventArgs e)
        {
            KUAFORLOGIN tablo = new KUAFORLOGIN();
            if (KullaniciAdiTexBox.Text.Trim() == "")
            {
                MessageBox.Show("Boş İsim Girilemez");
            }
            else
                if (SifreTexBox.Text.Trim() == "")
                {
                    MessageBox.Show("Boş Şifre Girilemez");
                }
                else
                {
                    tablo.UserName = KullaniciAdiTexBox.Text.Trim();
                    tablo.Password = SifreTexBox.Text.Trim();
                    Admin.AddtabloUser(tablo);
                    MessageBox.Show("Kullanici Bilgileri Güncellendi");
                    DialogResult = true;//birazdaha bak
                }
        }

        private void degistirButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
