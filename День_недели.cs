using System;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int a;
      Console.WriteLine("Введи число, а я скажу какой это день недели :)");
        a = Convert.ToInt32((Console.ReadLine()));
          if (a == 1)
          {
            Console.WriteLine("Кнш это понедельник");
          }
          if (a == 2)
          {
            Console.WriteLine("Кнш это вторник");
          }
          if (a == 3)
          {
            Console.WriteLine("Кнш это среда");
          }
          if (a == 4)
          {
            Console.WriteLine("Кнш это четверг");
          }
          if (a == 5)
          {
            Console.WriteLine("Кнш это пятница");
          }
          if (a == 6)
          {
            Console.WriteLine("Кнш это суббота");
          }
          if (a == 7)
          {
            Console.WriteLine("Кнш это воскресенье");
          }
          if (a > 7)
          {
            Console.WriteLine("Такого дня недели нет :(");
          }
    }
  }
}