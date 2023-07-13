using System;

namespace Exemplu
{
     class Program
     {
          enum meniuriDisponibile
          {

               Supa = 1,
               SalataCaesar,
               SalataGreceasca,
               Inghetata

          }

          static void Main(string[] args)
          {
               while (true)
               {

                    Console.WriteLine("Meniu");
                    Console.WriteLine("1. Supa");
                    Console.WriteLine("2. Salata Caesar");
                    Console.WriteLine("3. Salata Greceasca");
                    Console.WriteLine("4. Inghetata");
                    Console.WriteLine("Introduceti optiunea dorita din meniu: ");
                    int numar = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (numar)
                    {
                         case 1:
                              Console.WriteLine("Ati ales Supa. Pretul este de 50 lei");
                              break;
                         case 2:
                              Console.WriteLine("Ati ales Salata Caesar. Pretul este de 100 lei");
                              break;
                         case 3:
                              Console.WriteLine("Ati ales Salata Greceasca. Pretul este de 90 lei");
                              break;
                         case 4:
                              Console.WriteLine("Ati ales Inghetata. Pretul este de 20 lei");
                              break;
                         default:
                              Console.WriteLine("Nu ati introdus corect optiunea");
                              break;

                    }

               }

          }
     }
}