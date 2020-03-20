namespace FormattingStrings
{
    public class AlignmentFormatting
    {
        public static void ExampleWithRightAlignments(int alignmentSize)
        {
            for (int i = 0; i <= 100; i += alignmentSize)
            {
                System.Console.WriteLine("{0, " + i + "} Alignment", i);
            }
        }
    }
}