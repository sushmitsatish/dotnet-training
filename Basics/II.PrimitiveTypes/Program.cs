using static System.Console;

namespace II.PrimitiveTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conversion();
        }

        public static void Conversion()
        {
            // Without Validation
            // Throws FormatErrorException when Conversion not Possible
            int x = Convert.ToInt32("34");

            try
            {
                Convert.ToInt32("45.67");
            }
            catch (FormatException ex)
            {
                WriteLine(ex.Message);
            }
            
            // With Validation
            // Returns True if Conversion is Possible
            if (int.TryParse("34.56", out int strToInt))
            {
                
            }
        }
        
        public static void PrimitiveTypesSize()
        {
            WriteLine("--------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory               Min                            Max");
            WriteLine("--------------------------------------------------------------------------");
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("--------------------------------------------------------------------------");
        }
    }
}