# Project19_Abstraction 🚀

## Proje Hakkında 
Bu proje, bir şirketin çalışanlarını temsil eden bir C# uygulamasıdır. Proje, nesne yönelimli programlama (OOP) prensiplerini kullanarak çalışanların özelliklerini ve görevlerini soyutlamaktadır. Kullanılan başlıca OOP kavramları arasında soyutlama, kalıtım ve polymorphism bulunmaktadır.

## Özellikler ✨
- **Soyut Sınıf (Abstract Class)**: `Calisan` sınıfı, tüm çalışanların ortak özelliklerini (ad, soyad, departman) ve metotlarını tanımlar. Bu sınıf, doğrudan nesne oluşturulamaz.
- **Alt Sınıflar**: 
  - `YazilimGelistirici`: Yazılım geliştiren çalışanları temsil eder.
  - `ProjeYoneticisi`: Projeleri yöneten çalışanları temsil eder.
  - `SatisTemsilcisi`: Satış işlemlerini gerçekleştiren çalışanları temsil eder.
- **Görev Tanımlama**: Her bir çalışan, kendi görevini `Gorev()` metodunu override ederek tanımlar. Bu metod, çalışanın yaptığı işi açıklayan bir mesajı konsola yazdırır.
- **Konsol Uygulaması**: Program çalıştırıldığında, her bir çalışanın görevlerini konsola yazdıran basit bir uygulama sunar.

## Kullanım 🛠️
### Gereksinimler 📋
- .NET Framework veya .NET Core yüklü bir geliştirme ortamı.
- C# programlama bilgisi (temel seviye).

### Kurulum 🔧
1. **Proje İndirme**: 
   - Proje dosyalarını GitHub üzerinden indirin veya aşağıdaki komutu kullanarak klonlayın:
     ```bash
     git clone https://github.com/kullaniciadi/Project19_Abstraction.git
     ```

2. **Geliştirme Ortamı Ayarlama**: 
   - Visual Studio, Visual Studio Code veya herhangi bir C# IDE'sini açın.
   - İndirdiğiniz veya klonladığınız proje klasörünü açın.

3. **Projeyi Derleme ve Çalıştırma**: 
   - Terminal veya komut istemcisini açın ve proje dizinine gidin.
   - Aşağıdaki komut ile projeyi derleyip çalıştırın:
     ```bash
     dotnet run
     ```

### Çalıştırma ▶️
Program çalıştırıldığında, oluşturulan farklı çalışan nesneleri üzerinde `Gorev()` metodu çağrılarak, her çalışanın yaptığı işin açıklaması konsola yazdırılır.

## Kod Yapısı 🏗️
### Sınıflar ve Metotlar 📂
- **Calisan (Soyut Sınıf)**: 
  - **Özellikler**:
    - `string Ad`: Çalışanın adı.
    - `string Soyad`: Çalışanın soyadı.
    - `string Departman`: Çalışanın çalıştığı departman.
  - **Yapıcı Metod**: 
    - `Calisan(string ad, string soyad, string departman)`: Çalışan nesnesi oluşturulurken ad, soyad ve departman alır.
  - **Soyut Metod**: 
    - `abstract void Gorev()`: Her alt sınıf tarafından override edilmesi gereken metod.

- **YazilimGelistirici Sınıfı**: 
  - Türetildiği `Calisan` sınıfından miras alır.
  - **Override Edilen Metod**: 
    - `void Gorev()`: Yazılım geliştiricinin görevini tanımlar.

- **ProjeYoneticisi Sınıfı**: 
  - Türetildiği `Calisan` sınıfından miras alır.
  - **Override Edilen Metod**: 
    - `void Gorev()`: Proje yöneticisinin görevini tanımlar.

- **SatisTemsilcisi Sınıfı**: 
  - Türetildiği `Calisan` sınıfından miras alır.
  - **Override Edilen Metod**: 
    - `void Gorev()`: Satış temsilcisinin görevini tanımlar.


