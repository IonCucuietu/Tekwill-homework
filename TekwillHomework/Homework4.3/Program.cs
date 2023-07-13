using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               double weight, height;
               double IMC;


               Console.WriteLine("Introduceti greutatea: ");
               if (!double.TryParse(Console.ReadLine(), out weight))
               {
                    Console.WriteLine("Introduceti un numar valid pentru temperatura");
                    double.TryParse(Console.ReadLine(), out weight);
               }

               Console.WriteLine("Introduceti inaltimea: ");
               if (!double.TryParse(Console.ReadLine(), out height))
               {
                    Console.WriteLine("Introduceti un numar valid pentru temperatura");
                    double.TryParse(Console.ReadLine(), out height);
               }

               IMC = weight / (height * height);

               Console.WriteLine($"Indicele de masa corporala este {IMC} ");

          }
     }
}