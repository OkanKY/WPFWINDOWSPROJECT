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
    /// Interaction logic for Anasayfa.xaml
    /// </summary>
    /// 
    
    public partial class Anasayfa : Window
    {
        private KUAFORLOGIN user;
        private double a;
        public Anasayfa(KUAFORLOGIN user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void Arkaplan_Ayarla(string resim)
        {
            try
            {
                // Create an ImageBrush
                ImageBrush brush = new ImageBrush();

                // Set image source
                brush.ImageSource = new BitmapImage(new Uri("C:\\Users\\okan\\documents\\visual studio 2013\\Projects\\KOAFORWPF\\KOAFORWPF\\resim\\" + resim));

                // Set ImageBrush's Stretch property
                brush.Stretch = Stretch.UniformToFill;

                // Set image brush to Chart Background
                Grid.Background = brush;
            }
            catch (Exception e)
            {
                MessageBox.Show("Arka plan Degiştirelemiyor" + e.Message);
            }

 
        }
        private void Window_Load(object sende, RoutedEventArgs e)
        {  
            this.Title="Hoş Geldin  "+user.UserName;
            Arkaplan_Ayarla("tema1.jpg");
            a = 0;

            Yenile();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
        private void Yenile()
        {
            KuaforDataDataContext conn = new KuaforDataDataContext();
            int tabloCalisan = (from s in conn.CALISANs
                                select s
                                              ).Count();
            int tabloUrun = (from s in conn.URUNs
                             select s
                                           ).Count();
            int tabloIs = (from s in conn.CALISANURUNs
                           select s
                                        ).Count();
            var tabloCalisanaa =
                                 from a in conn.CALISANURUNs
                                 group a by new { a.CALISAN.CalisanID, a.CALISAN.Isim, a.CALISAN.Soyisim } into gp
                                 orderby gp.Count() descending
                                 select new
                                 {
                                     isim = gp.Key.Isim,
                                     SoyIsim = gp.Key.Soyisim,
                                     sayi = gp.Count()
                                 };
            var tabloUrunData =
                           from a in conn.CALISANURUNs
                           group a by new { a.URUN.UrunID, a.URUN.UrunAd, a.URUN.UrunFiyat } into gp
                           orderby gp.Count() descending
                           select new
                           {
                               isim = gp.Key.UrunAd,
                               UrunFiyat = gp.Key.UrunFiyat,
                               sayi = gp.Count()
                           };

            var tabloUrunFiyat =
                from a in conn.CALISANURUNs
                group a by new { a.URUN.UrunAd, a.URUN.UrunFiyat } into gp
                orderby gp.Sum(x => gp.Key.UrunFiyat) descending
                select new
                {
                    isim = gp.Key.UrunAd,
                    fiyat = gp.Sum(x => gp.Key.UrunFiyat)
                };

            var tabloUrunToplamFiyat =
              from a in conn.CALISANURUNs
              group a by new { a.URUN.UrunFiyat } into gp
              select new
              {
                  fiyat = gp.Sum(x => gp.Key.UrunFiyat)
              };

            foreach (var item in tabloUrunToplamFiyat)
            {
                a += double.Parse(item.fiyat.ToString());
            }
            toplamFiyat.Text = a.ToString();
            FiyatData.ItemsSource = tabloUrunFiyat;
            UrunDAta.ItemsSource = tabloUrunData;
            DATA.ItemsSource = tabloCalisanaa;
            calisanBox.Text = tabloCalisan.ToString();
            urunBox.Text = tabloUrun.ToString();
            isBox.Text = tabloIs.ToString();

        }
        private void Calisan_Listele_Click(object sender, RoutedEventArgs e)
        {
            CalisanListele listele =new CalisanListele();
            listele.ShowDialog();

        }
        private void Urun_Listele_Click(object sender, RoutedEventArgs e)
        {
            UrunListele listele = new UrunListele();
            listele.ShowDialog();
        }
        private void Is_Listele_Click(object sender, RoutedEventArgs e)
        {
            IsListele listele = new IsListele();
            listele.ShowDialog();
        }
          private void Calisan_Ayarla_Click(object sender, RoutedEventArgs e)
        {
            CalisanAyarla listele = new CalisanAyarla();
            listele.ShowDialog();
            Window_Load(null, null);
        }
           private void Urun_Ayarla_Click(object sender, RoutedEventArgs e)
        {
           UrunAyarla listele = new UrunAyarla();
            listele.ShowDialog();
            Window_Load(null, null);
        }
          private void Is_Ayarla_Click(object sender, RoutedEventArgs e)
        {
            IsAyarla listele = new IsAyarla();
            listele.ShowDialog();
            Window_Load(null, null);
        }



        private void guncelleButton_Click(object sender, RoutedEventArgs e)
        {
           
            Admin.DeleteTabloUser(user);
            KullaniciGuncelle guncelle = new KullaniciGuncelle();
            guncelle.ShowDialog();
            Window_Load(null, null);
        }

        private void cikisButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Tema1_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema1.jpg");
        }
        private void Tema2_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema2.jpg");
        }
        private void Tema3_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema3.jpg");
        }
        private void Tema4_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema4.jpg");
        }
        private void Tema5_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema5.jpg");
        }
        private void Tema6_Click(object sender, RoutedEventArgs e)
        {
            Arkaplan_Ayarla("tema6.jpg");
        }

        private void yenileButton_Click(object sender, RoutedEventArgs e)
        {
            Window_Load(null, null);
        }
    }
}
