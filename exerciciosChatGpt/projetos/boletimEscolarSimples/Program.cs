

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



int numeroMaximoAluno = 5;

string[,] notasAlunos = new string[numeroMaximoAluno, 4];
int alunosCadastrador = 0;

string escolha2 = "";
string escolha = "";
string[] aluno = new string[] { "Pedro", "Ana Julia", "Amélia" };
double[] media = new double[] { 0, 0, 0, };
int notaMatematica = 0, notaQuimica = 0, notaFisica = 0;
bool intNumber = false;
int escolha2Integer = 0;
//double mediaPedro = 0, mediaAna = 0, mediaAmelia = 0;
string situacao = "";
string? readResult = "";


//  atribuir valores pra string
for (int i = 0; i < numeroMaximoAluno; i++)
{
    int j = 0;
    notasAlunos[i, j] = "";
    notasAlunos[i, 1] = "Matemática: " + notaMatematica;
    notasAlunos[i, 2] = "Química: " + notaQuimica;
    notasAlunos[i, 3] = "Física: " + notaFisica;
}




do
{

    Console.WriteLine("1. Cadastrar alunos");
    Console.WriteLine("2. Cadastrar notas");
    Console.WriteLine("3. Calcular média e aprovados");
    Console.WriteLine("Digite o número selecionado (Ou digite Sair para fechar)");
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        escolha = readResult.ToLower();
    }

    switch (escolha)
    {
        case "1":
            do
            {
                escolha2 = "s";
                // contar numero livre de alunos
                // retirar
                int numeroAlunos = 0;
                for (int i = 0; i < numeroMaximoAluno; i++)
                {
                    if (notasAlunos[i, 0] != "")
                    {
                        numeroAlunos += 1;
                    }
                }

                if (numeroMaximoAluno > numeroAlunos)
                {

                    Console.WriteLine($"Atualmente existem {numeroAlunos} cadastrados, deseja adicionar mais? (s/n)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        escolha2 = readResult.ToLower();
                    }
                    if (escolha2 == "s")
                    {
                        Console.WriteLine("Digite o nomer do aluno que deseja cadastrar:");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {

                            notasAlunos[alunosCadastrador, 0] = readResult;
                            alunosCadastrador += 1;

                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Já temos o número máximo de alunos ({numeroAlunos}) Tecle enter para voltar pro menu anterior");
                    escolha2 = "n";
                    Console.ReadLine();
                }

            } while (escolha2 != "n");
            break;

        case "2":
        //cadastrar notas
            break;

        case "3":

            for (int i = 0; i < numeroMaximoAluno; i++)
            {
                Console.WriteLine(notasAlunos[i, 0]);
                Console.ReadLine();
            }
            break;



        default:
            break;
    }

} while (escolha != "sair");

Console.WriteLine("\nPrograma encerrado. Até mais!");




/*





    /*
    switch (escolha)
    {
        case "1":
            //Console.WriteLine("Escolha o aluno:");
            //Console.WriteLine("1.Pedro\n2.Ana Julia\n3.Amélia");
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



