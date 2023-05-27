
# Bilinmesi Gereken Kütüphaneler

Bu proje, .Net Core Developer - Bilinmesi Gereken Kütüphaneler kursunda yer alan kütüphaneleri içermektedir.

## Proje Hakkında

Bu proje, .NET Core geliştirme becerilerinizi geliştirmenize yardımcı olacak bir örnek uygulamadır. Projede, aşağıdaki temel kütüphaneleri kullanarak belirli bir işlevselliği uygulamış bulunmaktayız:

- SOLID (NET7)
- FluentValidation
- AutoMapper
- AspNetCoreRateLimit
- Smidge

### Solid Prensipleri
- SOLID Nedir?
- Prensip 1: Tek Sorumluluk Prensibi (SRP)
- Prensip 2: Açık/Kapalı Prensibi (OCP)
- Prensip 3: Liskov Yerine Geçme Prensibi (LSP)
- Prensip 4: Arayüz Ayırma Prensibi (ISP)
- Prensip 5: Bağımlılıkların Tersine Çevrimesi Prensibi (DIP)

#### SOLID Nedir?
SOLID, yazılım mühendisliğinde iyi bir tasarımın temelini oluşturan beş prensibi ifade eder. Bu prensipler, kodun esnek, okunabilir, bakımı kolay, yeniden kullanılabilir ve test edilebilir olmasını sağlar. Aşağıda, bu beş prensip hakkında kısa bir açıklama bulunmaktadır.

#### Prensip 1: Tek Sorumluluk Prensibi (SRP)
Tek Sorumluluk Prensibi, her bir sınıfın ve modülün tek bir sorumluluğu olması gerektiğini belirtir. Bir sınıfın birden fazla sorumluluğu olduğunda, bu sınıfın bakımı zorlaşır ve bağımlılıkları artar. SRP, kodun kolay anlaşılır, test edilebilir ve değiştirilebilir olmasını sağlar.

#### Prensip 2: Açık/Kapalı Prensibi (OCP)
Açık/Kapalı Prensibi, bir sınıfın davranışını değiştirmek için kodu değiştirmek yerine, yeni davranışları ekleyerek genişletilebilir olmasını sağlar. Mevcut kodu değiştirmeden yeni özellikler eklemek, kodun daha sürdürülebilir olmasını sağlar.

#### Prensip 3: Liskov Yerine Geçme Prensibi (LSP)
Liskov Yerine Geçme Prensibi, bir sınıfın, türetilmiş sınıflar tarafından yerine geçilebilir olması gerektiğini belirtir. Yani, bir üst sınıfın yerine alt sınıfı koyduğumuzda programın davranışı değişmemelidir. Bu prensip, kodun doğru çalışmasını ve beklenmedik hataların önlenmesini sağlar.

#### Prensip 4: Arayüz Ayırma Prensibi (ISP)
Arayüz Ayırma Prensibi, bir sınıfın ihtiyaç duymadığı arayüzleri uygulamamasını belirtir. Bir sınıfın gereksiz arayüzleri uygulaması, gereksiz bağımlılıklara ve karmaşıklığa yol açar. ISP, sınıflar arasındaki bağımlılıkları en aza indirir ve esneklik sağlar.

#### Prensip 5: Bağımlılıkların Tersine Çevrimesi Prensibi (DIP)
Bağımlılıkların Tersine Çevrimesi Prensibi, sınıfların somut sınıflara değil, soyutlamalara bağımlı olması gerektiğini belirtir. Yani, yüksek seviyeli modüller, düşük seviyeli modüllerle doğrudan bağımlı olmamalıdır. DIP, gevşek bağımlılıklar oluşturarak kodun test edilebilirliğini, değiştirilebilirliğini ve genişletilebilirliğini artırır.

Bu proje, SOLID prensiplerini anlamak ve uygulamak için mükemmel bir kaynak olan Fatih Çakıroğlu'nun ".Net Core Developer - Bilinmesi Gereken Kütüphaneler" kursuna dayanmaktadır.

