using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class Board
    {
        public static List<Kart> Kolon = new List<Kart>();
        

        public Board()
        {
            Kolon.Add(new Kart("Kahve","Çay. ",1,1,"TODO"));
            Kolon.Add(new Kart("Bisküvi","Çikolata. ",2,2, "IN PROGRESS"));
            Kolon.Add(new Kart("Cips","Gofret ",3,3, "DONE"));
            Kolon.Add(new Kart("Pasta","Simit. ",4,4, "DONE"));
        }
        
    }
}