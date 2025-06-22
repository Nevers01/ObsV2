# OBS_Basic V2 (Öğrenci Bilgi Sistemi - Versiyon 2)

> ⚠️ **Not:** Bu proje henüz tamamlanmamıştır. Geliştirme süreci aktif olarak devam etmektedir.

**OBS_Basic V2**, C# ve WinForms kullanılarak geliştirilmiş masaüstü tabanlı bir öğrenci bilgi sistemidir. Proje, öğretmen (admin) ve öğrenci rolleri için ayrı kullanıcı panelleri sunar. Kullanımı kolay ve sade bir arayüzle, temel öğrenci yönetimi işlemlerini gerçekleştirmeyi amaçlamaktadır.


---

## 🎯 Temel Özellikler

- ✅ Kullanıcı İşlemleri (CRUD)
- ✅ Duyuru İşlemleri (CRUD)
- ✅ Not İşlemleri (CRUD)
- ✅ Devamsızlık İşlemleri (CRUD)
- ✅ Admin (Öğretmen) Paneli ve Öğrenci Paneli
- ✅ Basit ve kullanıcı dostu arayüz

---

## 🔄 V1 ve V2 Arasındaki Farklar

| Özellik                | V1 (Eski)                 | V2 (Yeni)                                      |
|------------------------|---------------------------|------------------------------------------------|
| Tema / UI             | Basit tema                | Modern ve göze hitap eden tema                 |
| Veritabanı Yaklaşımı  | Database First            | Code First                                     |
| Kod Yapısı            | Daha dağınık              | Clean Code & Refactoring uygulanmış           |
| Form Kullanımı        | Her işlem için ayrı form  | Dinamik form mantığı, daha az form kullanımı   |
| Performans            | Orta                      | Optimize edilmiş, daha az kaynak kullanımı     |

---

## ⚙️ Teknolojiler

- C# (.NET Framework)
- WinForms
- Entity Framework Core (Code First)
- MSSQL
- Gelişmiş form yönetimi (tek formda çok işlem)

---

## 🔗 Veritabanı Bağlantısı

- Projeyi çalıştırabilmeniz için kendi veritabanı bağlantınızı girmeniz gerekmektedir.
- `Helper/ObsDbContext.cs` dosyasındaki aşağıdaki satırı güncelleyin:

```csharp
optionsBuilder.UseSqlServer("YOUR_CONNECTION_STRING_HERE");
