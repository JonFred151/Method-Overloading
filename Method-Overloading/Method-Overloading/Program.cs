namespace MethodOverloading
{
    class Program
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return (double)x + y;
        }
        public static string Add(double x, double y,  bool isTrue)
        {
            if (isTrue == true)
            {
                Add(x, y);
                return $"{x + y} dollars";
            }
            else

                return $"This is fake money!";
        }
        static void Main(string[] args)
        {
            var x = 2;
            var y = 1;
            var a = 1.04;
            var b = 2.5;
            var truth = true; 

            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(a, x, truth));

        }
    }
}