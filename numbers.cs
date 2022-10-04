using System.Collections.Generic;
namespace telefon_Rehber
{
    public class Kisi
        {
            public string? Ad { get; set;}
            public string? SoyAd { get; set;}
            public string? Numara { get; set;}
        }
    public class Rehber
    {

        List<Kisi> kisiler = new List<Kisi>();

        public Rehber(){
           kisiler.Add(new Kisi() {Ad="Berker",SoyAd="Ertan", Numara="051234567891"});
           kisiler.Add(new Kisi() {Ad="Murat", SoyAd="Dursun",Numara="051234567892"});
           kisiler.Add(new Kisi() {Ad="Mehmet",SoyAd="Salik", Numara="051234567893"});
           kisiler.Add(new Kisi() {Ad="Ali",   SoyAd="Veli",  Numara="051234567894"});
           kisiler.Add(new Kisi() {Ad="Fenasi",SoyAd="Kerim", Numara="051234567895"});
       }
       public void save(){
            Kisi yeniKisi=new Kisi();

            Console.WriteLine("Lütfen isim giriniz            :");
            yeniKisi.Ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz         :");
            yeniKisi.SoyAd = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            yeniKisi.Numara = Console.ReadLine();

            kisiler.Add(yeniKisi);
            Console.WriteLine("Yeni Kişi Eklendi.");
            // foreach (var item in kisiler)
            // {
            //     Console.WriteLine(item.Ad+" "+item.SoyAd+" "+item.Numara);
            // }

            
        }
        Rehber rehber1 = new Rehber();
        public void delete(){
            Console.WriteLine("Silmek istediğiniz kişinin adını veye soyadını giriniz.");
            string input = Console.ReadLine();

            foreach (var item in kisiler)
            {
                if(item.Ad.ToLower() == input.ToLower() || item.SoyAd.ToLower() == input.ToLower())
                {
                    kisiler.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int secim = int.Parse(Console.ReadLine());
                    if(secim == 1)
                        break;
                    else if(secim == 2)
                        rehber1.delete();
                    break;
                        

                }
            }



        }
        public void update(){
            Console.WriteLine("Güncellemek istediğiniz kişinin adını veye soyadını giriniz.");
            string input = Console.ReadLine();

            foreach (var item in kisiler)
            {
                if(item.Ad.ToLower() == input.ToLower() || item.SoyAd.ToLower() == input.ToLower())
                {
                    Console.WriteLine("Yeni numarayı giriniz");
                    string inputNumber = Console.ReadLine();
                    item.Numara = inputNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için           : (2)");
                    int secim = int.Parse(Console.ReadLine());
                    if(secim == 1){
                        Console.WriteLine("Çıkış yapılıyor");
                        break;
                    }
                    else if(secim == 2)
                        rehber1.update();
                    break;
                        

                }
            }



        }
        public void listele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("Isim    : "+ item.Ad);
                Console.WriteLine("Soyisim : "+ item.SoyAd);
                Console.WriteLine("Numara  : "+ item.Numara);
                Console.WriteLine("-------");
                
            }

        }
        public void Search(){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.WriteLine("İsim veya Soyisim Girin:");
                string inputName = Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if(item.Ad.ToLower() == inputName.ToLower() || item.SoyAd.ToLower() == inputName.ToLower())
                    {
                        Console.WriteLine("İsim            : " + item.Ad);
                        Console.WriteLine("Soyisim         : " + item.SoyAd);
                        Console.WriteLine("Telefon Numarası: " + item.Numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }

            }
            else if(input == 2)
            {
                Console.WriteLine("Telefon Numarasını Girin:");
                string inputNumber = Console.ReadLine();

                foreach (var item in kisiler)
                {
                    if(inputNumber == item.Numara)
                    {
                        Console.WriteLine("İsim            : " + item.Ad);
                        Console.WriteLine("Soyisim         : " + item.SoyAd);
                        Console.WriteLine("Telefon Numarası: " + item.Numara);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
                
            }
            
            


        }
    }
}
    
    
 