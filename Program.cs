using System;
using System.Collections.Generic;

namespace telefon_Rehber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber1 = new Rehber();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz. :)");
            Console.WriteLine("********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int choice = int.Parse(Console.ReadLine());

           switch(choice)
           {
            case 1:
                rehber1.save();
                break;
            // case 2:
            //     rehber1.delete();
            //     break;
            // case 3:
            //     rehber1.update();
            //     break;
            // case 4:
            //     rehber1.listele();
            //     break;
            // case 5:
            //     rehber1.Search();
            //     break;
           }

        }
    }
}
