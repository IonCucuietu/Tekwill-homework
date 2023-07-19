using Homework13._3;

namespace Exemplu
{
     class Program
     {
          static void Main()
          {

               Student student1 = new Student("Mihai", 22, "Specialist IT");
               Student student2 = new Student(student1);

               student1.Nume = "Ion";
               student1.Varsta = 23;
               student1.Specializare = "Sofer";

               Console.WriteLine("Detalii despre studentul 1: ");
               student1.AfisareDetalii();

               Console.WriteLine("Detalii despre studentul 2: ");
               student2.AfisareDetalii();

          }
     }
}