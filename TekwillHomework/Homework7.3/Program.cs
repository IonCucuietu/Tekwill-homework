using System;

class Program
{
     static void Main()
     {
          int marimeTabla = 8;
          int[,] tabla = new int[marimeTabla, marimeTabla];

         
          for (int i = 0; i < marimeTabla; i++)
          {
               for (int j = 0; j < marimeTabla; j++)
               {
                    
                    if ((i + j) % 2 == 0)
                    {
                         tabla[i, j] = 1; 
                    }
                    else
                    {
                         tabla[i, j] = 0; 
                    }
               }
          }

         
          for (int i = 0; i < marimeTabla; i++)
          {
               for (int j = 0; j < marimeTabla; j++)
               {
                    Console.Write(tabla[i, j] + " ");
               }
               Console.WriteLine();
          }

          Console.ReadKey();
     }
}