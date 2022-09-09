namespace pennies_from_heaven
{
    internal class Program
    {
        public static void Math_Stuff()
        {
            Console.WriteLine("Welcome to the best penny divider this side of the Mississippi.");

            Console.Write("Enter the amount of pennies you have: ");
            double pennies = Convert.ToDouble(Console.ReadLine());

            //there's like 100% a way easier and better way to do this but I'm tired so I don't wanna think rn
            double dollar = Math.Floor(pennies / 100);
            double quarter = Math.Floor((pennies - dollar * 100) / 25);
            double dime = Math.Floor((pennies - ((dollar * 100) + (quarter * 25))) / 10);
            double nickel = Math.Floor((pennies - ((dollar * 100) + (quarter * 25) + (dime * 10))) / 5);
            double left_over = Math.Floor(pennies - ((dollar * 100) + (quarter * 25) + (dime * 10) + (nickel * 5)));

            Console.WriteLine($"I have ran the calculations, your total is {dollar} dollars, {quarter} quarters, {dime} dimes, {nickel} nickels, and {left_over} pennies, thanks for using me broski.");

            Console.ReadLine();


        }

    }
}