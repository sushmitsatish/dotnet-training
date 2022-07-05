using System.ComponentModel;
using System.Globalization;
using System.Text;
using static System.Console;

namespace II.PrimitiveTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Conversion();
            // PrimitiveTypesSize();
            CastTypes();
        }

        public static void Conversion()
        {
            // Without Validation
            // Throws FormatErrorException when Conversion not Possible
            int x = Convert.ToInt32("34");
            // Different NumberStyles Allowed in Input String
            WriteLine($"{int.Parse("34")}");
            WriteLine("-------- Different NumberStyles Allowed in Input String with \"Parse\" methods --------");
            WriteLine($"Trailing Spaces :34     : {int.Parse("34     ", NumberStyles.AllowTrailingWhite)}");
            WriteLine($"Leading Spaces :      34: {int.Parse("      34", NumberStyles.AllowLeadingWhite)}");
            WriteLine($"With Currency :34$: {int.Parse("34$", NumberStyles.Currency)}");
            WriteLine($"With Parenthesis :(67): {int.Parse("(67)", NumberStyles.AllowParentheses)}");
            WriteLine($"With Thousands Format :(67,001): {int.Parse("67,0001", NumberStyles.AllowThousands)}");

            // Capturing Format Exceptions
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

            // Base64 Conversion
            var encodedBytes = Encoding.UTF8.GetBytes("This#$%^&*( SpecialChars");
            var base64String = Convert.ToBase64String(encodedBytes);
            var decodedString = Encoding.UTF8.GetString(Convert.FromBase64String(base64String));
            WriteLine($"Convert.ToBase64String => To Base64 String \n {base64String}");
            WriteLine($"Convert.FromBase64String => From Base64 String \n {decodedString}");


            // Exercise
            // Try Other Conversion Type Methods in .NET
        }

        public static void CastTypes()
        {
            WriteLine("-------- Using Casting methods --------");
            WriteLine($"Casting to Int :(int)34.56     : {(int)34.56} ==> Always Floor Value");
            WriteLine($"Casting to Int :(int)34.90     : {(int)34.90} ==> Always Floor Value");
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