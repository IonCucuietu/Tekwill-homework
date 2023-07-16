using System;

namespace Exemplu
{

     public class Angajat
     {
          public string Nume { get; set; }
          public decimal Salariu { get; set; }
          public string Departament { get; set; }

          public Angajat(string nume, decimal salariu, string departament)
          {
               Nume = nume;
               Salariu = salariu;
               Departament = departament;
          }

          public void AfisareDetalii()
          {
               Console.WriteLine($"Nume: {Nume}");
               Console.WriteLine($"Salariu: {Salariu}");
               Console.WriteLine($"Departament: {Departament}");
               Console.WriteLine();
          }


     }

     class Program
     {
          static void Main()
          {
               Angajat Angajat1 = new Angajat("Mihai Modirca", 3000, "Marketing");
               Angajat Angajat2 = new Angajat("Mircea Mihalachi", 10000, "IT");

               Angajat1.AfisareDetalii();
               Angajat2.AfisareDetalii();
          }

     }
}
