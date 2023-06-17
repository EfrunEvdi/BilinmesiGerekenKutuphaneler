# .NET Core Developer - Bilinmesi Gereken Kütüphaneler Kursu

## SOLID Prensipleri

Bu kurs boyunca SOLID prensipleri üzerine odaklandık. SOLID, yazılım tasarımı ve geliştirme sürecinde kaliteli, esnek ve sürdürülebilir bir kod yazmayı hedefleyen bir dizi prensiptir. Aşağıda SOLID prensiplerinin her birini öğrendik ve gerçek senaryolar üzerinde uyguladık:

- **Single Responsibility Principle (Tek Sorumluluk Prensibi)**: Bir sınıfın sadece tek bir sorumluluğu olmalı ve bu sorumluluklar birbirinden bağımsız olmalıdır.

- **Open Closed Principle (Açık Kapalı Prensibi)**: Bir sınıf, mevcut davranışlarını değiştirmeden yeni davranışlar ekleyebilmelidir. Yani, kodu değiştirmeden genişletilebilir olmalıdır.

- **Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)**: Üst sınıflar, türeyen sınıflar tarafından yerine geçilebilir olmalıdır. Yani, bir türeyen sınıf, üst sınıfın yerine geçebilmeli ve aynı şekilde davranabilmelidir.

- **Interface Segregation Principle (Arayüz Ayırma Prensibi)**: İstemciler, ihtiyaç duymadıkları özellikleri içeren büyük arayüzler yerine daha özelleştirilmiş arayüzleri kullanmalıdır.

- **Dependency Inversion Principle (Bağımlılıkları Tersine Çevirme Prensibi)**: Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamalıdır. İlişkiler, soyutlamalar üzerinden kurulmalıdır.

## Kullanılan Kütüphaneler

Bu kurs kapsamında çeşitli kütüphanelerle çalıştık ve bunları gerçek senaryolar üzerinde uyguladık. İşte kullanılan kütüphaneler ve bu kütüphanelerin sunduğu faydalar:

- **FluentValidation**: Giriş verilerinin doğrulamasını kolaylaştıran bir kütüphane. Verileri basit bir şekilde doğrulayabilir ve hata mesajları oluşturabilirsiniz.

- **AutoMapper**: Nesneler arasında kolay veri eşleştirmesi sağlayan bir kütüphane. Sınıf dönüşümlerini otomatikleştirebilir ve veri aktarımını kolaylaştırabilirsiniz.

- **AspNetCoreRateLimit**: API isteklerini sınırlayan ve hız sınırlaması sağlayan bir kütüphane. Uygulamanızdaki isteklerin belli bir oranda sınırlanmasını sağlayabilirsiniz.

- **Smidge**: Web uygulamasında statik dosya yönetimi için kullanılan bir kütüphane. CSS ve JavaScript dosyalarınızı optimize edebilir ve etkin bir şekilde yönetebilirsiniz.

- **Swagger**: API'lar için ayrıntılı belgeleme oluşturan bir kütüphane. API'larınızı belgelendirebilir, test edebilir ve istemcilerin kolayca kullanmasını sağlayabilirsiniz.

- **NLog**: Loglama için kullanılan bir kütüphane. Uygulamanızdaki olayları, hataları ve bilgilendirme mesajlarını kaydedebilir ve analiz edebilirsiniz.

- **Hangfire**: Arka plan görevlerini yönetmek için kullanılan bir kütüphane. Tek bir sunucu üzerinde sürekli çalışan veya zamanlanmış görevleri kolayca yönetebilirsiniz.

## Hata Yönetimi ve Sayfaları

AspNet Core web uygulamalarında hata yönetimi ve hata sayfaları, kullanıcı deneyimini iyileştirmek ve hataların izlenmesini sağlamak için önemlidir. Bu kurs boyunca aşağıdaki konuları öğrendik:

- Hata yönetimi için ASP.NET Core Middleware kullanımı
- Özelleştirilmiş hata sayfalarının oluşturulması
- Hata loglama ve izleme

## Loglama

AspNet Core web uygulamalarında loglama işlemi, uygulamanızın performansını ve güvenilirliğini sağlamak için önemlidir. Bu kurs kapsamında aşağıdaki konuları öğrendik:

- Loglama temel kavramları ve seviyeleri (Debug, Info, Error, vb.)
- Loglama kütüphanelerinin kullanımı (NLog gibi)
- Loglama çeşitleri: dosya tabanlı loglama, veritabanı tabanlı loglama
- Üçüncü taraf loglama servislerinin kullanımı

## Swagger ile Ayrıntılı Dökümantasyon

AspNet Core Web API uygulamalarında Swagger, API'larınızı ayrıntılı bir şekilde belgelemek için kullanabileceğiniz bir araçtır. Bu kurs boyunca aşağıdaki konuları öğrendik:

- Swagger'ın nasıl entegre edileceği ve yapılandırılacağı
- Swagger UI'nin nasıl kullanılacağı
- Ayrıntılı API belgelerinin nasıl oluşturulacağı
- API'lar için parametrelerin, dönüş tiplerinin ve durum kodlarının nasıl belgelendirileceği

## Environment Ortamları

AspNet Core Web uygulamalarında environment ortamları, farklı ortamlarda (geliştirme, test, canlı vb.) çalışmak için kullanılır. Bu kurs kapsamında aşağıdaki konuları öğrendik:

- Hazır environment ortamlarının nasıl kullanılacağı (Development, Staging, Production)
- Özelleştirilmiş environment ortamlarının nasıl oluşturulacağı
- Canlıda environment ortamının nasıl değiştirileceği

## Kurs Detayları

Bu repository, Fatih Çakıroğlu'nun 16 saatlik .NET Core Developer - Bilinmesi Gereken Kütüphaneler kursunu tamamladığımı göstermektedir. Kurs hakkında daha fazla bilgi için [kursun orijinal kaynağına](https://www.udemy.com/course/net-core-developer-bilmesi-gereken-kutuphaneler-konular/) göz atabilirsiniz.
