using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._3
{
     public class Student
     {
          public string Nume { get; set; }
          public int Varsta { get; set; }    
          public string Specializare { get; set; }

          public Student(string nume, int varsta, string specializare)
          {
               Nume = nume;
               Varsta = varsta;
               Specializare = specializare;
          }

          public Student(Student student)
          {
               Nume = student.Nume;
               Varsta = student.Varsta;
               Specializare = student.Specializare;
          }

          public void AfisareDetalii()
          {
               Console.WriteLine("Informatiile studentului: " );
               Console.WriteLine("Nume: " + Nume);
               Console.WriteLine("Varsta " + Varsta);
               Console.WriteLine("Specializarea: " + Specializare);
               Console.WriteLine();
          }
     }
}
