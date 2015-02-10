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
    /// Interaction logic for UrunListele.xaml
    /// </summary>
    public partial class UrunListele : Window
    {
        public UrunListele()
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
    }
}
