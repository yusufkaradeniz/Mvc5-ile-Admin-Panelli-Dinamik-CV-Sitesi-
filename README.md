# MvcCv - Admin Panelli Dinamik CV Sitesi

Bu depo, ASP.NET MVC 5 mimarisi kullanılarak geliştirilmiş, yönetici paneline sahip dinamik bir özgeçmiş (CV) web uygulamasıdır.

## Proje Hakkında

Proje, kişisel özgeçmiş verilerinin statik sayfalar yerine bir veritabanı üzerinden dinamik olarak yönetilmesini sağlar. Sitede yer alan eğitim bilgileri, iş deneyimleri, yetenekler ve iletişim bilgileri gibi içeriklerin tamamı yönetici (admin) paneli aracılığıyla eklenir, güncellenir veya silinir.

## Kullanılan Teknolojiler

* **Backend:** C#, ASP.NET MVC 5
* **Frontend:** HTML, CSS, JavaScript, SCSS
* **Mimari/Tasarım Deseni:** MVC (Model-View-Controller)

## Temel Özellikler

* **Dinamik Portfolyo Görünümü:** Kullanıcı arayüzüne (UI) yansıyan tüm veriler veritabanından anlık olarak çekilir.
* **Yönetici Paneli (Admin Dashboard):** Özgeçmiş verileri üzerinde CRUD (Create, Read, Update, Delete) işlemlerinin gerçekleştirildiği kimlik doğrulamalı arayüz.
* **Veritabanı Entegrasyonu:** Model sınıfları ile veritabanı tablolarının yönetimi ve Entity Framework üzerinden veri erişimi.

## Kurulum ve Çalıştırma

1.  Depoyu bilgisayarınıza klonlayın:
    ```bash
    git clone https://github.com/yusufkaradeniz/Mvc5-ile-Admin-Panelli-Dinamik-CV-Sitesi-.git
    ```
2.  `MvcCv` klasöründeki çözüm (Solution) dosyasını Visual Studio üzerinden açın.
3.  Projenin veritabanı ile iletişim kurabilmesi için `Web.config` dosyası içerisindeki `connectionString` (bağlantı dizesi) ayarını kendi SQL Server yapılandırmanıza göre düzenleyin.
4.  Package Manager Console üzerinden gerekli paketleri yükleyin veya güncelleyin (`Update-Package -Reinstall`).
5.  Eğer Code-First yaklaşımı kullanılıyorsa `Update-Database` komutunu çalıştırarak veritabanını oluşturun.
6.  Projeyi derleyip (`Ctrl + Shift + B`) çalıştırın (`F5`).
