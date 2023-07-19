using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._2
{
     public class Carte
     {
          public string Titlu { get; set; }
          public string Autor { get; set; }
          public int AnPublicare { get; set; }
          public int NumarPagini { get; set; }

          public Carte(string titlu, string autor, int anPublicare, int numarPagini)
          {
               Titlu = titlu;
               Autor = autor; 
               AnPublicare = anPublicare;
               NumarPagini = numarPagini;

          }

          public void AfisareDetalii()
          {
               Console.WriteLine("Detalii despre carte: ");
               Console.WriteLine("Titlul: " + Titlu);
               Console.WriteLine("Autorul: " + Autor);
               Console.WriteLine("Anul publicarii: " + AnPublicare);
               Console.WriteLine("Numarul de pagini: " + NumarPagini);          
          }
               

     }
}
