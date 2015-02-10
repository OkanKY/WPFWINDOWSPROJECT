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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KOAFORWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private KUAFORLOGIN User_Bul()
        {
            UserDataDataContext db = new UserDataDataContext();
            KUAFORLOGIN user = (from u in db.KUAFORLOGINs
                                where u.UserName.Equals(KullaniciAdiTexBox.Text) &&
                                      u.Password.Equals(SifreTexBox.Password)
                                select u).FirstOrDefault();

            return user;
        }
         private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
    {
       if (e.Key == Key.Enter)
       {
           GirisButton_Click(null, null);
       }
    }
        private void GirisButton_Click(object sender, RoutedEventArgs e)
        {

            KUAFORLOGIN user = User_Bul();

            if (user == null)
            {
                // Invalid user name or password
                MessageBox.Show(" Kullanici Adinizi Veya Şifrenizi Tekrardan Giriniz ");
            }
            else
            {
                // Success
                Anasayfa anasayfa = new Anasayfa(user);
                anasayfa.Show();
                this.Hide();
            }
           
        }


    }
}
