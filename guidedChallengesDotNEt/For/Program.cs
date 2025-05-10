/*for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}




string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


string[] names = { "Alex", "Eddie", "David", "MIchael",};
foreach (var name in names)
{
    // can't do this
    if (name == "David") name = "Sammy";
}


string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
*/

for (int i = 0; i <= 100; i++)
{
    string sound = "";

    if (i % 3 == 0) sound = " - Fizz";
    if (i % 5 == 0) sound = " - Buzz";  
    if ((i % 3 == 0) && (i % 5 == 0)) sound = " - FizzBuzz";
    Console.WriteLine(i + sound);
    
}