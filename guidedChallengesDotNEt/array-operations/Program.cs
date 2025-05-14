//string[] pallets = ["B14", "A11", "B12", "A13",];
//int i = 0;
/*Console.WriteLine("Sorted...");
Array.Sort(pallets); //modo alfanumerico
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets); // reverte a ordem
foreach(var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
------------------
Array.Clear(pallets, 0, 2);

Console.WriteLine($"Clearing 2... count: {pallets.Length}");
foreach(var pallet in pallets)
{
    Console.WriteLine($"--  {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... Count: {pallets.Length}");

//pallets[4] = "C01";
pallets[5] = "C02";

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// removendo
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    i++;
    Console.WriteLine($"-{i} {pallet}");
} */

/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string (valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/*

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);


*/


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderID = orderStream.Split(",");

Array.Sort(orderID);

foreach (string order in orderID)
{
    if (order.Length == 4)
    {
        Console.WriteLine(order);
    }else{
        Console.WriteLine(order + "\t- Error");
    }
}