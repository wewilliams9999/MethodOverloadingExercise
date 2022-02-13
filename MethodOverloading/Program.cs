using System;

namespace MethodOverloading
{
    class Program
    {  //1st example
        public static int Add(int a, int b)
        {
            return a + b;
        }

       //2nd example
        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

       //3rd example
        public static string Add(int e, int f, bool g)
        {
            if (g == true && e+f > 1)
            {
                return $"{e + f} + dollars";
            }
            else if (g == true && e+f == 1)
            {
                return $"{e + f} dollar";
            }
            else
            {
                return $"{e + f}";
            }
        }

        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

                var answer = Add(x, y);

            var c = 32.0m;
            var d = 45.0m;

                var decimalAnswer = Add(c, d);
            
            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);

        }
    }
}
