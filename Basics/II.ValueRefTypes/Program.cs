using System.Runtime.InteropServices;
using static System.Console;
namespace II.ValueRefTypes
{
    public class Program
    {
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

        public static void DemoRefMemory()
        {
            var obj1 = new DemoRefClass();
            var obj2 = obj1;

            var alloc1 = GCHandle.Alloc(obj1, GCHandleType.WeakTrackResurrection);
            var alloc2 = GCHandle.Alloc(obj2, GCHandleType.WeakTrackResurrection);
            WriteLine($"Mem Address of 1st Var: {GCHandle.ToIntPtr(alloc1).ToInt64()}");
            WriteLine($"Mem Address of 2nd Var: {GCHandle.ToIntPtr(alloc2).ToInt64()}");
        }
    }

    public class DemoRefClass
    {
        public int RefClassProp1 { get; set; }
    }
}