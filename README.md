##Chat Projesi

# Giriş Ekranı 

Bu proje, basit bir giriş ekranı uygulamasını içermektedir. Kullanıcılar, giriş ekranında kullanıcı adı, telefon numarası ve şifre bilgilerini girebilmektedir. Bu bilgiler, bir SQL Server veri tabanına kaydedilmekte ve kullanıcıya benzersiz bir ID atanmaktadır.

## Temel Yapı

- **Form2 Sınıfı:** Ana form sınıfını temsil eder. Kullanıcı bilgilerini kaydetme ve güncelleme işlevlerini içerir.
- **GetUniqueID Metodu:** Benzersiz bir ID oluşturan metodur. GUID kullanarak bir integer değeri döndürür.
- **UpdateDatabase Metodu:** Veri tabanında belirli bir sütunu güncellemek için kullanılan genel metodur.
- **button4_Click Metodu:** Form1'e dönme işlevini gerçekleştirir.

## Kullanılan Teknolojiler

- **C#:** Uygulama, C# programlama dili kullanılarak geliştirilmiştir.
- **Windows Forms:** Kullanıcı arayüzü, Windows Forms kütüphanesi kullanılarak tasarlanmıştır.
- **SQL Server:** Veri tabanı işlemleri için SQL Server kullanılmıştır.

## Veritabanı Bağlantısı

- **BaglantiDizesi:** SQL Server veri tabanına bağlanmak için kullanılan bağlantı dizesini içerir.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Ayrıntılar için [LİSANS](./LİSANS) dosyasına bakınız.

---

**MIT License**

Telif Hakkı (c) [2023] [Badel May]

Bu yazılım ve belgelendirme dosyaları ("Yazılım"), aşağıdaki koşullara tabidir:

Yazılımın kopyalanması, değiştirilmesi, birleştirilmesi, yayılması, yayınlanması, alt lisans verilmesi ve/veya satılması için herhangi bir kişiye veya kuruluşa karşı burada yazılı belirli izinler ve sınırlamalar dâhilinde verilmektedir.

YAZILIM "AS-IS" TEMİNATI İLE BERABER, HİÇBİR TÜRLÜ GARANTİ VERİLMEMEKTEDİR, TİCARETE ELVERİŞLİLİK, BELİRLİ BİR AMACA UYGUNLUK VE İHLAL OLMAMASI GİBİ İMLİ VEYA ZIMNİ GARANTİLER DE DAHİL OLMAK ÜZERE, FAKAT BUNLARLA SINIRLI OLMAMAK ÜZERE HER TÜRLÜ GARANTİ VEYA ŞART TÜRLERİ DIŞLANMIŞTIR. HİÇBİR KOŞULDA YAZARLAR VEYA TELİF HAKKI SAHİPLERİ HERHANGİ BİR TALEP, ZARAR VEYA DİĞER YÜKÜMLÜLÜK İLE İLGİLİ OLARAK, SÖZLEŞME, HAKSIZ FİİL VEYA DİĞER EYLEM KAYNAKLI, SÖZLEŞME DIŞI VEYA BAŞKA BİR ŞEKİLDE HERHANGİ BİR SORUMLULUK TAŞIMAZ VEYA BU KÜÇÜK İŞİN KULLANIMI VEYA BAĞLANTI İLGİLİ OLARAK TÜM İDDİALAR İÇİN SORUMLULUK KABUL ETMEZLER.
