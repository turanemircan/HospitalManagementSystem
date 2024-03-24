using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.UML
{
    internal class ClassDiagram
    {
        public bool Login(string username, string password)
        {
            // Burada giriş işlemleri gerçekleştirilir.
            // Gerçekleştirilen işleme göre true veya false döndürülür.
            return true; // Örnek olarak true döndürüldü.
        }
    }

    public class Hasta
    {
        private string isim;
        private string soyisim;
        private string tc;
        private string dogumTarihi;
        private string cinsiyet;
        private string telefon;
        private string email;

        public void RandevuAl()
        {
            // Randevu alma işlemleri burada gerçekleştirilir.
        }

        public void RandevuIptal()
        {
            // Randevu iptali işlemleri burada gerçekleştirilir.
        }

        public void BilgiGuncelle()
        {
            // Hasta bilgilerini güncelleme işlemleri burada gerçekleştirilir.
        }

        public void RandevuGecmisiGoruntule()
        {
            // Hasta randevu geçmişini görüntüleme işlemleri burada gerçekleştirilir.
        }
    }

    public class Doktor
    {
        private string isim;
        private string soyisim;
        private string tc;
        private string branş;
        private string telefon;

        public void HastaGoruntule()
        {
            // Doktorun hasta bilgilerini görüntüleme işlemleri burada gerçekleştirilir.
        }

        public void HastaEkle()
        {
            // Doktora hasta ekleme işlemleri burada gerçekleştirilir.
        }

        public void HastaSil()
        {
            // Doktordan hasta silme işlemleri burada gerçekleştirilir.
        }

        public void HastaGuncelle()
        {
            // Hasta bilgilerini güncelleme işlemleri burada gerçekleştirilir.
        }

        public void RandevuGoruntule()
        {
            // Doktorun randevuları görüntüleme işlemleri burada gerçekleştirilir.
        }

        // Diğer metodlar da benzer şekilde devam eder.
    }

    public class Admin
    {
        public void DoktorEkle()
        {
            // Yönetici tarafından doktor ekleme işlemleri burada gerçekleştirilir.
        }

        public void DoktorSil()
        {
            // Yönetici tarafından doktor silme işlemleri burada gerçekleştirilir.
        }

        public void DoktorGuncelle()
        {
            // Yönetici tarafından doktor güncelleme işlemleri burada gerçekleştirilir.
        }

        // Diğer metodlar da benzer şekilde devam eder.

    }
}
