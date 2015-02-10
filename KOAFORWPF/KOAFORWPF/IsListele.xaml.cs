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
    /// Interaction logic for IsListele.xaml
    /// </summary>
    public partial class IsListele : Window
    {
        public IsListele()
        {
            InitializeComponent();
        }
        private void Window_Load(object sende, RoutedEventArgs e)
        {

            KuaforDataDataContext conn = new KuaforDataDataContext();


            var tablo3 = (
                                   from a in conn.URUNs
                                   join s in conn.CALISANURUNs  on a.UrunID equals s.UrunID
                                   join d in conn.CALISANs on s.CalisanID equals d.CalisanID
                                   select new 
                                   {

                                   d.Isim,
                                   d.Soyisim,
                                   d.Cinsiyet,
                                   a.UrunAd,
                                   a.UrunFiyat,

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
    }
}
