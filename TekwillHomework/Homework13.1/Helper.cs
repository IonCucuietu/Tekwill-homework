using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._1
{
     public static class Helper
     {
          public static string GenerareCodUnic(string prefix)
          {
               Random random = new Random();
               int numarAleatoriu = random.Next(100, 1000);

               string CodUnic = prefix + numarAleatoriu;

               return CodUnic;
          }
     }
}
