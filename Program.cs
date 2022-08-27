using System;

namespace ToDoUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Kisiler kisiler = GetKisiler();

            Secenek.Secenekler();
        }

        private static Kisiler GetKisiler()
        {
            return new Kisiler();
        }
    }
}