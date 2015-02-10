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
    /// Interaction logic for IsAyarla.xaml
    /// </summary>
    public partial class IsAyarla : Window
    {
     
        public IsAyarla()
        {
            InitializeComponent();
        }
        private void Window_Load(object sende, RoutedEventArgs e)
        {
            KuaforDataDataContext conn = new KuaforDataDataContext();

            var tablo3 = (
                                   from a in conn.URUNs
                                   join s in conn.CALISANURUNs on a.UrunID equals s.UrunID
                                   join d in conn.CALISANs on s.CalisanID equals d.CalisanID
                                   select new CalisanUruns()
                                   {
                                       CalisanUrunID = s.CalisanUrunID,
                                       Isim = d.Isim,
                                       SoyIsim = d.Soyisim,
                                       Cinsiyet = d.Cinsiyet,
                                       UrunAd = a.UrunAd,
                                       UrunFiyat = a.UrunFiyat
                                   }

                           );
            TabloGridUrun.ItemsSource = tablo3;


        }

        private void YenileButton_Click(object sender, RoutedEventArgs e)
        {
            Window_Load(null, null);
        }

        private void cikisButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ekleButton_Click(object sender, RoutedEventArgs e)
        {
            IsEkle ayarla=new IsEkle();
            ayarla.ShowDialog();
            Window_Load(null, null);

        }

        private void silButton_Click(object sender, RoutedEventArgs e)
        {
            CalisanUruns selected = TabloGridUrun.SelectedItem as CalisanUruns;
            CALISANURUN urun = new CALISANURUN();
            urun.CalisanUrunID = selected.CalisanUrunID;
            urun.CalisanID = 1;
            urun.UrunID=1;


            if (selected == null)
            {
                MessageBox.Show("lütfen gecerli alanı seciniz");
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("eminmisiniz", "tablo silme",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {

                    Admin.DeleteTabloIs(urun);
                    Window_Load(null, null);
                }

            }
        }
    }
}
