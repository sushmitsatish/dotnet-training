using System.ComponentModel;

namespace IV.ObjectOrientedProgramming
{
    public class Program
    {
        public static void Main()
        {
            int i1 = 20;
            int i2 = 30;

            PassValue(i1, i2);
            PassValue_Second(i1 = 80, i2 = 90);

            Console.WriteLine(i1);
            Console.WriteLine(i2);
        }

        public static void PassValue(int p1, int p2)
        {
            p1 = 10;
            p2 = 30;
        }

        public static void PassValue_Second(int p1, int p2)
        {
            p1 = 10;
            p2 = 30;
        }
    }
}