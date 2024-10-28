using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_Abstraction
{
    // Soyut sınıf: Calisan
    // Tüm çalışanların ortak özelliklerini ve metodlarını tanımlar.
    abstract class Calisan
    {
        // Çalışanın adı
        public string Ad { get; set; }
        // Çalışanın soyadı
        public string Soyad { get; set; }
        // Çalışanın departmanı
        public string Departman { get; set; }

        // Yapıcı metod: Çalışan nesnesi oluşturulurken ad, soyad ve departman alır.
        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Soyut metod: Her çalışanın kendi görevini tanımlaması için. Alt sınıflar bu metodu override etmek zorundadır.
        public abstract void Gorev();
    }

    // YazilimGelistirici sınıfı: Calisan sınıfından türetilir.
    class YazilimGelistirici : Calisan
    {
        // Yapıcı metod: Ad ve soyadı alır, departmanı "Yazılım Geliştirme" olarak ayarlar.
        public YazilimGelistirici(string ad, string soyad)
            : base(ad, soyad, "Yazılım Geliştirme") { }

        // Gorev metodunu override eder. Yazılım geliştirici görevini tanımlar.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} : \"Yazılım geliştiriyorum.\"");
        }
    }

    // ProjeYoneticisi sınıfı: Calisan sınıfından türetilir.
    class ProjeYoneticisi : Calisan
    {
        // Yapıcı metod: Ad ve soyadı alır, departmanı "Proje Yönetimi" olarak ayarlar.
        public ProjeYoneticisi(string ad, string soyad)
            : base(ad, soyad, "Proje Yönetimi") { }

        // Gorev metodunu override eder. Proje yöneticisi görevini tanımlar.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} : \"Proje yöneticisi olarak çalışıyorum.\"");
        }
    }

    // SatisTemsilcisi sınıfı: Calisan sınıfından türetilir.
    class SatisTemsilcisi : Calisan
    {
        // Yapıcı metod: Ad ve soyadı alır, departmanı "Satış" olarak ayarlar.
        public SatisTemsilcisi(string ad, string soyad)
            : base(ad, soyad, "Satış") { }

        // Gorev metodunu override eder. Satış temsilcisi görevini tanımlar.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} : \"Satış yapıyorum.\"");
        }
    }
}

