namespace CurrencyConvertor;

public class CurrencySelection
{
    public Currency GetSelectedCurrency(List<Currency> currencies)
    {
        Currency? selectedCurrency = null;

        while (selectedCurrency == null)
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < currencies.Count; i++)
            {
                Currency currentCurrency = currencies[i];

                //if (input == currentCurrency.Abbreviation)
                //{
                //    selectedCurrency = currentCurrency;
                //    break;
                //}

                bool isAnAbbreviation = false;

                if (!isAnAbbreviation)
                {
                    isAnAbbreviation = string.Equals(input, currentCurrency.Abbreviation, StringComparison.OrdinalIgnoreCase);

                    bool isSelectedIndex = isAnAbbreviation;

                    if (isSelectedIndex)
                    {
                        selectedCurrency = currentCurrency;
                        break;
                    }


                }

                bool isANumber = int.TryParse(input, out int numberInput);

                if (isANumber)
                {

                    bool isSelectedIndex = numberInput == i;

                    if (isSelectedIndex)
                    {
                        selectedCurrency = currencies[numberInput];
                        break;
                    }
                }
            }
            if (selectedCurrency == null)
            {
                Console.WriteLine("The input data is not valid!");
                Console.WriteLine();
                Console.WriteLine("Enter the currency number or its abbreviation: ");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"You selected : {selectedCurrency.Name}");

        return selectedCurrency;
    }
}
