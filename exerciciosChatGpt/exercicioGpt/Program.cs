string[] alunos = { "Ana", "Bruno", "Carlos" };
int[] notasAna = { 80, 90, 85, 70 };   // 4 notas da Ana
int[] notasBruno = { 75, 80, 85, 90 }; // 4 notas do Bruno
int[] notasCarlos = { 90, 85, 88, 80 }; // 4 notas do Carlos
int numeroMaterias = 4;
float mediaFinal = 0;
//int nota = 0;

Console.WriteLine("Aluno\tMédia");

// foreach para percorrer os nomes dos alunos
foreach (string nome in alunos)
{
    int somaNotas = 0;
    //string alunoAtual = nome;
    
    if (nome == "Ana")
    {
        foreach (int nota in notasAna)
        {
            somaNotas += nota;       
        }

    }

    if (nome == "Bruno")
    {
        foreach (int nota in notasBruno)
        {
            somaNotas += nota;       
        }


    }

    if (nome == "Carlos")
    {
        foreach (int nota in notasCarlos)
        {
            somaNotas += nota;       
        }

    }

        mediaFinal = (float)somaNotas / numeroMaterias;
        Console.WriteLine(nome +"\t" + mediaFinal);

    
}