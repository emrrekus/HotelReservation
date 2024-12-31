# Otel Rezervasyon Sistemi

Modern ve kullanıcı dostu bir web uygulaması olan **Otel Rezervasyon Sistemi**, kullanıcıların destinasyon bazlı otel araması yapmasına, otel detaylarını incelemesine ve hızlıca rezervasyon gerçekleştirmesine olanak tanır.

![Otel Rezervasyon Sistemi Ana Sayfa](https://github.com/user-attachments/assets/fec64383-9e64-4525-b1a0-92933c7ec7ea)

## İçindekiler
1. [Özellikler](#özellikler)
2. [Teknolojiler](#teknolojiler)
3. [Kurulum ve Çalıştırma](#kurulum-ve-çalıştırma)
4. [Proje Yapısı](#proje-yapısı)
5. [Ekran Görüntüleri](#ekran-görüntüleri)
6. [Katkıda Bulunma](#katkıda-bulunma)
7. [Lisans](#lisans)

---

## Özellikler
- **Destinasyon Bazlı Otel Arama**  
  Şehir veya bölge bilgisine göre otel listesini görüntüleme.
- **Detaylı Otel Bilgileri**  
  Her otele ait oda detayları, fiyat bilgisi ve yorumların görüntülenmesi.
- **Kolay Rezervasyon Yönetimi**  
  Kullanıcıların rezervasyonlarını yapmasına, iptal etmesine veya güncellemesine olanak sağlar.
- **Kullanıcı Dostu Arayüz**  
  Basit ve modern tasarım sayesinde hızlı ve sezgisel kullanım imkânı.

---

## Teknolojiler
Proje geliştirilirken aşağıdaki teknolojiler ve araçlar kullanılmıştır:

- **ASP.NET Core (.NET 6.0)**  
  Web uygulamasının ana çatısını oluşturur.
- **Entity Framework Core**  
  Veritabanı işlemleri (CRUD) için kullanılır.
- **C#**  
  İş mantığı ve controller katmanını yönetmek için.
- **HTML/CSS/JavaScript**  
  Kullanıcı arayüzü ve etkileşimler.
- **Rapid API Consume**  
  API verilerini çağırmak ve işlemekte kullanılır.
- **Booking API**  
  Otel bilgilerini ve rezervasyon detaylarını almak için entegre edilmiştir.

---
## Proje Yapısı
HotelsReservation.WebUI/
├── Controllers/
│   └── DefaultController.cs        # Ana sayfa ve yönlendirme işlemlerini yönetir.
├── Models/
│   ├── DestinationModel.cs         # Destinasyon bilgileri model sınıfı.
│   └── HotelsViewModel.cs          # Otel listeleme ve görüntüleme ile ilgili model sınıfı.
└── Views/
    └── Default/
        ├── Index.cshtml            # Ana sayfa görüntüleme.
        └── HotelList.cshtml        # Otel listesi ve detayları gösterimi.




