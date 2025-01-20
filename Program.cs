/*
* 1.  Show home screen 
* 2.  Select from currency
* 3.  Display available currencies
* 4.  Select to currency
* 5.  Display available currencies
* 6.  Handle amount input
* 7.  Calculate result.
* 8.  Posibility to reenter selected currency and amount
* 9.  Display Exit at every step
* 10. Display rerun at the end
*/

using CurrencyConvertor;
using System.ComponentModel.DataAnnotations;

List<Currency> currencies = new();

currencies.Add(new Currency("Romanian Leu", "RON", 1m));
currencies.Add(new Currency("Euro", "EUR", 0.2009m));
currencies.Add(new Currency("American Dollar", "USD", 0.2115m));
currencies.Add(new Currency("Pound Sterling", "GBP", 0.1663m));
currencies.Add(new Currency("Swiss Franc", "CFH", 0.1873m));
currencies.Add(new Currency("Moldovan Leu", "MDL", 3.8646m));
currencies.Add(new Currency("Canadian Dollar", "CAD", 0.2967m));
currencies.Add(new Currency("Australian Dollar", "AUD", 0.3257m));
currencies.Add(new Currency("Dirham EAU", "AED", 3.8666m));
currencies.Add(new Currency("Japanese Yen", "JPY", 31.7551m));
currencies.Add(new Currency("Indian Rupee", "INR", 17.9147m));


//MAIN MENU 

string exitInput = "x";
bool isExitInput = false;


while (!isExitInput)
{

    Console.WriteLine("MAIN MENU");
    Console.WriteLine();
    Console.WriteLine("Rate of exchange in RON: ");
    Console.WriteLine();

    for (int i = 1; i < currencies.Count; i++)
    {
        decimal exchangeRon = 1 / currencies[i].Value;
        Console.WriteLine($"1 {currencies[i].Abbreviation} -> {exchangeRon} RON");
    }

    Console.WriteLine();
    Console.WriteLine("Press ENTER to Select Currency.");
    Console.WriteLine("Press X EXIT.");
    Console.WriteLine();
    string userInput = Console.ReadLine();
    isExitInput = string.Equals(userInput, exitInput, StringComparison.OrdinalIgnoreCase);

    if (isExitInput)
    {
        break;
    }



    Console.Clear();


    //SELECT CURRENCY
    Console.WriteLine("SELECT CURRENCY");
    Console.WriteLine();

    //Convert from: 

    Console.WriteLine("Convert from: ");
    Console.WriteLine();


    for (int i = 0; i < currencies.Count; i++)
    {
        Console.WriteLine($"{i} - {currencies[i].Abbreviation}");
    }

    Console.WriteLine();
    Console.WriteLine("Enter the currency number or its abbreviation: ");

    string reenterInput = "r";
    bool isReenterProgram = true;
    CurrencySelection currencySelection = new CurrencySelection();
    Currency? selectedFromCurrency = null;

    while (isReenterProgram)
    {

        selectedFromCurrency = currencySelection.GetSelectedCurrency(currencies);
        Console.WriteLine();
        Console.WriteLine("Press R to reenter the currency or ENTER to continue.");
        Console.WriteLine();
        userInput = Console.ReadLine();
        isReenterProgram = string.Equals(reenterInput, userInput, StringComparison.OrdinalIgnoreCase);

        if (isReenterProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Reenter currency:");

        }

    }

    Console.WriteLine("-----------------------------------------------------");

    //Convert to: 

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Convert to: ");
    Console.WriteLine();


    for (int i = 0; i < currencies.Count; i++)
    {
        Console.WriteLine($"{i} - {currencies[i].Abbreviation}");
    }

    Console.WriteLine();
    Console.WriteLine("Enter the currency number or its abbreviation:");

    isReenterProgram = true;
    Currency? selectedToCurrency = null;

    while (isReenterProgram)
    {
        selectedToCurrency = currencySelection.GetSelectedCurrency(currencies);
        Console.WriteLine();
        Console.WriteLine("Press R to reenter the currency or ENTER to continue.");
        Console.WriteLine();
        userInput = Console.ReadLine();
        isReenterProgram = string.Equals(reenterInput, userInput, StringComparison.OrdinalIgnoreCase);

        if (isReenterProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Reenter currency:");

        }
    }

    //Console.WriteLine();
    //Console.WriteLine("---------------------------------------------");

    //Console.WriteLine();
    //Console.WriteLine("Press ENTER to convert the selected currencies.");
    //Console.WriteLine("Press X EXIT.");
    //Console.WriteLine();
    //userInput = Console.ReadLine();
    //isExitInput = string.Equals(userInput, exitInput, StringComparison.OrdinalIgnoreCase);

    //if (isExitInput)
    //{
    //    break;
    //}

    //Calculate result
    Console.Clear();

    Console.WriteLine("CONVERT CURRENCY");
    Console.WriteLine();
    Console.Write($"Enter amount to be converted from {selectedFromCurrency.Name} to {selectedToCurrency.Name}: ");

    AmountSelection amountSelection = new AmountSelection();
    decimal selectedamount = 0;
    isReenterProgram = true;

    while (isReenterProgram)
    {
        selectedamount = amountSelection.GetAmountSelected();
        Console.WriteLine();
        Console.WriteLine("Press R to reenter the amount or ENTER to continue.");
        userInput = Console.ReadLine();
        isReenterProgram = string.Equals(reenterInput, userInput, StringComparison.OrdinalIgnoreCase);

        if (isReenterProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Reenter amount:");

        }

    }

    decimal valuebaseCurrecy = 1;
    decimal exchangeRonFromCurrency = valuebaseCurrecy / selectedFromCurrency.Value;

    decimal resultCoversion = exchangeRonFromCurrency * selectedToCurrency.Value * selectedamount;
    Console.WriteLine();
    Console.WriteLine($"{selectedamount} {selectedFromCurrency.Name} = {resultCoversion} {selectedToCurrency.Name}");


    Console.WriteLine();
    Console.WriteLine("Press ENTER to Convert Again.");
    Console.WriteLine("Press X EXIT.");
    Console.WriteLine();

    userInput = Console.ReadLine();
    isExitInput = string.Equals(userInput, exitInput, StringComparison.OrdinalIgnoreCase);

    if (isExitInput)
    {
        break;
    }

    Console.Clear();

}

