using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Secenek
    {
        public static void Secenekler()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Secim.Listele();
                    break;
                case 2:
                    Secim.Ekle();
                    break;
                case 3:
                    Secim.Sil();
                    break;
                case 4:Secim.Transfer();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    Secenek.Secenekler();
                    break;


            }


        }
        
    }
}

