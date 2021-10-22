# Hepsiburada Unofficial API

Unofficial Hepsiburada libary

Available plugins

- [x] Login Account
- [x] Create Account

## Example Account Login Code: 

```csharp

using Hepsiburada_API;

 var Giris = Auth.Login("mailadresi@gmail.com", "parola");

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

```



## Example Account Create Code: 

```csharp

using Hepsiburada_API;

  var Kayit = Auth.Register("adiniz", "soyadiniz", "mailadresiniz@gmail.com", "parolaniz");

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

```
