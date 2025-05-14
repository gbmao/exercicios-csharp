﻿/*string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {1}, {0}!", first, second);
*/

/*
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N2} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

 price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";
Console.WriteLine(yourDiscount);

*/
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
string input = "Pad this";
 Console.WriteLine(input.PadLeft(120)); */

//string input = "Pad this";
//Console.WriteLine(input.PadLeft(12, '-'));
//Console.WriteLine(input.PadRight(12, '-'));


/*
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Dear {0},", customerName);
Console.WriteLine("As a customer of our {0} offering we are excited to tell you about a new financial product that would dramatically increase your return.", currentProduct);
Console.WriteLine();
Console.WriteLine("Currently, you own {0:N3} shares at a return of {1:P2}.", currentShares , currentReturn);
Console.WriteLine("Our new product, {0} offers a return of {1:P2}.  Given your current volume, your potential profit would be {2:c}.",newProduct , newReturn , newProfit  );


Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += currentProduct.PadRight( 20 );
comparisonMessage += $"{currentReturn:P2}";
comparisonMessage += $"{currentProfit:c}".PadLeft(20);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}";
comparisonMessage += $"{newProfit:C}".PadLeft(20);
Console.WriteLine(comparisonMessage);