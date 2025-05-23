# 📞 Telefon Rehberi Uygulaması

Bu proje, MySQL veritabanı kullanarak kişi ekleme, listeleme, arama, güncelleme ve silme işlemlerini gerçekleştirebilen Windows Forms (WinForms) tabanlı bir **Telefon Rehberi Uygulamasıdır**.

## 🛠 Özellikler

- ✅ Kişi ekleme (Ad, Soyad, Telefon No, Telefon Türü)
- ✅ Kayıtları listeleme (DataGridView üzerinden)
- ✅ İsim veya telefon numarasına göre arama
- ✅ Kayıt silme ve güncelleme işlemleri
- ✅ Placeholder (yer tutucu) metin desteği
- ✅ MySQL veritabanı ile bağlantı

## 🧰 Kurulum

###  MySQL Veritabanı Oluşturun

Aşağıdaki SQL sorgusu ile `telefon_rehberi` veritabanını ve `kisiler` tablosunu oluşturabilirsiniz:

```sql
CREATE DATABASE IF NOT EXISTS telefon_rehberi;

USE telefon_rehberi;

CREATE TABLE IF NOT EXISTS kisiler (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    telefon_numarasi VARCHAR(11) NOT NULL,
    telefon_turu ENUM('GSM', 'Sabit Telefon') NOT NULL
);
```

### 🔐 Veritabanı Bağlantısı

Proje, MySQL veritabanına aşağıdaki bilgilerle bağlanmaktadır. Kendi sisteminize uygun şekilde `user` ve `password` değerlerini değiştiriniz.

```csharp
string server = "localhost";
string database = "telefon_rehberi";
string user = "KULLANICI_ADINIZ"; // Örn: root
string password = "ŞİFRENİZ";      
string port = "3306";
```

### 🖼 Resim
![Telefon Rehberi](https://github.com/user-attachments/assets/f5efdb82-fa48-404c-b3d0-c669a386df2f)

