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
    /// Interaction logic for UrunAyarla.xaml
    /// </summary>
    public partial class UrunAyarla : Window
    {
        public UrunAyarla()
        {
            InitializeComponent();
        }
        private void Window_Load(object sende, RoutedEventArgs e)
        {

            KuaforDataDataContext conn = new KuaforDataDataContext();
            List<URUN> tablo = (from s in conn.URUNs
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
            UrunEkle ekle = new UrunEkle();
            ekle.ShowDialog();
            Window_Load(null, null);
        }

        private void SilButton_Click(object sender, RoutedEventArgs e)
        {
            URUN selected = TabloGrid.SelectedItem as URUN;
            if (selected == null)
            {
                MessageBox.Show("lütfen gecerli alanı seciniz");
            }
            else
            {
                if (MessageBoxResult.Yes == MessageBox.Show("eminmisiniz", "tablo silme",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning))
                {
                    Admin.DeleteTabloUrun(selected);
                    Window_Load(null, null);
                }

            }
        }

        private void GuncelleButton_Click(object sender, RoutedEventArgs e)
        {
            URUN selected = TabloGrid.SelectedItem as URUN;
            if (selected == null)
            {
                MessageBox.Show("lütfen gecerli alanı seciniz");
            }
            else
            {
                UrunGuncelle guncelle = new UrunGuncelle(selected);
                guncelle.ShowDialog();
                Window_Load(null, null);
            }
        }
    }
}
