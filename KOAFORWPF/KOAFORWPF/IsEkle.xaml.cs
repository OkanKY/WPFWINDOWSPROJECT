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
    /// Interaction logic for IsEkle.xaml
    /// </summary>
    public partial class IsEkle : Window
    {
        public IsEkle()
        {
            InitializeComponent();
        }
        private void Window_Load(object sende, RoutedEventArgs e)
        {
            tarihPicker.SelectedDate = DateTime.Now.AddDays(1);
            KuaforDataDataContext conn = new KuaforDataDataContext();
            List<CALISAN> tablo = (from s in conn.CALISANs
                                   select s).ToList();
            TabloGrid.ItemsSource = tablo;

            List<URUN> tablo2 = (from s in conn.URUNs
                                select s).ToList();
          
            TabloGridUrun.ItemsSource = tablo2;


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
            CALISAN selectedCalisan = TabloGrid.SelectedItem as CALISAN;
            URUN selectedUrun = TabloGridUrun.SelectedItem as URUN;
            
            if (selectedCalisan != null)
            {
                
                if (selectedUrun == null)
                {
                    MessageBox.Show("lütfen gecerli Urun alanını seciniz");

                }
                else
                {
                    if (tarihPicker.SelectedDate.Value == null)
                    {
                        MessageBox.Show("Lütfen Tarih Giriniz");
                    }
                    else
                    {
                        CALISANURUN calisanurun = new CALISANURUN();
                        calisanurun.CalisanID = selectedCalisan.CalisanID;
                        calisanurun.UrunID = selectedUrun.UrunID;
                        calisanurun.Tarih = tarihPicker.SelectedDate.Value;
                        Admin.AddtabloIs(calisanurun);
                        MessageBox.Show("İş Eklendi");
                        DialogResult = true;//birazdaha bak
                       
                    }
                }
            }
            else
                MessageBox.Show("lütfen gecerli Calişan alanını seciniz");

          
        }
    }
}