Geliştiricilerin bu prensipleri anlaması ve uygun şekilde uygulaması, kodun kalitesini ve sürdürülebilirliğini artırır. SOLID prensipleri, yazılım projelerinde daha iyi bir tasarım yaklaşımı sağlamak için güçlü bir temel oluşturur.

### FluentValidation
FluentValidation, ASP.NET projelerinde kullanılan bir doğrulama kütüphanesidir ve karmaşık doğrulama kurallarını basit ve okunabilir bir şekilde tanımlamayı sağlar.

- FluentValidation Nedir?
- Neden FluentValidation Kullanmalıyız?
- Kurulum
- Kullanım
- Örnekler
- Daha Fazla Kaynak
- Lisans

#### FluentValidation Nedir?
FluentValidation, bir nesnenin doğrulama kurallarını tanımlamak ve uygulamak için kullanılan bir doğrulama kütüphanesidir. ASP.NET projelerinde sıklıkla kullanılır ve karmaşık doğrulama senaryolarını kolayca ele almayı sağlar. FluentValidation, doğrulama kurallarını nesne üzerinde basit ve anlaşılır bir şekilde ifade etmeyi sağlayan bir Fluent API sağlar.

#### Neden FluentValidation Kullanmalıyız?
FluentValidation, doğrulama kodunun daha okunabilir, yönetilebilir ve sürdürülebilir olmasını sağlar. Bazı avantajları şunlardır:

- Karmaşık doğrulama kurallarını basit bir şekilde tanımlama imkanı sağlar.
- İleri düzey doğrulama senaryolarını destekler (örneğin, diğer alanlara bağımlı doğrulamalar).
- Daha kolay hata mesajları özelleştirmesi yapabilirsiniz.
- MVC, Web API gibi ASP.NET projeleriyle sorunsuz bir şekilde entegre olabilir.


#### Kurulum
FluentValidation'ı projenize eklemek için NuGet paket yöneticisini kullanabilirsiniz. Aşağıdaki adımları izleyin:

1) Visual Studio'da projenizi açın.
2) Sağ tıklayın ve "Manage NuGet Packages" seçeneğini seçin.
3) "Browse" sekmesine geçin ve "FluentValidation" arayın.
4) FluentValidation paketini bulun ve projenize eklemek için "Install" düğmesine tıklayın.

#### Kullanım
FluentValidation'ı kullanmak için aşağıdaki adımları takip edebilirsiniz:

1) Doğrulama kurallarını belirlemek için bir doğrulama sınıfı oluşturun.
2) Doğrulama kurallarını bu sınıfta Fluent API ile tanımlayın.
3) Doğrulama kurallarını uygulamak için ilgili model veya istemci tarafından çağrılacak bir doğrulama yöntemi tanımlayın.
4) Doğrulama yöntemini kullanarak nesnenin doğrulanmasını sağlayın.

#### Örnekler
- NotNull(): Bir özelliğin null olmamasını gerektirir.
- NotEmpty(): Bir özelliğin boş veya null olmamasını gerektirir.
- Length(): Bir özelliğin belirli bir karakter uzunluğunda olmasını gerektirir.
- MinimumLength(): Bir özelliğin belirli bir minimum karakter uzunluğunda olmasını gerektirir.
- MaximumLength(): Bir özelliğin belirli bir maksimum karakter uzunluğunda olmasını gerektirir.
- Matches(): Bir özelliğin belirli bir desene uymasını gerektirir.
- InclusiveBetween(): Bir özelliğin belirli bir aralıkta (dahil) olmasını gerektirir.
- ExclusiveBetween(): Bir özelliğin belirli bir aralıkta (hariç) olmasını gerektirir.
- GreaterThan(): Bir özelliğin belirli bir değerden büyük olmasını gerektirir.
- GreaterThanOrEqualTo(): Bir özelliğin belirli bir değere eşit veya büyük olmasını gerektirir.
- LessThan(): Bir özelliğin belirli bir değerden küçük olmasını gerektirir.
- LessThanOrEqualTo(): Bir özelliğin belirli bir değere eşit veya küçük olmasını gerektirir.
- Equal(): Bir özelliğin belirli bir değere eşit olmasını gerektirir.
- NotEqual(): Bir özelliğin belirli bir değere eşit olmamasını gerektirir.
- EmailAddress(): Bir özelliğin geçerli bir e-posta adresi biçiminde olmasını gerektirir.
- CreditCard(): Bir özelliğin geçerli bir kredi kartı numarası biçiminde olmasını gerektirir.
- EnumNameValidator(): Bir özelliğin belirli bir enum türündeki değerlerden biri olmasını gerektirir.

