# ApiBooks Projesi

**Proje Hakkında:**  
ApiBooks, kitap yönetimi ve keşif platformudur. Kullanıcılar, öne çıkan kitapları keşfedebilir, rastgele kitap önerileri alabilir ve kategorilere göre kitapları inceleyebilirler. Admin paneli üzerinden kitaplar, yazarlar ve kategoriler yönetilebilir. Bu proje, **ASP.NET Core 6.0**, **MSSQL** ve **Entity Framework** kullanılarak geliştirilmiştir. Proje, aynı zamanda **N Katmanlı Mimari** ve **API** yapısı ile esnek ve sürdürülebilir bir yapı sunar.

## 🚀 Kullanılan Teknolojiler ve Araçlar:

- **ASP.NET Core 6.0**: Modern ve güçlü bir framework ile uygulama geliştirilmiştir.
- **MSSQL Veritabanı**: Dinamik veri yönetimi için tercih edilmiştir.
- **Entity Framework (Code First)**: Veritabanı işlemleri için hızlı ve etkili bir çözüm sunar.
- **Swagger**: API dokümantasyonu ve test işlemleri için kullanıcı dostu bir arayüz sağlar.
- **LINQ**: Veritabanı işlemleri için güçlü sorgulama desteği sunar.
- **DTOs (Data Transfer Objects)**: Veri aktarımı sırasında güvenlik ve performans için özel nesneler kullanılmıştır.
- **Repository Design Pattern**: Daha temiz ve sürdürülebilir kod geliştirme imkanı sağlar.
- **Dependency Injection**: Daha az bağımlılık ve daha iyi test edilebilirlik sağlar.

## 🎨 Kullanıcı Arayüzü Özellikleri:

- **Feature Slider**: API’den alınan öne çıkan kitapları dinamik olarak kaydırarak kullanıcıların dikkatini çeker.
- **En Yeni Kitaplar**: Son eklenen 4 kitap listelenir.
- **Rastgele Kitap Önerisi**: Sayfa her yenilendiğinde farklı bir kitap önerisi sunulur.
- **Kategori Bazlı Kitap Koleksiyonu**: Kitaplar dinamik kategorilere göre listelenir.
- **İlham Verici Sözler**: Kitaplar ve yazarlar hakkında ilham veren ve okumaya teşvik eden sözler her sayfa yenilendiğinde değişir.
- **Sürpriz %20 İndirim**: Rastgele 4 kitap seçilip %20 indirim uygulanır.
- **Popüler Yazarlar**: En fazla kitabı bulunan ilk 3 yazar dinamik olarak sıralanır.

## 🛠️ Admin Paneli Özellikleri:

- **Dashboard**: Öne çıkan kitap sayısı, toplam kitap, yazar ve kategori bilgileri anlık olarak görüntülenir.
- **Kitap Yönetimi**: CRUD işlemleri ile kitaplar yönetilebilir. Kitap eklerken, mevcut yazarlar ve kategoriler sistem üzerinden seçilir.
- **Kategori Yönetimi**: CRUD işlemleri ile kategoriler eklenebilir, düzenlenebilir ve silinebilir.
- **Yazar Yönetimi**: Yazarlar listelenebilir, düzenlenebilir ve yeni yazar eklenebilir.
- **Öne Çıkan Kitaplar**: API üzerinden çekilir, admin panelinden değiştirme imkanı yoktur.
  
### Veritabanı Şeması
![image](https://github.com/user-attachments/assets/a55f5262-d79f-4591-b492-456e2611aa85)

### API Yapısı ve İşleyişi
![screencapture-localhost-7051-swagger-index-html-2025-01-27-03_10_31](https://github.com/user-attachments/assets/e4a54fe6-5a25-40ae-b0c9-9cc78fded74b)

### Ana Sayfa: Görsel
![screencapture-localhost-7118-Layout-Index-2025-01-27-03_20_23](https://github.com/user-attachments/assets/d4a5b89b-9043-4a1b-a25e-3c1ea207b7e2)

### Admin Paneli: Görseller
![screencapture-localhost-7118-Admin-DashBoard-DashBoardIndex-2025-01-27-03_12_53](https://github.com/user-attachments/assets/044bff8f-7ed1-429b-aa6f-08022416b4e0)
![screencapture-localhost-7118-Admin-Feature-FeatureList-2025-01-27-03_13_18](https://github.com/user-attachments/assets/1d669dbd-e638-4664-b693-172a5420d500)
![screencapture-localhost-7118-Admin-Categories-CategoryList-2025-01-27-03_13_36](https://github.com/user-attachments/assets/67e873a7-32e9-462a-9462-5901a38305f5)
![screencapture-localhost-7118-Admin-Writer-WriterList-2025-01-27-03_13_54](https://github.com/user-attachments/assets/51706624-98d5-4603-baf5-c5b33786fe5f)
![screencapture-localhost-7118-Admin-Book-BookList-2025-01-27-03_16_48](https://github.com/user-attachments/assets/f878e673-afe5-47df-9133-210c6206fdfd)
![screencapture-localhost-7118-Admin-Book-CreateBook-2025-01-27-03_18_03](https://github.com/user-attachments/assets/cd1fe455-c128-4232-9df0-53586efecf21)










