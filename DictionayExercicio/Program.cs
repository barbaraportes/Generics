
Console.WriteLine("## Dictionary - Exercicio ##\n\n");

var alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 9) },
    {2, new Aluno("Eric", 8) },
    {3, new Aluno("Ana", 9) },
    {4, new Aluno("Alex", 6) },
    {5, new Aluno("Dina", 5) },
};


ExibirColecao(alunos);


//localizar e atualizar nota de um aluno
LocalizarEAtualizarNotaDeAluno(alunos);

ExibirColecao(alunos);

//remover um aluno da coleção
RemoverAluno(alunos);

ExibirColecao(alunos);

//incluindo novo aluno
IncluirNovoAluno(alunos);

ExibirColecao(alunos);


//ordenar alunos por nome

OrdenarAlunosPorNome(alunos);


//remover todos os dados da coleção

alunos.Clear();
ExibirColecao(alunos);
Console.WriteLine("\nFim do exercício ...\n");




Console.ReadKey();




static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
    Console.WriteLine("=======================================");
    Console.WriteLine("\tCHAVE  \tNOME  \tNOTA");
    Console.WriteLine("=======================================");
    foreach (var item in alunos)
    {
        Console.WriteLine($"\t{item.Key}  \t{item.Value.Nome}  \t{item.Value.Nota}");
    }
    Console.WriteLine("=======================================");
}

static void LocalizarEAtualizarNotaDeAluno(Dictionary<int, Aluno> alunos)
{
    do
    {
        Console.WriteLine("\nInforme o código do aluno a localizar (Digite 0 para sair)");
        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo == 0)
            break;

        var resultado = alunos.ContainsKey(codigo);

        if (resultado)
        {
            Console.WriteLine("Informe a nota (1 a 10)");
            var nota = Convert.ToInt32(Console.ReadLine());
            alunos[codigo].Nota = nota;
            Console.WriteLine($"\nNota de {alunos[codigo].Nome} atualizada.");
        }
        else
        {
            Console.WriteLine("Aluno não localizado");
        }

    } while (true);
}

static void RemoverAluno(Dictionary<int, Aluno> alunos)
{
    Console.WriteLine("\nInforme o código do aluno a remover");
    int cod = Convert.ToInt32(Console.ReadLine());

    if (alunos.ContainsKey(cod))
    {
        alunos.Remove(cod);
        Console.WriteLine($"\nAluno removido com sucesso.\n");
    }
    else
    {
        Console.WriteLine("\nCodigo não encontrado");
    }
}

static void IncluirNovoAluno(Dictionary<int, Aluno> alunos)
{
    Console.WriteLine("\n### Incluindo um novo aluno ###\n");
    Console.WriteLine("\nInforme o nome do aluno: ");
    string novoNome = Console.ReadLine();

    Console.WriteLine("Informe a nota do aluno: ");
    int novaNota = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o código do aluno: ");
    int novoCodigo = Convert.ToInt32(Console.ReadLine());

    if (!alunos.ContainsKey(novoCodigo))
    {
        alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
        Console.WriteLine("\nAluno incluido com sucesso.\n");
    }
    else
    {
        Console.WriteLine("\nO código já existe");
    }
}

static void OrdenarAlunosPorNome(Dictionary<int, Aluno> alunos)
{
    Console.WriteLine("\n## Alunos ordenados por nome ##\n");
    var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

    Console.WriteLine("=======================================");
    Console.WriteLine("\tCHAVE  \tNOME  \tNOTA");
    Console.WriteLine("=======================================");
    foreach (var item in alunosOrdenados)
    {
        Console.WriteLine($"\t{item.Key}  \t{item.Value.Nome}  \t{item.Value.Nota}");
    }
    Console.WriteLine("=======================================");
}

public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string? Nome { get; set; }
    public int Nota { get; set; }
}


