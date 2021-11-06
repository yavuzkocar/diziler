using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİ TANIMLAMA
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","maymun","eşek"};

            int[] dizi;
            dizi= new int[5];

            //dizilere değer atama ve erişim

            renkler[0]="mavi";
            dizi[3]= 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerde dizi kullanımı
            //girilen n tane değerin ortalamasını hesaplayan program

            Console.Write("lütfen dizinin eleman sayısını belirtiniz : ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int [] sayıdizisi = new int [diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("lütfen dizinin {0}. sayısını giriniz: ", i+1);
                sayıdizisi[i]= int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıdizisi)
             toplam+=sayi ; 
            Console.WriteLine("dizinin elemanlarının ortalaması: " + toplam/diziuzunlugu);

        }
    }
}
