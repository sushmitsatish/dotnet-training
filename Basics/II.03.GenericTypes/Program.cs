namespace II.GenericTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static void BoxingUnboxing()
        {
            // Value Type
            int val = 24;

            // Make Value Type to Ref Type (Boxing)
            object boxVal = val;

            // Make Ref Type to Value Type (UnBoxing)
            int secondVal = (int)boxVal;
            
        }
    }
}