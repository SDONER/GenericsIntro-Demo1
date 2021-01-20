using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> liste = new MyList<string>();
           // Console.WriteLine(liste.Count);
            liste.Add("Serpil");

            Console.WriteLine("Hello World");
        }
    }
}
