using System;

namespace Udemy.FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konsola çıktı yazdırma
            Console.Write("Merhaba C#"); // Ekrana yazar, satır atlamaz
            Console.WriteLine(" ve Dünya"); // Yazar ve ardından satır atlar

            // 1. Metinsel Veri Tipi (string)
            // 'string' veri tipi, metinsel ifadeleri saklamak için kullanılır.
            // Örnek: İsim ve soyisim saklama
            string isimSoyisim = "Kayrahan";
            Console.WriteLine("İsim Soyisim: " + isimSoyisim);

            // Alternatif kullanım: Önce değişken tanımlanır, sonra değer atanır.
            string dogumYeri;
            dogumYeri = "Istanbul";
            Console.WriteLine("Doğum Yeri: " + dogumYeri);

            // 2. Tam Sayı Veri Tipleri
            // 'int' veri tipi, -2,147,483,648 ile 2,147,483,647 arasında tam sayıları saklar ve 4 bayt yer kaplar.
            int yas = 25;
            Console.WriteLine("Yaş: " + yas);

            // 'byte' veri tipi, 0 ile 255 arasında pozitif tam sayıları saklar ve 1 bayt yer kaplar.
            byte ay = 12;
            Console.WriteLine("Ay: " + ay);

            // 'short' veri tipi, -32,768 ile 32,767 arasında tam sayıları saklar ve 2 bayt yer kaplar.
            short yil = 2025;
            Console.WriteLine("Yıl: " + yil);

            // 'long' veri tipi, çok büyük tam sayıları saklamak için kullanılır ve 8 bayt yer kaplar.
            long nufus = 8000000000;
            Console.WriteLine("Dünya Nüfusu: " + nufus);

            // 3. Ondalıklı Sayı Veri Tipleri
            // 'float' veri tipi, ondalıklı sayıları saklar ve 4 bayt yer kaplar. Değerin sonuna 'f' eklenmelidir.
            float boy = 1.75f;
            Console.WriteLine("Boy: " + boy);

            // 'double' veri tipi, daha yüksek hassasiyetli ondalıklı sayıları saklar ve 8 bayt yer kaplar.
            double agirlik = 70.5;
            Console.WriteLine("Ağırlık: " + agirlik);

            // 'decimal' veri tipi, finansal ve parasal hesaplamalar için kullanılır ve 16 bayt yer kaplar.
            decimal bakiye = 1000.75m;
            Console.WriteLine("Bakiye: " + bakiye);

            // 4. Mantıksal Veri Tipi (bool)
            // 'bool' veri tipi, sadece 'true' veya 'false' değerlerini alır.
            bool ogrenciMi = true;
            Console.WriteLine("Öğrenci mi? " + ogrenciMi);

            // 5. Karakter Veri Tipi (char)
            // 'char' veri tipi, tek bir karakteri saklar ve tek tırnak içinde belirtilir.
            char ilkHarf = 'K';
            Console.WriteLine("İlk Harf: " + ilkHarf);

            // 6. Tarih ve Zaman Veri Tipi (DateTime)
            // 'DateTime' veri tipi, tarih ve saat bilgilerini saklamak için kullanılır.
            DateTime bugun = DateTime.Now;
            Console.WriteLine("Bugün: " + bugun);

            // 7. Değişken İsimlendirme Kuralları
            // - Değişken isimleri harf veya '_' ile başlamalıdır; sayı ile başlayamaz.
            // - Büyük/küçük harf duyarlıdır; 'sayi' ve 'Sayi' farklı değişkenlerdir.
            // - İsimler arasında boşluk kullanılmaz; camelCase veya snake_case kullanımı yaygındır.
            // - Özel karakterler (!, ?, {, ]) kullanılmaz.
            // - Anahtar kelimeler (if, for, while) değişken ismi olarak kullanılamaz.

            // Geçerli değişken isimleri
            int ogrenciSayisi = 30;
            double piSayisi = 3.14;
            string _adres = "Istanbul";

            // Geçersiz değişken isimleri (yorum satırı olarak bırakıldı)
            // int 2sayi; // Sayı ile başlayamaz
            // string ad soyad; // Boşluk içeremez
            // bool class; // Anahtar kelime kullanılamaz

            // Değişkenlerin kullanımı
            Console.WriteLine("Öğrenci Sayısı: " + ogrenciSayisi);
            Console.WriteLine("Pi Sayısı: " + piSayisi);
            Console.WriteLine("Adres: " + _adres);


        }
    }
}
