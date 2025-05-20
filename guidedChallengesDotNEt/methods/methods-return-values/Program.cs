﻿/*
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);

}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
*/

/*
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
*/

//string revertaIsso = "Reverta";

//Console.WriteLine(revertaIsso[6]);

/*
string revertaFrase(string revertaFrase)
{
    string result = "";
    string[] frase = revertaFrase.Split(" ");

    foreach (string palavra in frase)
    {
        result += palavraRevertida(palavra) + " ";
    }

    return result;
}



string palavraRevertida(string revertaIsso)
{
    string resultado = "";
    for (int i = revertaIsso.Length - 1; i >= 0; i--)
    {
        resultado += revertaIsso[i];
    }
    return resultado;
}

Console.Write(revertaFrase("there are snakes at the zoo"));
Console.WriteLine();
*/

/*
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    string revertedWord = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        revertedWord += word[i];
    }

    bool result;
    if (revertedWord == word)
    {
        result = true;
    }
    else
    {
        result = false;
    }

    return result;
}


// o GABARITO

bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
*/

int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }

        }
    }
    return new int[0];
}
