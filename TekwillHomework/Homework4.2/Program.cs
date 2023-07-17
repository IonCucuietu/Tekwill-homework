using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               double celsius, fahrenheit;


               Console.WriteLine("Introduceti temperatura in grade Celsius: ");
               if (!double.TryParse(Console.ReadLine(), out celsius))
               {
                    Console.WriteLine("Introduceti un numar valid pentru temperatura");
                    double.TryParse(Console.ReadLine(), out celsius);
               }

               fahrenheit = (celsius * 9 / 5) + 32;

               Console.WriteLine($"Temperatura din grade Celsius convertita in Fahrenheit este {fahrenheit} F");


          }
     }
}
