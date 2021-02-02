using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "civan";
            musteri1.SurName = "Delhiz";
            musteri1.Number = 05477777777;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Arda";
            musteri2.SurName = "Parlağ ";
            musteri2.Number = 05344444444;
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Furkan";
            musteri3.SurName = "Çınar";
            musteri3.Number = 055555555;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Name = "Alihan";
            musteri4.SurName = "Adil ";
            musteri4.Number = 0554444444;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Name = "Levent";
            musteri5.SurName = "Derin";
            musteri5.Number = 0547777777;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };


            //EKLENENLER
            Console.WriteLine("--------------------MÜŞTERİLER--------------------");

            foreach (var ekli in musteriler) 
            {
                Console.WriteLine("Müşteri Numarası:" +ekli.Id + "  " + "Ad Soyad" + ":" + ekli.Name + " " + ekli.SurName + "  Telefon Numarası:" + ekli.Number);
            }






            MusteriManager musteri = new MusteriManager();


            //Ekleme

            Console.WriteLine("--------------Müşteri Ekleme--------------");

            musteri.Add(musteri4);
            musteri.Add(musteri5);



            //Silme
            Console.WriteLine("\n----------MÜŞTERİ SİLME----------");
            musteri.Delete(musteri1);
            musteri.Delete(musteri2);

            Console.ReadLine();


        }

        
    }
}
