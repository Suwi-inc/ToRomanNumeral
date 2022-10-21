namespace ToRomanNumeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Value = 0;
            while (Value != -1)
            {
                Console.WriteLine("Enter an Integer Value less than 1000: ");
                try
                {
                    Value = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                Roman roman = new Roman();

                Console.WriteLine(Value + " As a Roman Numeral = " + roman.CalculateRomanValue(Value));
            }


        }
    }

      
}