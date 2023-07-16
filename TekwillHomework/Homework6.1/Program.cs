using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Introduceti virsta dvs: ");
               int varsta = int.Parse(Console.ReadLine());

               if (varsta >= 18)
               {
                    Console.WriteLine("Aveti dreptul de a vota");
               }
               else { Console.WriteLine("Nu aveti dreptul de a vota, sunteti minor"); }

          }
     }
}