Bu özellikler, FluentValidation'da kullanılan sıkça kullanılan doğrulama özelliklerinin sadece birkaç örneğidir. Projenizin gereksinimlerine göre, özelleştirilmiş doğrulama kuralları oluşturmak için daha fazla seçenek mevcuttur. Daha fazla bilgi için [FluentValidation](https://github.com/FluentValidation/FluentValidation) dökümantasyonuna başvurabilirsiniz.

### Automapper

Automapper, .NET projelerinde nesne eşlemesi (object mapping) işlemlerini kolaylaştıran bir kütüphanedir. Bu kütüphane, bir nesnenin özelliklerini başka bir nesnenin özelliklerine eşlemek için kullanılır ve böylece veri aktarımı ve dönüşümü işlemlerini otomatikleştirir.

Automapper'ın kullanımı basit ve anlaşılırdır. İşte Automapper'ın bazı özellikleri ve kullanım amaçları:

- Nesne Eşlemesi: Automapper, iki nesne arasında özellik eşlemesi yaparak veri transferini otomatikleştirir. Kaynak nesne ve hedef nesne arasındaki benzer özellikler otomatik olarak eşlenir ve değerler aktarılır.

- Veri Dönüşümü: Automapper, farklı veri türleri arasında otomatik dönüşümler gerçekleştirebilir. Örneğin, bir model nesnesindeki tarih alanını, hedef nesnedeki farklı bir tarih formatına dönüştürebilir.

- Kod Tekrarını Azaltma: Automapper, elle tekrarlanması gereken eşleme kodunu azaltır. Manuel olarak her bir özelliği eşlemek yerine, Automapper'ı kullanarak tüm eşleme işlemlerini tek bir yerde tanımlayabilirsiniz.

- Özelleştirilebilirlik: Automapper, özelleştirilebilir bir yapıya sahiptir. Eşleme kurallarını değiştirebilir, özel dönüşüm işlemleri ekleyebilir ve karmaşık eşleme senaryolarını yönetebilirsiniz.

- Performans Optimizasyonu: Automapper, performans açısından optimize edilmiştir. Nesne eşlemesi işlemlerini hızlı ve verimli bir şekilde gerçekleştirir.

Automapper, geliştiricilere veri transferi ve dönüşümü süreçlerini basitleştirerek kod tekrarını azaltma ve daha temiz, daha okunabilir bir kod tabanı oluşturma imkanı sağlar.

