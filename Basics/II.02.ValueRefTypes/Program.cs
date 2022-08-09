using System.Runtime.InteropServices;
using static System.Console;

namespace II.ValueRefTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i1 = 20;
            int i2 = 30;

            DemoRefClass obj1 = new DemoRefClass();
            obj1.ValueTypeProp = 10;
            obj1.RefTypeProp = "Hello";

            PassRefAndValue(obj1, i2);

            Console.WriteLine(obj1.RefTypeProp);
            Console.WriteLine(obj1.ValueTypeProp);
        }

        public static void PassRefAndValue(DemoRefClass p1, int p2)
        {
            p1.ValueTypeProp = 20;
            p1.RefTypeProp = "Changed";
        }

        public static void PassValue(int p1, int p2)
        {
            p1 = 10;
            p2 = 30;
        }

        public static void PassRefValue_Second(DemoRefClass p1)
        {
            // Will effect only p1 parameter which is local to this function. 
            // Will not effect the original value in Main function
            p1 = new DemoRefClass();
        }
    }

    public class DemoRefClass
    {
        public int ValueTypeProp { get; set; }
        public string RefTypeProp { get; set; }
    }
}