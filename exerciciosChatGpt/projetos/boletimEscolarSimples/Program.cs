

/*Console.WriteLine("BEM VINDO\n1. Cadastrar Aluno\n2.Cadastrar Nota\n3.Sair");
string escolha = Console.ReadLine();
string[] materias = new string[] {"Matemática", "Química", "Física"};

switch (escolha)
{
    case "1":
        Console.WriteLine("Digite o nome do aluno:");
        string aluno1 = Console.ReadLine();
        break;

    case "2":
        Console.WriteLine("Digite o nome do aluno:");

        break;

    case "3":
        

        break;

} */





string escolha = "";
string[] aluno = new string[] {"Pedro", "Ana Julia", "Amélia"};
double[] media =new double[] {0, 0, 0,};
int notaMatematica = 0, notaQuimica = 0, notaFisica = 0;
bool intNumber = false;
int escolha2Integer = 0;
//double mediaPedro = 0, mediaAna = 0, mediaAmelia = 0;
string situacao = "";
do 
{
    Console.WriteLine("\nBem Vindo:\n 1. Cadastrar Notas\n 2. Calcular média\n 3. Sair");
    escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Escolha o aluno:");
        Console.WriteLine("1.Pedro\n2.Ana Julia\n3.Amélia");
        string escolha2 = Console.ReadLine();
        intNumber = int.TryParse(escolha2, out escolha2Integer);
        

        // tentar diminuir a quantidade de linhas de codigo
        // usar, talvez, um FOR?

        // garantir que o input esteja correto!!!

        switch (escolha2Integer)
        {
            case 1:

                
            
                Console.WriteLine($"Você selecionou {aluno[escolha2Integer - 1]}");
                Console.WriteLine("Digite a nota de Matemática:");
                int.TryParse(Console.ReadLine(), out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                int.TryParse(Console.ReadLine(), out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                int.TryParse(Console.ReadLine(), out notaFisica);

                media[escolha2Integer - 1] = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;

                case 2:

                Console.WriteLine($"Você selecionou {aluno[escolha2Integer - 1]}");
                Console.WriteLine("Digite a nota de Matemática:");
                int.TryParse(Console.ReadLine(), out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                int.TryParse(Console.ReadLine(), out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                int.TryParse(Console.ReadLine(), out notaFisica);

                media[escolha2Integer - 1] = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;

                case 3:
                Console.WriteLine($"Você selecionou {aluno[escolha2Integer - 1]}");
                Console.WriteLine("Digite a nota de Matemática:");
                int.TryParse(Console.ReadLine(), out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                int.TryParse(Console.ReadLine(), out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                int.TryParse(Console.ReadLine(), out notaFisica);

                media[escolha2Integer - 1] = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;
        }
        break;

    case "2":

        for (int i = 0; i < aluno.Length; i++)
        {

        if (media[i] >= 7) situacao = "Aprovado";
        else if (media[i] >= 5 && media[i] <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";


        Console.WriteLine($"\nAluno: {aluno[i]} - Média: {media[i]:F2} - Situação: {situacao}");
        }
        /*if (mediaAna >= 7) situacao = "Aprovado";
        else if (mediaAna >= 5 && mediaAna <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";

        Console.WriteLine($"\nAluno: Ana Julia - Média: {mediaAna} - Situação: {situacao}");

        if (mediaAmelia >= 7) situacao = "Aprovado";
        else if (mediaAmelia >= 5 && mediaAmelia <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";

        Console.WriteLine($"\nAluno: Amélia - Média: {mediaAmelia} - Situação: {situacao}"); */


        break;    
}
} while(escolha != "3");

Console.WriteLine("\nPrograma encerrado. Até mais!");



