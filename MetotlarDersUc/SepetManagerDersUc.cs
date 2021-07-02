using System;
using System.Collections.Generic;
using System.Text;

namespace MetotlarDersUc
{
    class SepetManagerDersUc
    {
        //naming convention - isimlendirme kuralı
        //syntax - zorunlu kurallar 
        public void Ekle(ProductDersUc urun) //productdersuc şeklinde olmasının sebebi ben karıştırmayayım diye aslında sadece product
        {
            Console.WriteLine("Sepete eklendi : " +urun.Adi); 
            //buradaki sepete eklendi kodu değştiğinde diğer sayfalardaki kodların hepsi değişir
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) 
        {
            Console.WriteLine("Sepete eklendi : "+urunAdi);
        }
    }
}
