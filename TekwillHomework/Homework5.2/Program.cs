using System;
using System.Runtime.InteropServices;

namespace Exemplu
{
     public class Program
     {
          struct Student
          {
               public string nume;
               public int varsta;
               public string specializare;
               public anulDeStudii anDeStudii;

          }

          enum anulDeStudii
          {
               I,
               II,
               III,
               IV
          }

          static void Main()
          {
               Student student;


               Console.WriteLine("Introduceti informatiile despre student: ");
               Console.Write("Numele: ");
               student.nume = Console.ReadLine();

               Console.Write("Varsta: ");
               student.varsta = int.Parse(Console.ReadLine());

               Console.Write("Specializarea: ");
               student.specializare = Console.ReadLine();

               Console.Write("Anul de studii: ");
               student.anDeStudii = (anulDeStudii)Enum.Parse(typeof(anulDeStudii), Console.ReadLine());

               Console.WriteLine("\nInformatii despre student:");
               Console.WriteLine($"Nume: {student.nume}");
               Console.WriteLine($"Varsta: {student.varsta}");
               Console.WriteLine($"Specializare: {student.specializare}");
               Console.WriteLine($"Anul de studii: {student.anDeStudii}");

          }
     }


}




