# WebApplication
kendime eğitim notu

# DOMAIN
Proje içinde oluşturulan entity'ler veri tabanı nesnelerini oluşturmaya yarıyor.
Domain'deki entities DB'de tablolarımıza denk geliyor. 
Domain'de entities tanımlarken DB'de tablolar arası 1-1 ve 1-N'lik ilişki tanımlanması için gerekli şekilde tanımlanmalı 

Entity Framework'te eager loading ve lazyloading yapılıyor.
eager loading: Tüm ilişkileri getiriyor, ihtiyaç olması veya olmaması farketmiyıor.
lazyloading: İhtiyaç olduğunda arkadaki sorgudan data'ları çekiyor. Önemli bir kuralı mevcut: Arkada proxy kullanabilmesi için kullanılan property'nin "virtual" ile belirtilmesi gerekiyor(override edilebileceğini belirtiyoruz gibi.).

-Entity framework kendisi bir foreign key oluşturuyor ve tabloları bağlayabiliyor, virtual anahtar kelimesi sayesinde. Karışıklık olmaması ve daha açık olmaası için aşağıdaki gibi tanımlanabilir. Category Id kendimiz verebiliriz, entity framework'un bu alanı pass geçmesi için ForeignKey attribute'nu veriyoruz.
-Category property'sine göre 1 product'ın 1 category'si olmalı

![image](https://user-images.githubusercontent.com/88982457/139145648-94c33858-4d98-49a2-8848-1954e5624e1f.png)

ICollection ile çokluk ilişkisi sağlanıyor. Product ile arasında N'lik bir ilişki tanımlanıyor. Sonuç olarak, product-1,category-N ilişkisi (1-N) sağlanıyor.

![image](https://user-images.githubusercontent.com/88982457/139147499-7747cbf0-a44d-4cd7-9928-41aea3444c05.png)

# DBContext
appsettinhs.json dosyası içerisine Connection string tanımlanıyor.
con. string ismi:"PostgresConnection", port, dbismi, username ve password vb. Db tanımları yapılıyor.

![image](https://user-images.githubusercontent.com/88982457/139148099-a53f70eb-25fd-4104-b1c1-c0d0c40a9ac3.png)

DbContext service'ni api veya ınfrastructure katmanlarında yapılabilir. Ayar dosyalarını kodu dışarıdan ulaşılabilecek bir yerde tanımlama iyidir(startup dosyası-->API). Infrastructure'da tanımlanırsa da bağımlılık azaltırAPI'ın ınfras. katmanına bağlanma zorunluluğu ,dbcontext için ortadan kalkar.

extension olduğu için metod ve class static olmalı.
microsoft.extension.configurations NuGet eklenmeli.

![image](https://user-images.githubusercontent.com/88982457/139149213-a015c916-f09d-4200-a39d-4540bfd0b746.png)

Dbset'in generiğine kullanılan sınıfı sonrasına da tablonun ismi veriliyor.  Migration yapıldığında tablolar oluşuyor.

![image](https://user-images.githubusercontent.com/88982457/139151143-6ba70f06-c9a4-41a9-87d2-e16bf8a0abb5.png)

