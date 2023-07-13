

class Program
{
     static void Main()
     {
          Console.WriteLine("Introduceti data de nastere (ziua, luna si anul):");
          Console.Write("Ziua: ");
          int ziua = int.Parse(Console.ReadLine());

          Console.Write("Luna: ");
          int luna = int.Parse(Console.ReadLine());

          Console.Write("Anul: ");
          int anul = int.Parse(Console.ReadLine());

          if (!IsValidDate(ziua, luna, anul))
          {
               Console.WriteLine("Data introdusa este invalida.");
               return;
          }

          DateTime dataNasterii = new DateTime(anul, luna, ziua);
          DateTime dataCurenta = DateTime.Now;

          TimeSpan diferenta = dataCurenta - dataNasterii;
          DateTime varsta = DateTime.MinValue + diferenta;

          int ani = varsta.Year - 1;
          int luni = varsta.Month - 1;
          int zile = varsta.Day - 1;

          Console.WriteLine($"Varsta dumneavoastra este: {ani} ani, {luni} luni și {zile} zile.");
     }

     static bool IsValidDate(int day, int month, int year)
     {
          try
          {
               DateTime date = new DateTime(year, month, day);
               return true;
          }
          catch (ArgumentOutOfRangeException)
          {
               return false;
          }
     }
}
