Özellikler
- Satış verisi yönetimi: Ürün adı, satış tarihi, miktar, tutar ve şehir bilgileriyle satışlar kaydedilir.
- Performans odaklı: LINQ sorguları EF Core tarafından veritabanında çalıştırılır, gereksiz veritabanı yükü azaltılır.
- Kolay genişletilebilirlik: Yeni özellikler eklemek için mimari temiz ve modüler olarak tasarlandı.
- MySQL destekli: MySQL veritabanı bağlantısı ve migration sistemi ile kolayca kullanılabilir.


Teknolojiler
- ASP.NET Core (Web API)
- Entity Framework Core (MySQL Provider)
- MySQL
- C#
- Postman (API testleri için)


Kurulum & Çalıştırma
1) Projeyi klonlayın:
git clone https://github.com/gamzekarakurt8/sales-analysis-api,
cd sales-analysis-api

2) MySQL veritabanı oluşturun:
salesdb isimli bir veritabanı açın.

3) Connection string’i güncelleyin:
appsettings.json içinde kendi MySQL bağlantı bilgilerinizle değiştirin.

4) Entity Framework Migration ve Database Update:
dotnet ef database update

5) Projeyi çalıştırın:
dotnet run

6) API’yi test edin:
Postman veya benzeri araçla API endpoint’lerini kullanabilirsiniz.

