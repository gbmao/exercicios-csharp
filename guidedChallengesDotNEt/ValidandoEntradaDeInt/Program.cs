/*Console.WriteLine("Please enter an integer between 5 and 10:");
string input = Console.ReadLine();
int number = 0;
bool intNumber = false;
intNumber = int.TryParse(input, out number); */

//number++;

//Console.WriteLine(number);

int number = 0;
do
{
    Console.WriteLine("Please enter an integer between 5 and 10:");
    string? input = Console.ReadLine();
    
    bool intNumber = false;

    intNumber = int.TryParse(input, out number); 
    
    //A solução deve garantir que a entrada seja uma representação válida de um inteiro.
    if (intNumber == true) 
    {
        
           //Se o valor inteiro não estiver entre 5 e 10, 
           // o código deverá usar uma instrução Console.WriteLine() 
           // para solicitar ao usuário um valor inteiro entre 5 e 10.
            if ((number <= 5)||(number >= 10))
            {
                Console.WriteLine($"You entered {number}. The number must be bewteen 5 and 10...");
                continue;
            }

    } else 
    {
            Console.WriteLine("Not a valid integer number, please try again");
            continue;
    }

} while ((number < 5)||(number > 10));

Console.WriteLine($"Your input value ({number}) has been acepted.");