using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculators
    {
        public double Plus(double a, double b)
        {
            return a + b;

        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Multi(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
            
        {
            if ( a==0 || b==0 )
            {
                return 0;
            }
            return a / b;
        }
        public double Pt(double a, double h)
        {
            return Divide(1, 2) * a * h;
        }
        public double Pc(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public double Mass(double[] mass) 
        { 
            double sum = 0;
          
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];    
            }
            return sum / mass.Length;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
           
        }
    }
}
