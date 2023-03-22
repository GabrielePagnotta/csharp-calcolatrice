using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoliHelper
{
    public class Helper
    {
        public static int Somma(int num1, int num2) => num1 + num2;
        public static double Somma(double num1, double num2) => num1 + num2;

        public static void Differenza(int num1,int num2)
        {
            Console.WriteLine("inserisci il primo numero");
            

            if (num1 < num2)
            {
                Console.WriteLine("il primo numero deve essere maggiore del secondo");
            }else if (num1 - num2 == 0)
            {
                Console.WriteLine("non c'è differenza");
            }
            else
            {

            Console.WriteLine($"la differenza tra {num1} e {num2} è {num1 - num2}");
            }
            

        }
        public static void Differenza(double num1, double num2)
        {
            Console.WriteLine("inserisci il primo numero");


            if (num1 < num2)
            {
                Console.WriteLine("il primo numero deve essere maggiore del secondo");
            }
            else if (num1 - num2 == 0)
            {
                Console.WriteLine("non c'è differenza");
            }
            else
            {

                Console.WriteLine($"la differenza tra {num1} e {num2} è {num1 - num2}");
            }


        }

    }
}
