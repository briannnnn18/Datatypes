using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
           //normal print of what needed
            Console.Write("Enter the number of pieces of apple: ");
            int piecesOfApple = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter the total price of the apple(s): ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            // price of apple
            Console.WriteLine($"Total price of {piecesOfApple} piece(s) of apple: {totalPrice}");

            // price to whole number 
            int wholePrice = (int)totalPrice;

            // display of value and converted price
            Console.WriteLine($"The value of original price: {totalPrice}");
            Console.WriteLine($"The value of converted price (whole number): {wholePrice}");

            //any key to stop the running code
            Console.WriteLine("Press any key to exit..... ");
            Console.ReadKey();
        }
    }
}