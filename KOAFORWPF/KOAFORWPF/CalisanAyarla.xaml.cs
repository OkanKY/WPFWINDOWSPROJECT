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
    /// Interaction logic for CalisanAyarla.xaml
    /// </summary>
    public partial class CalisanAyarla : Window
    {

        public CalisanAyarla()
        {
            InitializeComponent();
         
        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {

            Yenile();

        }
        public void Yenile()
        {
            KuaforDataDataContext conn = new KuaforDataDataContext();
            List<CALISAN> tablo = (from s in conn.CALISANs
                                   select s).ToList();
            TabloGrid.ItemsSource = tablo;
        }

        private void YenileButton_Click(object sender, RoutedEventArgs e)
        {
            Window_Load(null, null);
        }

        private void cikisButton_Click(object sender, RoutedEventArgs e)
        {
            
            DialogResult = false;
        }

        private void EkleButton_Click(object sender, RoutedEventArgs e)
        {
            CalisanEkle ekle = new CalisanEkle();
            ekle.ShowDialog();
            Window_Load(null, null);
        }

        private void SilButton_Click(object sender, RoutedEventArgs e)
        {
            CALISAN selected = TabloGrid.SelectedItem as CALISAN;
            if (selected == null)
            {
                MessageBox.Show("lütfen gecerli alanı seciniz");
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Emin Misiniz", "tablo silme",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    Admin.DeleteTabloCalisan(selected);
                    Window_Load(null, null);
                }

            }
        }

        private void GuncelleButton_Click(object sender, RoutedEventArgs e)
        {
            CALISAN selected = TabloGrid.SelectedItem as CALISAN;
            if (selected == null)
            {
                MessageBox.Show("lütfen gecerli alanı seciniz");
            }
            else
            {
                CalisanGuncelle guncelle = new CalisanGuncelle(selected);
                guncelle.ShowDialog();
                Window_Load(null, null);
            }
        }
    }
}
