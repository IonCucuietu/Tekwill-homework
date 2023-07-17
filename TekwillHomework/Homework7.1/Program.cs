using System;

namespace Exemplu
{
     class Program
     {
          static void Main(string[] args)
          {
               int NumarStudenti;

               Console.WriteLine("Introdu numarul de studenti: ");
               NumarStudenti = int.Parse(Console.ReadLine());

               double[] nota = new double[NumarStudenti];


               for (int i = 0; i < NumarStudenti; i++)
               {
                    Console.WriteLine("Introduceti nota pentru studentul {0}: ", i + 1);
                    nota[i] = double.Parse(Console.ReadLine());
               }

               Console.WriteLine("Notele studentilor sunt: ");


               for (int i = 0; i < NumarStudenti; i++)
               {
                    Console.WriteLine(" Studentul {0}: {1}", i + 1, nota[i]);
               }

               double suma = 0;

               for (int i = 0; i < NumarStudenti; i++)
               {
                    suma = suma + nota[i];
               }

               double media = suma / NumarStudenti;

               Console.WriteLine("Media notelor este {0}", media);


               Console.ReadKey();

          }
     }
}
