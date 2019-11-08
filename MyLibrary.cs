using System;

namespace ClassLibrary1
{
    public abstract class Count
    {
        public static double Sqare(double a)
        {
            return (Math.PI*Math.Pow(a,2));

        }
        public static double Sqare(double a,double b,double c)
        {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p*(p-a)*(p-b)*(p-c)));

        }

    }
}