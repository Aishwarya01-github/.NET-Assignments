using System;

namespace Prog1
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 18;
      int b = 6;
      int c = 2;
      int d = 3;

      double e = 5;
      double f = 4;
      double g = 2;

      decimal h = 1.0M;
      decimal i = 3.0M;

      Task_1.add(a, b);
      Task_1.sub(a, b);
      Task_1.mul(a, b);
      Task_1.div(a, b);
      Task_1.complex(a, b, c);
      Task_1.complex2(a, b, c, d);
      Task_1.findMinMax();
      Task_1.dbAdd(e, f, g);
      Task_1.findMinMaxDb();
      Task_1.findMinMaxDec();
      Task_1.decOp(h, i);

      double radius = 2.50;
      double area = Math.PI * radius * radius;
      Console.WriteLine($"Area : {area}");
    }
  }

  static class Task_1
  {
    public static void add(int a, int b)
    {
      Console.Write("Addition : ");
      int c = a + b;
      Console.WriteLine(c);
    }
    public static void sub(int a, int b)
    {

      Console.Write("Subtraction : ");
      int d = a - b;
      Console.WriteLine(d);
    }
    public static void mul(int a, int b)
    {

      Console.Write("Product : ");
      int e = a * b;
      Console.WriteLine(e);
    }
    public static void div(int a, int b)
    {

      Console.Write("Quotient : ");
      int f = a / b;
      Console.WriteLine(f);
    }
    public static void complex(int a, int b, int c)
    {

      Console.Write("Complex : ");
      int g = a + b * c;
      Console.WriteLine(g);
    }

    public static void complex2(int a, int b, int c, int d)
    {

      Console.Write("Complex2 : ");
      int e = (a + b) / c;
      int f = (a + b) % c;

      Console.WriteLine($"quotient : {e}");
      Console.WriteLine($"remainder : {f}");
    }

    public static void findMinMax()
    {

      Console.Write("FindMinMax : ");
      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine($"The range of integers is {min} to {max}");
    }

    public static void dbAdd(double a, double b, double c)
    {

      Console.Write("DbAdd : ");
      double d = (a + b) / c;
      Console.WriteLine(d);
    }

    public static void findMinMaxDb()
    {

      Console.Write("FindMinMaxDb : ");
      double max = double.MaxValue;
      double min = double.MinValue;
      Console.WriteLine($"The range of double is {min} to {max}");
    }

    public static void findMinMaxDec()
    {

      Console.Write("FindMinMaxDec : ");
      decimal min = decimal.MinValue;
      decimal max = decimal.MaxValue;
      Console.WriteLine($"The range of the decimal type is {min} to {max}");
    }

    public static void decOp(decimal a, decimal b)
    {

      Console.Write("DecOp : ");
      Console.WriteLine(a / b);
    }
  }
}