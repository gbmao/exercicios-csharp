

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
string aluno = "";
int notaMatematica = 0, notaQuimica = 0, notaFisica = 0;
double mediaPedro = 0, mediaAna = 0, mediaAmelia = 0;
string situacao = "";
do 
{
    Console.WriteLine("\nBem Vindo:\n 1. Cadastrar Notas\n 2. Calcular média\n 3. Sair");
    escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Escolhao aluno:");
        Console.WriteLine("1.Pedro\n2.Ana Julia\n3.Amélia");
        string escolha2 = Console.ReadLine();

        switch (escolha2)
        {
            case "1":

                Console.WriteLine("Digite a nota de Matemática:");
                string? pedroMatematica = Console.ReadLine();
                int.TryParse(pedroMatematica, out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                string? pedroQuimica = Console.ReadLine();
                int.TryParse(pedroQuimica, out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                string? pedroFisica = Console.ReadLine();
                int.TryParse(pedroFisica, out notaFisica);

                mediaPedro = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;

                case "2":

                Console.WriteLine("Digite a nota de Matemática:");
                string? anaMatematica = Console.ReadLine();
                int.TryParse(anaMatematica, out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                string? anaQuimica = Console.ReadLine();
                int.TryParse(anaQuimica, out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                string? anaFisica = Console.ReadLine();
                int.TryParse(anaFisica, out notaFisica);

                mediaAna = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;

                case "3":
                Console.WriteLine("Digite a nota de Matemática:");
                string? ameliaMatematica = Console.ReadLine();
                int.TryParse(ameliaMatematica, out notaMatematica);

                Console.WriteLine("Digite a nota de Química:");
                string? ameliaQuimica = Console.ReadLine();
                int.TryParse(ameliaQuimica, out notaQuimica);

                Console.WriteLine("Digite a nota de Física:");
                string? ameliaFisica = Console.ReadLine();
                int.TryParse(ameliaFisica, out notaFisica);

                mediaAmelia = ((double)notaMatematica + notaQuimica + notaFisica)/3;

                break;
        }
        break;

    case "2":

        if (mediaPedro >= 7) situacao = "Aprovado";
        else if (mediaPedro >= 5 && mediaPedro <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";


        Console.WriteLine($"\nAluno: Pedro - Média: {mediaPedro} - Situação: {situacao}");

        if (mediaAna >= 7) situacao = "Aprovado";
        else if (mediaAna >= 5 && mediaAna <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";

        Console.WriteLine($"\nAluno: Ana Julia - Média: {mediaAna} - Situação: {situacao}");

        if (mediaAmelia >= 7) situacao = "Aprovado";
        else if (mediaAmelia >= 5 && mediaAmelia <= 7) situacao = "Recuperação";
        else situacao = "Reprovado";

        Console.WriteLine($"\nAluno: Amélia - Média: {mediaAmelia} - Situação: {situacao}");


        break;    
}
} while(escolha != "3");

Console.WriteLine("\nPrograma encerrado. Até mais!");



