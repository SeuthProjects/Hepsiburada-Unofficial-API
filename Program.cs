using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepsiburada_API;

namespace Hepsiburada_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Giris = Auth.Login("kullanicimaili00@gmail.com", "Parola0000x");

            if (Giris.Result.Contains("1"))
            {
                //Giriş Başarılı!

                Console.Write("Giriş Başarılı!");
            }
            else if (Giris.Result.Contains("2"))    
            {
                //Giriş Başarısız!

                Console.Write("Giriş Başarısız!");
            }
            else
            {
                //Bir Hata oluştu!

                Console.Write("Bir Hata oluştu!");
            }

           

            var Kayit = Auth.Register("Ad", "Soyad", "kullanicimaili00@gmail.com", "Parola0000x");

            if (Kayit.Result.Contains("1"))
            {
                //Kayıt Başarılı
                
                Console.Write($"Hesap oluşturuldu!\n\nMail Adresi : {Config.Mail}\nParolanız : {Config.Parola}");
            }
            else if (Kayit.Result.Contains("2"))
            {
                //Kayıt Başarısız

                Console.Write("Hesap oluşturulamadı, lütfen geçerli 'Email veya Parolanızı' doğru biçimde girdiğinizden emin olun!");
            }
            else
            {
                //Bir hata oluştu

                Console.Write("Bir hata oluştu!");
            }

            Console.ReadKey();
        }
    }
}
