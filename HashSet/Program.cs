
Console.WriteLine("## HashSet ##\n");
//SortedSet<T> - mesmo métodos do HashSet, porem ordenados



//criação de coleção hashset com itens
//var numeros = new HashSet<int> { 1, 2, 3 };

//var frutas = new HashSet<string> { "uva", "banana", "pera" };

//HashSet<int> pares = new HashSet<int>();

//for (int i = 0; i < 6; i++)
//{
//    pares.Add(i * 2);
//}

////construtor usando IEnumerable
//var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
//var conjunto = new HashSet<int>(lista1);

//métodos
//Add(T) - Contains(T) - Remove(T) - ExceptWith(IEnurable<T> - etc... 


var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo"};

var timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense"};

var timesMundiais = new HashSet<string> { "Santos", "Palmeiras", "São Paulo", "Flamengo"};

if (!timesSP.Contains("Corinthians"))
    timesSP.Add("Corinthians");

if(timesSP.IsSubsetOf(timesMundiais))
{
    Console.WriteLine("timesSP é um subconjunto de timesMundiais\n");
}

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("timesMundiais é um superconjunto de timesSP\n");
}

if(timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem um time mundial");
}

//juntando os hashset
timesSP.UnionWith(timesRJ);

ExibirColecao(timesSP);

//juntando os times ordenados
var todosOsTimes = new SortedSet<string>(timesSP);
ExibirColecao(timesSP);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{

    foreach (var item in colecao)
    {
        Console.WriteLine($"{item} ");
    }
}