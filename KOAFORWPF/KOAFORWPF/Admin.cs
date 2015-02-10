using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOAFORWPF
{
    public static class Admin
    {
        #region
        public static void AddtabloCalisan(CALISAN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                conn.CALISANs.InsertOnSubmit(tablo);
                conn.SubmitChanges();
            }
        }
        public static void UpdatetabloCalisan(CALISAN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                CALISAN tab = (from s in conn.CALISANs
                             where s.CalisanID == tablo.CalisanID
                             select s).FirstOrDefault();
                tab.CalisanID = tablo.CalisanID;
                tab.Isim = tablo.Isim;
                tab.Soyisim = tablo.Soyisim;
                tab.Isbaslangic = tablo.Isbaslangic;
                tab.Cinsiyet= tablo.Cinsiyet;

                conn.SubmitChanges();
            }
        }
        public static void DeleteTabloCalisan(CALISAN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                CALISAN tab = (from s in conn.CALISANs
                               where s.CalisanID == tablo.CalisanID
                             select s).FirstOrDefault();
                conn.CALISANs.DeleteOnSubmit(tab);
                conn.SubmitChanges();
            }
        }
        public static void AddtabloUrun(URUN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                conn.URUNs.InsertOnSubmit(tablo);
                conn.SubmitChanges();
            }
        }
        public static void UpdatetabloUrun(URUN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                URUN tab = (from s in conn.URUNs
                               where s.UrunID == tablo.UrunID
                               select s).FirstOrDefault();
                tab.UrunID = tablo.UrunID;
                tab.UrunAd = tablo.UrunAd;
                tab.UrunFiyat = tablo.UrunFiyat;

                conn.SubmitChanges();
            }
        }
        public static void DeleteTabloUrun(URUN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                URUN tab = (from s in conn.URUNs
                               where s.UrunID == tablo.UrunID
                               select s).FirstOrDefault();
                conn.URUNs.DeleteOnSubmit(tab);
                conn.SubmitChanges();
            }
        }
        public static void AddtabloIs(CALISANURUN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                conn.CALISANURUNs.InsertOnSubmit(tablo);
                conn.SubmitChanges();
            }
        }

        public static void DeleteTabloIs(CALISANURUN tablo)
        {
            using (KuaforDataDataContext conn = new KuaforDataDataContext())
            {
                CALISANURUN tab = (from s in conn.CALISANURUNs
                            where s.CalisanUrunID == tablo.CalisanUrunID
                            select s).FirstOrDefault();
                conn.CALISANURUNs.DeleteOnSubmit(tab);
                conn.SubmitChanges();
            }
        }
        public static void DeleteTabloUser(KUAFORLOGIN tablo)
        {
            using (UserDataDataContext conn = new UserDataDataContext())
            {
                KUAFORLOGIN tab = (from s in conn.KUAFORLOGINs
                            where s.UserName == tablo.UserName
                            select s).FirstOrDefault();
                conn.KUAFORLOGINs.DeleteOnSubmit(tab);
                conn.SubmitChanges();
            }
        }
        public static void AddtabloUser(KUAFORLOGIN tablo)
        {
            using (UserDataDataContext conn = new UserDataDataContext())
            {
                conn.KUAFORLOGINs.InsertOnSubmit(tablo);
                conn.SubmitChanges();
            }
        }
        #endregion

    }
}
