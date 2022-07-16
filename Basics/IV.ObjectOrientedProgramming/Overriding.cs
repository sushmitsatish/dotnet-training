namespace IV.ObjectOrientedProgramming
{
    public class Courier
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending by Land as Default");
        }
    }

    public class AirCourier : Courier
    {
        public override void Send()
        {
            Console.WriteLine("Overridden. Sending by Air");
        }
    }

    public class FakeCourier : Courier
    {
        public new void Send()
        {
            Console.WriteLine("Fake Temporary Courier");
        }
    }
}