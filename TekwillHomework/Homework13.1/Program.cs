using Homework13._1;
using System;
using System.Transactions;

namespace Exemplu
{
     class Program
     {
          static void Main()
          {
             
               for(int i = 0; i <5; i++)     
               {
                    string prefix = "Cod";
                    string codUnic = Helper.GenerareCodUnic(prefix);
                    Console.WriteLine("Codul generat este: " + codUnic);
                              
               }
          }
     }
}