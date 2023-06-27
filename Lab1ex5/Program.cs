using System;

namespace Lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 5
            Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            • Exemplu: citim ,9,0 Afisam : 0 9*/

            Console.WriteLine("Introduce x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y: ");
            int y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("Afisam : " + y + " si " + x );
            }
            else
            {
                Console.WriteLine("Afisam : " + x + " si " + y);

            }
        }
    }
}