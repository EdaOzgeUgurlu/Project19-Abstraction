// Program sınıfı: Uygulamanın başlangıç noktası.
using Project19_Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Farklı çalışan nesnelerini oluşturur.
        Calisan[] calisanlar = new Calisan[]
        {
            new YazilimGelistirici("Hasan", "Çıldırmış"),
            new ProjeYoneticisi("Eda", "Yılmaz"),
            new SatisTemsilcisi("Özge", "Kara")
        };

        // Her çalışanın Gorev() metodunu çağırarak görevlerini ekrana yazdırır.
        foreach (var calisan in calisanlar)
        {
            calisan.Gorev();
        }
    }
}