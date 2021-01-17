using System;

namespace TesteDIO
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] arrayIn= Console.ReadLine().Split(); 
      int t, v;
      t = int.Parse(arrayIn[0]);
      v = int.Parse(arrayIn[1]);
      double d = v * t;
      double l = d/12;
      Console.WriteLine(string.Format("{0:0.000}", l));
    }
  }
}