Automapper hakkında daha fazla bilgi ve kullanım örnekleri için  [AutoMapper](https://github.com/AutoMapper/AutoMapper) dökümantasyonuna başvurabilirsiniz.

### AspNetCoreRateLimit

AspNetCoreRateLimit, ASP.NET Core projelerinde API isteklerini sınırlamak ve aşırı istekleri engellemek için kullanılan bir kütüphanedir. Bu kütüphane, API'lere gelen istekleri belirli bir zaman dilimi içinde sınırlayarak, aşırı isteklerin önüne geçmeyi sağlar.

AspNetCoreRateLimit'in kullanımı ve özellikleri şunlardır:

- IP Tabanlı Sınırlama: AspNetCoreRateLimit, IP adresine dayalı istek sınırlamaları yapabilir. Her IP adresi için belirli bir zaman dilimi ve istek limiti belirlenerek, aynı IP adresinden gelen isteklerin sınırlanması sağlanır.

- Endpoint Tabanlı Sınırlama: Kütüphane, belirli bir API uç noktasına (endpoint) yönelik yapılan istekleri sınırlayabilir. Her uç nokta için ayrı ayrı istek limitleri ve zaman dilimleri belirlenerek, isteklerin sınırlanması kontrol edilir.

- Sınırlama Hata Durumu: AspNetCoreRateLimit, belirlenen istek sınırlarını aşan isteklerde bir hata durumu döner. Özel bir HTTP durum kodu (HTTP status code) ve hata mesajı ile isteklerin reddedildiğini bildirir.

- Beyaz Liste (Whitelist) ve Siyah Liste (Blacklist): Kütüphane, belirli IP adreslerini beyaz liste veya siyah liste olarak tanımlayarak istek sınırlamasından muaf tutabilir veya sınırlamayı uygulayabilir. Beyaz liste, sınırlamadan muaf tutulan IP adreslerini belirtirken, siyah liste sınırlamaya tabi tutulan IP adreslerini belirtir.

- Özelleştirilebilir Kurallar: AspNetCoreRateLimit, istek sınırlama kurallarını özelleştirmenize izin verir. Her API uç noktası için farklı zaman dilimleri, istek limitleri ve davranışlar belirleyebilirsiniz.

- Gerçek IP Adresi Takibi: Kütüphane, gerçek IP adresini belirten başlık bilgisini takip eder. Bu sayede proxy veya yük dengeleyici gibi ara katmanlardan gelen isteklerde doğru IP adresini tanımlayabilir ve sınırlamaları uygulayabilirsiniz.

AspNetCoreRateLimit, API'lere gelen istekleri sınırlayarak performansı ve güvenliği artırmak için etkili bir çözümdür. Daha fazla bilgi ve kullanım örnekleri için [AspNetCoreRateLimit](https://github.com/stefanprodan/AspNetCoreRateLimit)  dökümantasyonunu inceleyebilirsiniz.

### Smidge
Smidge paketi, web geliştirme projelerinde kullanılan bir JavaScript paketidir. İşlevi, web sayfalarının performansını artırmak için dosya boyutlarını küçültmek ve kaynakları optimize etmektir.

Smidge, web sayfalarında kullanılan CSS ve JavaScript dosyalarını sıkıştırır, birleştirir ve önbelleğe alır. Bu sayede, kullanıcıların web sayfalarını daha hızlı yüklemesi sağlanır. Ayrıca, Smidge, web sayfalarında kullanılan kaynakları gerektiğinde yalnızca yükler, böylece gereksiz yüklemeleri en aza indirir ve veri kullanımını azaltır.

Smidge'in sağladığı bazı özellikler şunlardır:

- Dosya sıkıştırma: CSS ve JavaScript dosyalarını sıkıştırarak dosya boyutlarını küçültür. Bu, sayfa yüklemelerinin daha hızlı olmasını sağlar.

- Dosya birleştirme: Birden fazla CSS veya JavaScript dosyasını tek bir dosya içinde birleştirir. Bu da sayfa yüklemelerini optimize eder.

- Önbellekleme: Smidge, kaynakları önbelleğe alır ve gerektiğinde bu önbelleği kullanır. Bu, sayfa yüklemelerini daha hızlı hale getirir ve sunucu yükünü azaltır.

- Modüler yapı: Smidge, projenin ihtiyaçlarına göre özelleştirilebilir ve modüler bir yapı sunar. Bu sayede sadece gereken özellikler kullanılabilir ve gereksiz ağırlıklardan kaçınılabilir.

Smidge, ASP.NET Core tabanlı web uygulamalarında yaygın olarak kullanılan bir pakettir. Ancak, web geliştirme projelerinde kullanılan diğer teknolojilerde de benzer işlevleri yerine getiren alternatif paketler bulunabilir. Daha fazla bilgi ve kullanım örnekleri için [Smidge](https://github.com/Shazwazza/Smidge)  dökümantasyonunu inceleyebilirsiniz.

