using System;

struct Angajat
{
     public string Nume;
     public string Departament;
     public decimal Salariu;
}

class Program
{
     static void Main()
     {
          int numarAngajati = 3;
          Angajat[] angajati = new Angajat[numarAngajati];

          for (int i = 0; i < numarAngajati; i++)
          {
               Console.WriteLine("Introduceti datele pentru angajatul {0}:", i + 1);

               Console.Write("Nume: ");
               string nume = Console.ReadLine();

               Console.Write("Departament: ");
               string departament = Console.ReadLine();

               Console.Write("Salariu: ");
               decimal salariu = Convert.ToDecimal(Console.ReadLine());

               angajati[i] = new Angajat { Nume = nume, Departament = departament, Salariu = salariu };
          }

          decimal sumaSalarii = 0;

          for (int i = 0; i < numarAngajati; i++)
          {
               sumaSalarii += angajati[i].Salariu;
          }

          decimal salariuMediu = sumaSalarii / numarAngajati;

          Console.WriteLine("Salariul mediu: {0}", salariuMediu);

          Console.WriteLine("Angajatii cu salariul mai mare decat media:");

          for (int i = 0; i < numarAngajati; i++)
          {
               if (angajati[i].Salariu > salariuMediu)
               {
                    Console.WriteLine(angajati[i].Nume);
               }
          }

          Console.ReadKey();
     }
}