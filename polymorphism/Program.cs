using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int addedsumnum = addtwonumbers(7,13);
            Console.WriteLine("int " + addedsumnum);
            double addedsumdouble = addtwonumbers(7,13);
            Console.WriteLine("double " + addedsumdouble);
            //int addedsumint = addtwoints(7,13);
            //double addedsumdouble = addtwodoubles(7.6,13.8);
            //Console.WriteLine("int " + addedsumint);
            //Console.WriteLine("double " + addedsumdouble);
        }

        static int addtwonumbers(int x, int y)
        {
            return x +y;
        }

        static double addtwonumbers(double x, double y)
        {
            return x +y;
        }
        //
        //static int addtwoints(int x, int y)
        //{
        //    return x +y;
        //}

        //static double addtwodoubles(double x, double y)
        //{
        //    return x +y;
        //}
        //
    }
}
