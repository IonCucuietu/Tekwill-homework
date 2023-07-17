using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Introduceti nota dvs de la test: ");
               int nota = int.Parse(Console.ReadLine());

               if (nota == 10)
               {
                    Console.WriteLine("Excelent");
               }
               else if (nota < 10 && nota > 7)
               {
                    Console.WriteLine("Bun");
               }
               else if (nota >= 1 && nota <= 4)
               {
                    Console.WriteLine("Necalificat");
               }
               else
               {
                    Console.WriteLine("Nota introdusă nu este validă.");
               }
          }
     }
}