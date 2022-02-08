using System;


namespace console_programming
{
    class Program
    {
        public static void Main(string[] args){
            
            Console.WriteLine("Adinizi Giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi Giriniz");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);

        }
    }
}