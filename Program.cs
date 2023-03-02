//Klavyeden girilen 20 adet pozitif sayının 
//asal ve asal olmayan olarak 2 ayrı listeye atın. 
//(ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;

internal class Program
{
    public static bool asal_Kontrol (uint sayi)
    {
        bool durum = false;
        int kontrol = 0;
        for (int i = 2; i < sayi; i++)
        {
            if(sayi%i==0)
            {
                kontrol =1;
                break;
            }

        }
            if(kontrol==1)
            {
                durum = false;
            }
            else
            durum = true;

            return durum;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("20 tane pozitif sayı giriniz");
        
        ArrayList asallar = new ArrayList();
        ArrayList olmayanlar = new ArrayList();
       try
       {
        for (int i = 1; i < 21; i++)
        {
            Console.WriteLine(i+". Sayıyı Giriniz");
             uint sayi = uint.Parse(Console.ReadLine());

            if(asal_Kontrol(sayi))
            asallar.Add(sayi);
            else
            olmayanlar.Add(sayi);

        }
       }
       catch (Exception ex)
       {
        Console.WriteLine("Lütfen pozitif tam sayı giriniz");
        Console.WriteLine("Hata:" + ex.Message.ToString());
       }
        
        asallar.Sort();
        olmayanlar.Sort();
        asallar.Reverse();
        olmayanlar.Reverse();
         
        foreach (var asal in asallar)
        {
            Console.WriteLine(asal+" Sayısı Asal");
        }
        foreach (var olmayan in olmayanlar)
        {
            Console.WriteLine(olmayan+" Sayısı Asal Değil");
        }

        int asalUzunluk= asallar.Count;
        int olmayanUzunluk = olmayanlar.Count;

        Console.WriteLine(asalUzunluk);
        Console.WriteLine(olmayanUzunluk);

        uint asToplam = 0;
        for (int k=0; k<asalUzunluk;k++)
        {
            asToplam += (uint)asallar[k];
        }
        Console.WriteLine(asToplam);
        long ortalamaAsal=asToplam/asalUzunluk;

        Console.WriteLine("asal Olanlar ortalaması=" + ortalamaAsal);

        uint olmToplam = 0;
        for (int m=0; m<olmayanUzunluk;m++)
        {
            olmToplam += (uint)olmayanlar[m];
        }
        Console.WriteLine(olmToplam);
        long ortalamaOlm = olmToplam/olmayanUzunluk;
    
        Console.WriteLine("asal Olmayanlar ortalaması=" + ortalamaOlm);


////////////
        Console.WriteLine("20 tane pozitif sayı giriniz");
        ArrayList sayilar = new ArrayList();
        for(int f = 0; f<20 ; f++)
        {
            Console.WriteLine(f+1 +". sayıyı Giriniz");
            sayilar.Add(int.Parse(Console.ReadLine()));
        }

        sayilar.Sort();

        int[] buyukler = new int[3];
        for (int m = 0; m < 3; m++)
        {
            buyukler[m]=(int)sayilar[m];
        }
        int u = sayilar.Count;
        int[] kucukler = new int[3];
        for( int n = 0; n < 3; n++)
        {
            kucukler[n]=(int)sayilar[--u];
        }

       int buyukToplam = 0;
        for(int b =0 ; b <buyukler.Length ; b++ )
        {
            buyukToplam+=buyukler[b];
        }

        int kucukToplam = 0;
        for(int a =0; a<kucukler.Length;a++)
        {
            kucukToplam+=kucukler[a];
        }
        int ortBuyuk = buyukToplam/buyukler.Length;
        int ortKucuk = kucukToplam/kucukler.Length;
        Console.WriteLine("büyük sayıların ortalaması" + ortBuyuk);
        Console.WriteLine("küçük sayıların ortalaması" +ortKucuk);
        Console.WriteLine("ortalama toplamları" + ortBuyuk+ortKucuk);

/////////////////
         Console.WriteLine("lütfen bir cümle giriniz");
         string cumle = Console.ReadLine();
         string  sesli="aeıioöuü";
         ArrayList sesliHarfler = new ArrayList();

         for(int c =0; c < cumle.Length; c++)
         {
            if(sesli.Contains(cumle[c]))
            {
                sesliHarfler.Add(cumle[c]);
            }
         }

         foreach (var item in sesliHarfler)
         {
            Console.WriteLine(item);
         }
    }
}   

//Klavyeden girilen 20 adet sayının 
//en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
//her iki grubun kendi içerisinde ortalamalarını alan 
//ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

//Klavyeden girilen cümle içerisindeki 
//sesli harfleri bir dizi içerisinde saklayan 
//ve dizinin elemanlarını sıralayan programı yazınız.