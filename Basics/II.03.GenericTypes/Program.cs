using System.Xml;

namespace II.GenericTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // List of Primitive Types
            List<int> objInts = new List<int>();

            // List for Custom Reference Types
            // using ObjectInitializer 
            List<ListItem> items = new List<ListItem>()
            {
                new ListItem("Item_1"),
                new ListItem("Item_2")
            };

            foreach (var listItem in items)
            {
                Console.WriteLine(listItem.Name);
                listItem.PassType(4);
                listItem.PassType("PassedString");
                listItem.PassType(listItem);
            }
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

    public class ListItem
    {
        public string Name { get; set; }
        public ListItem(string name)
        {
            Name = name;
        }

        public void PassType<T>(T objInst)
        {
            Console.WriteLine(objInst);
        }
    }
}