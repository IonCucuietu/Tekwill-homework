using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               int firstNumber, secondNumber;
               char operationSymbol;
               int result;

               Console.WriteLine("Introduceti primul numar: ");
               if (!int.TryParse(Console.ReadLine(), out firstNumber))
               {
                    Console.WriteLine("Introduceti un numar valid pentru primul numar");
                    int.TryParse(Console.ReadLine(), out firstNumber);
               }

               Console.WriteLine("Introduceti al doilea numar: ");
               if (!int.TryParse(Console.ReadLine(), out secondNumber))
               {
                    Console.WriteLine("Introduceti un numar valid pentru al doilea numar");
                    int.TryParse(Console.ReadLine(), out secondNumber);
               }

               Console.WriteLine("Alegeti simbolul + sau - : ");
               if (!char.TryParse(Console.ReadLine(), out operationSymbol) || (operationSymbol != '+' && operationSymbol != '-'))
               {
                    Console.WriteLine("Introduceti un simbol valid (+ sau -): ");
                    char.TryParse(Console.ReadLine(), out operationSymbol);
               }

               if (operationSymbol == '+')
               {
                    result = firstNumber + secondNumber;
               }
               else
               {
                    result = firstNumber - secondNumber;
               }

               Console.WriteLine($"Rezultatul operatiei {firstNumber} {secondNumber} este {result} ");

          }
     }
}
