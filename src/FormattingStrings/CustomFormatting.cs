namespace FormattingStrings
{
    public class CustomFormatting
    {
        public static void ExampleNumericCustomFormatting(long billionNumber)
        {
            string customNumericFormat = "{0:### ### ### ###}";
            string formattedNumber = string.Format(customNumericFormat, billionNumber);
            System.Console.WriteLine(formattedNumber);
        }
    }
}