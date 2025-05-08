int[] numbers = { 4, 8, 15, 16, 23, 42};
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       bool found = true;       
       if (found) 
        {
            Console.WriteLine("Set contains 42");
        }
    }
}
Console.WriteLine($"Total: {total}");

/* bool flag = true;
int value = 0;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");


// Code sample 1
// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");


string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");
    */



