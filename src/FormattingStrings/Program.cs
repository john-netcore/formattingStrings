using System;

namespace FormattingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexFormatting.ExampleWithOneIndex(16);
            IndexFormatting.ExampleWithThreeIndexes(7, 9, 2);
            IndexFormatting.ExampleUsingFormatMethod(10);
            IndexFormatting.ExampleUsingStringBuilderClass(24);
        }
    }
}
