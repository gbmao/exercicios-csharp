/*

A especificação de design para o aplicativo Contoso Petting Zoo é a seguinte:

Atualmente, há três escolas visitantes

A escola A tem seis grupos visitantes (o número padrão)
A escola B tem três grupos visitantes
A escola C tem dois grupos visitantes
Para cada escola visitante, execute as seguintes tarefas

Randomizar os animais
Atribuir os animais ao número correto de grupos
Imprimir o nome da escola
Imprimir os grupos de animais

*/


string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimal();
    string[,] group = AssigGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}
void RandomizeAnimal()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}





string[,]   AssigGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;
    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }
    return result;
}



Console.WriteLine("School A");
//RandomizeAnimal();
//PrintGroup(AssigGroup());


void PrintGroup(string[,] group)
{

    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}:  ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}




