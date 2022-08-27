using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Secim
    {
        public static void Listele() 
        {
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("**********************");
            Goruntule(Board.Kolon,"TODO");

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("**********************");
            Goruntule(Board.Kolon, "IN PROGRESS");

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("**********************");
            Goruntule(Board.Kolon,"DONE");

            Secenek.Secenekler();


        }

        public static void Goruntule(List<Kart> kartlar,string kolonlar)
        {
            foreach (var item in kartlar)
            {
                if (kolonlar==item.Kolon)
                {
                    Console.WriteLine("\nBaşlık: " + item.Baslık);
                    Console.WriteLine("İçerik: " + item.İcerik);
                    Console.WriteLine("Atanan Kişi: " + Kisiler.kisiler.Find(a=>a.ID == item.ID));
                    Console.WriteLine("Büyüklük: " + ((Boyut)item.Boyut).ToString());
                    Console.WriteLine("-");
                }
                
            }
        }


        public static void Ekle()
        {
            Console.Write("\nBaşlık Giriniz\t: ");
            string titleAdd = Console.ReadLine();
            Console.Write("İçerik Giriniz\t: ");
            string contentAdd = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int sizeAdd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz\t: ");
            int personidAdd = Convert.ToInt32(Console.ReadLine());

            if (Kisiler.kisiler.Find(a=>a.ID==personidAdd).ID==personidAdd) 
            {
                Board.Kolon.Add(new Kart(titleAdd, contentAdd, personidAdd, sizeAdd, "TODO")); 
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }

            Secenek.Secenekler();
        }


        public static void Sil()
        {
            Console.WriteLine("\nÖncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string titleBoard= (Console.ReadLine());
            var sil = Board.Kolon.Where(x => x.Baslık == titleBoard).ToList(); 
            if (sil.Count>0)
            {
                for (int i = 0; i < sil.Count; i++) 
                {
                    Board.Kolon.RemoveAll(x => x.Baslık== titleBoard);
                }
                Console.WriteLine("Silindi.");
               Secenek.Secenekler();
            }

            else
            {
                NotFoundBoard();
            }
        }

        public static void Transfer() 
        {
            Console.WriteLine(" \nÖncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string titleBoard = (Console.ReadLine()).ToLower();
            var linqPerson = Board.Kolon.Where(x => x.Baslık.ToLower() == titleBoard).ToList();
            if (linqPerson.Count >0)
            {
                TransBoardList(titleBoard);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    linqPerson[0].Kolon = "TODO";
                    TransBoardList(titleBoard);
                }

                else if (selection == 2)
                {
                    linqPerson[0].Kolon = "IN PROGRESS";
                    TransBoardList(titleBoard);
                }
                    
                else if (selection == 3)
                {
                    linqPerson[0].Kolon = "DONE";
                    TransBoardList(titleBoard);
                }
                else
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                Secenek.Secenekler();
            }
            else
            {
                NotFoundBoard();
            }
        }

        public static void TransBoardList(string titleBoard)
        {
            var linqPerson = Board.Kolon.Where(x => x.Kolon.ToLower() == titleBoard).ToList();
            Console.WriteLine("\nBulunan Kart Bilgileri:");
            Console.WriteLine(" **************************************");
            Console.WriteLine("Başlık: " + linqPerson[0].Baslık);
            Console.WriteLine("İçerik: " + linqPerson[0].İcerik);
            Console.WriteLine("Atanan Kişi: " + Kisiler.kisiler);
            Console.WriteLine("Büyüklük: " + ((Boyut)linqPerson[0].Boyut).ToString());
            Console.WriteLine("Line: " + linqPerson[0].Kolon);
        }


        public static void NotFoundBoard([CallerMemberName] string callermemberName = "") // silmek veya degiştirmek istedigimiz başlık bulunamayınca
        {
            Console.WriteLine("\nAradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine(" * İşlemi sonlandırmak için : (1).");
            Console.WriteLine(" * Yeniden denemek için : (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
                Secenek.Secenekler();
            else if (select == 2)
            {
                if (callermemberName == "RemoveBoard")
                {
                    Sil();
                }
                else if (callermemberName == "TransBoard")
                {
                    Transfer();
                }
            }
            else { Console.WriteLine("Yanlış seçim yaptınız."); 
                     Secenek.Secenekler(); }
        }
    }
}