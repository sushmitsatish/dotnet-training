using System.Runtime.InteropServices;
using static System.Console;

namespace II.ValueRefTypes
{
    public class Program
    {
        public static DemoRefClass globalObj1;
        public static void Main(string[] args)
        {
            // DemoValMemory();
            DemoRefMemory();
        }

        public static void DemoValMemory()
        {
            unsafe
            {
                var mem1 = 24;
                var mem2 = mem1;
                WriteLine($"Mem Address of 1st Var: {new IntPtr(&mem1)}");
                WriteLine($"Mem Address of 2nd Var: {new IntPtr(&mem2)}");

                DemoValPassFunc(mem1);
            }
        }

        public static void DemoValPassFunc(int param1)
        {
            unsafe
            {
                WriteLine($"Mem Address Passed to Func 1st Var: {new IntPtr(&param1)}");
                param1 = 10;
                WriteLine($"Mem Address Reassigned Value Inside Func: {new IntPtr(&param1)}");
            }
        }

        static void DemoRefMemory()
        {
            globalObj1 = new DemoRefClass();
            var obj2 = globalObj1;

           WriteLine($"Obj2 Equals Obj1 => {obj2.Equals(globalObj1)}");
           PassRefType(globalObj1);
        }

        static void PassRefType(DemoRefClass obj1)
        {
            WriteLine($"Passed Obj1 Equals Instance From Caller => {globalObj1.Equals(obj1)}");

            //ReAssign passed Ref
            obj1 = new DemoRefClass();
            WriteLine($"Re Assigned Obj1 Equals Passed Instance From Caller => {globalObj1.Equals(obj1)}");
        }
    }

    public class DemoRefClass
    {
        public int RefClassProp1 { get; set; }
    }
}