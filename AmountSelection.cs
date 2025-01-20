using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    public class AmountSelection
    {
        public decimal GetAmountSelected()
        {
            string? input = Console.ReadLine();
            bool validInput = decimal.TryParse(input, out decimal amount);

            while (!validInput && amount < 0)
            {
                Console.WriteLine();
                Console.WriteLine("The input is not valid!");
                Console.Write("Enter a value: ");
                input = Console.ReadLine();
                validInput = decimal.TryParse(input, out amount);
            }
            return amount;
        }
    }
}
