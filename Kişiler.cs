using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Kisiler
    {
        public static List<Kisiler> kisiler = new List<Kisiler>();

        public Kisiler(string baslık, string icerik, int ıd,int boyut,string kolon)
        {  Baslık= baslık;
            İcerik = icerik;
            ID = ıd;
            Boyut = boyut;
            Kolon = kolon;
        
        }
          public string Baslık { get; set; }
        public string İcerik { get; set; }
        public int ID { get; set; }
        public int Boyut { get; set; }
        public string Kolon { get; set; }

        public Kisiler(int a,string b)
        {
            kisiler.Add(new Kisiler(1, "Aslı"));
            kisiler.Add(new Kisiler(2, "Kerem"));
            kisiler.Add(new Kisiler(3, "Leyla"));
            kisiler.Add(new Kisiler(4, "Mecnun"));
        }

        public Kisiler()
        {
        }
    }
}