using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Kart
    {
        public Kart( string baslık, string icerik, int ıd,int boyut,string kolon)
        {
            Baslık= baslık;
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
    }
}