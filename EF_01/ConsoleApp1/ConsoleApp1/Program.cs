using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           void BolumleriListele()
            {
                //ToList metodu ile Bölümleri listele
                HastaneSabahEntities hastane = new HastaneSabahEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID\tBolum Adı");
                foreach (var bolum in bolumler)
                {
                    
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");

                }
                Console.ReadLine();
            }
            //Where metodu ile sorgulama , diş bölümünü getir
            void BolumGetir()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var sonuc = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    foreach (var item in sonuc)
                    {
                        Console.WriteLine($"Bölüm ID:{item.ID} Bölüm Ad: {item.BolumAd}");
                    }
                    Console.ReadLine();

                }
            }
          
            //select ile veri çekme
            void DoktorAdListele()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())

                {
                    var adlar = hastane.Doktorlar.Select(x => x.AdSoyad);
                    Console.WriteLine($"Doktor Adı");
                    foreach (var ad in adlar)
                    {
                        Console.WriteLine(ad);
                    }
                }
                Console.ReadLine();
            }

            //Find ile hızlı ara 
            void HizliAra()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    //Find Metodu ilgili tablodaki primary key üzerinden arama yapar 
                    //Bu da onu oldukça hızlı hale getirir
                    Console.WriteLine($"Doktor Adı: {doktor.AdSoyad} Bölümü:{doktor.Bolumler.BolumAd}");
                }

                Console.ReadLine();

            }

            //İlk kaydı getirme, ilk demet evgarı getir
            void IlkKayit()
            {
                using (HastaneSabahEntities hastane=new HastaneSabahEntities())

                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad == "Demet Evgar")
                        .First();

                    Console.WriteLine($"Doktor Ad:{doktor.AdSoyad} Bölüm Ad:{doktor.Bolumler.BolumAd} ");
                }
                Console.ReadLine();
            }
            
            //İlK üç doktoru getir
            void IlkUcDoktor()
            {
                using (HastaneSabahEntities hastane= new HastaneSabahEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3);
                    foreach(var doktor in ilkUcDoktor)
                    {
                        Console.WriteLine();
                    }
                }
            }
            //Var mı ?
            void VarMi()
            {
                using (HastaneSabahEntities hastane =new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Mikail Ayan");
                    if (sonuc)
                    {
                        Console.WriteLine("Aradığınız doktor var");
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız doktor yok");

                    }
                    Console.ReadLine();
                }
            }
            //uygunluk var mı
            void UyuyorMu()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Dahiliye");

                    if (sonuc)
                    {
                        Console.WriteLine($"Evet tümü uygun");
                    }
                    else
                    {
                        Console.WriteLine($"Hayır uymayanlar var ");

                    }

                }
                Console.ReadLine();
            }
            //Ascendig sıralama A'dan Z'ye Sıralama küçükten büyüğe
            void SiralaAsc()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())
                {
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach(var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);

                    }
                }
                Console.ReadLine();
            }

            //Descending sıralama Z'den A'ya ,büyükten küçüğe 

            void SiralaDesc()
            {
                using (HastaneSabahEntities hastane= new HastaneSabahEntities())

                {
                    var tersSiraliDoktorlar = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var doktor in tersSiraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }

                }
                Console.ReadLine();
            }

            void SonUcDoktor()
            {
                using (HastaneSabahEntities hastane = new HastaneSabahEntities())

                {
                    var sonUcDoktor = hastane.Doktorlar.OrderByDescending(x=>x.ID).Take(3);
                    foreach (var doktor in sonUcDoktor)
                    {
                        Console.WriteLine($"{doktor.AdSoyad}");
                    }
                }
                Console.ReadLine();
            }

            void BolumlereGoreDoktorSayisiniGetir()
            {
                using (HastaneSabahEntities hastane= new HastaneSabahEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(a => a.Bolumler.BolumAd)
                        .Select(b => new
                        {
                            name = b.Key,
                            count = b.Count()
                        });
                    Console.WriteLine($"Bolum\t\tDoktor Sayısı");
                    foreach(var item in sonuc)               
                    {
                        Console.WriteLine($"{ item.name}\\t {item.count}");
                    }
                }
                Console.ReadLine();
            }
            BolumlereGoreDoktorSayisiniGetir();
            //SonUcDoktor();
            //SiralaDesc();
            //VarMi();
            //BolumleriListele();
            //BolumGetir();
            //DoktorAdListele();
            //HizliAra();
            // IlkKayit();
            //UyuyorMu();
            SiralaAsc();

        }
    }
}
