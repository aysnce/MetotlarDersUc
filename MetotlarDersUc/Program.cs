using System;

namespace MetotlarDersUc
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDersUc urun1 = new ProductDersUc();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            ProductDersUc urun2 = new ProductDersUc();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Dİyarbakır karpuzu";

            ProductDersUc[] urunler = new ProductDersUc[] { urun1, urun2 };

            foreach (ProductDersUc urun in urunler)
            {
                //TYPE SAFE - TİP GÜVENLİ
                Console.WriteLine("Ürün adı : " + urun.Adi);
                Console.WriteLine("Ürün fiyatı : " + urun.Fiyati);
                Console.WriteLine("Ürün açıklaması : " + urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-----Metotlar-----");

            //instance - örnek
            //encapsulation
            SepetManagerDersUc sepetManager = new SepetManagerDersUc();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12, 9);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20, 5);

        }
    }
}

//Don't repeat yourself - kendini tekrar etme 
//DRY
//Clean code
//Best pratice - temiz kod yazma 