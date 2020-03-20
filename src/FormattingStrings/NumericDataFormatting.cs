namespace FormattingStrings
{
    public class NumericDataFormatting
    {
        public static void ExampleWithDifferentNumericNotations(int number)
        {
            System.Console.WriteLine("Number N: {0:N}", number);
            System.Console.WriteLine("Decimal D: {0:D}", number);
            System.Console.WriteLine("Scientific E: {0:E}", number);
            System.Console.WriteLine("Currency C: {0:C}", number);
            System.Console.WriteLine("Percent P: {0:P}", number);
            System.Console.WriteLine("Hexadecimal X: {0:X}", number);
        }

        public static void ExampleFormattingDecimalAndHexaDecimalData()
        {
            // {1, 12} The number twelve is the number of spaces.
            System.Console.WriteLine("{0} {1, 12}", "Decimal", "Hexadecimal");

            for (int i = 0; i <= 15; i++)
            {
                int rightAlignment = (i > 9) ? 7 : 8;
                //The letter D stands for Decimal.
                //The letter X stands for Hexadecimal.
                string format = "{0:D} {1, " + rightAlignment + ":X}";
                System.Console.WriteLine(format, i, i);
            }
        }
    }
}