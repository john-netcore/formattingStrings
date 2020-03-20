using System.Text;

namespace FormattingStrings
{
    public class IndexFormatting
    {
        public static void ExampleWithOneIndex(int nType, string type)
        {
            System.Console.WriteLine("There are {0} {1} in class.", nType, type);
        }

        public static void ExampleWithThreeIndexes(int nBananas, int nApples, int nOranges)
        {
            System.Console.WriteLine("There are {0} bananas, {1} apples and {2} oranges left", nBananas, nApples, nOranges);
        }

        public static void ExampleUsingFormatMethod(int nTeachers)
        {
            string format = "There are {0} teachers available";
            string message = string.Format(format, nTeachers);
            System.Console.WriteLine(message);
        }

        public static void ExampleUsingStringBuilderClass(int nClassrooms)
        {
            string format = "The school has {0} classrooms";
            var builder = new StringBuilder();
            builder.AppendFormat(format, nClassrooms);
            System.Console.WriteLine(builder);
        }
    }
}