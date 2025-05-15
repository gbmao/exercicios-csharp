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


for (int i = 0; i <= 100; i++)
{
    string sound = "";

    if (i % 3 == 0) sound = " - Fizz";
    if (i % 5 == 0) sound = " - Buzz";  
    if ((i % 3 == 0) && (i % 5 == 0)) sound = " - FizzBuzz";
    Console.WriteLine(i + sound);
    
}

/*  ### solução:


for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
} */

string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
};

/*foreach (string[] array in jaggedArray)
{
    foreach (string value in array)
    {
        Console.WriteLine(value);
    }
    Console.WriteLine();
} */

//Console.WriteLine (jaggedArray[0][1]);

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 6; j++)
    {
    Console.Write(jaggedArray[i][j]+" ");
    }
    Console.WriteLine();
}

foreach (string[] array in jaggedArray)
{
    foreach (string array2 in array)
    {
    Console.Write(array2 + " ");
    
    }
    Console.WriteLine();
}