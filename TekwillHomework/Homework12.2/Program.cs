using System;
using System.Transactions;

namespace Exemplu
{

     public class Persoana
     {
          public string NumarulDeIdentificare { get; set; }

          public Persoana(string numarulDeIdentificare)
          {
               NumarulDeIdentificare = numarulDeIdentificare;
          }

     }

     public class ContBancar
     {
          public DateTime CreationDate { get; }
          public Persoana Owner { get; }
          public string NumarulContului { get; }
          public string MonedaContului { get; }
          public int PIN { get; }

          private List<decimal> tranzactii;

          public ContBancar(Persoana owner, string numarulContului, string monedaContului, int pin)
          {
               CreationDate = DateTime.Now;
               Owner = owner;
               NumarulContului = numarulContului;
               MonedaContului = monedaContului;
               PIN = pin;

               tranzactii = new List<decimal>();
          }
          public  void Depozit(decimal amount)
          {
               tranzactii.Add(amount);
               Console.WriteLine($"Depozitul {amount} {MonedaContului}");
          }
          public void ExtragereFond(decimal amount)
          {
               if (amount <= GetBalance())
               {
                    tranzactii.Add(-amount);
                    Console.WriteLine($"Extragerea fondului {amount} {MonedaContului}");
               }
               else
               {
                    Console.WriteLine("Insuficienta de fonduri");
               }
          }

          public decimal GetBalance()
          {
               decimal balance = 0;

               foreach (var tranzactii in tranzactii)
               {
                    balance += tranzactii;
               }

               return balance;
          }
     }

     class Program
     {
          static void Main()
          {
               Persoana persoana = new Persoana("1234567890");
               ContBancar contBancar = new ContBancar(persoana, "123456789", "USD", 1234);

               contBancar.Depozit(500);
               contBancar.ExtragereFond(200);
               contBancar.Depozit(1000);

               decimal balance = contBancar.GetBalance();
               Console.WriteLine($"Current balance: {balance} {contBancar.MonedaContului}");

               Console.ReadLine();
          }
     }
}