using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoliHelper
{
    public static class Helper
    {
        
        public static int Somma(int num1, int num2) => num1 + num2;
        public static double Somma(double num1, double num2) => num1 + num2;

        public static int Differenza(int num1, int num2) => num1 - num2;
        
        public static double Differenza(double num1, double num2) => num1 - num2;
        
        public static int Moltiplicazione(int num1, int num2) => num1 * num2;

        public static double Moltiplicazione(double num1, double num2) => num1 * num2;

        public static int Assoluto(int num1) => Math.Abs(num1);
        public static double Assoluto(double num1) => Math.Abs(num1);

        public static int Minimo(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static double Minimo(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static int Massimo(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static double Massimo(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public static int Potenza(int num1, int num2)
        {


            int result =Convert.ToInt32( Math.Pow(num1, num2));
            bool d = (num1 == 0 && num2 == 0) ? true : false;

            if (d)
            {
                return 1;
            }
            else
            {
                return result;
            }
            

        }
    }
}
