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
