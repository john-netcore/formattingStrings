using System;

namespace FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Examples using index formatting:");
            IndexFormatting.ExampleWithOneIndex(16, "students");
            IndexFormatting.ExampleWithThreeIndexes(7, 9, 2);
            IndexFormatting.ExampleUsingFormatMethod(10);
            IndexFormatting.ExampleUsingStringBuilderClass(24);

            System.Console.WriteLine();

            System.Console.WriteLine("Examples using numeric data formatting:");
            NumericDataFormatting.ExampleWithDifferentNumericNotations(10);
            System.Console.WriteLine();
            NumericDataFormatting.ExampleFormattingDecimalAndHexaDecimalData();

            System.Console.WriteLine();

            System.Console.WriteLine("Example with alignment:");
            AlignmentFormatting.ExampleWithRightAlignments(10);

            System.Console.WriteLine();

            System.Console.WriteLine("Examples with Date and Time:");
            DateAndTimeFormatting.ExamplesWithDateFormatting();
            DateAndTimeFormatting.ExamplesWithTimeFormatting();

            System.Console.WriteLine();

            CustomFormatting.ExampleNumericCustomFormatting(4000000000L);
        }
    }
}
