
using System.Collections.ObjectModel;

Console.WriteLine("## ReadOnlyCollection<T> ##\n");

//estruturas de dados que permitem que os dados sejam acessados, mas não modificados
//fornece a classe base para uma coleção somente leitura genética
//criada a partir de uma coleção mutável (Array, list)

//visualização somente leitura da coleção List<T> especificada

//propriedades: Count - Item[] - Items
//métodos: contains - CopyTo(T[] array, int arrayIndex) - GetEnumerator() - IndexOf(T item)

var planetas = new List<string>()
{
    "Mercurio", "Venus", "Terra", "Marte"
};

//modo 1
var listaPlanetas = new ReadOnlyCollection<string>(planetas);

//modo 2
//var novaLista = planetas.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosos do sistema solar:");
foreach (var planeta in listaPlanetas)
{
    Console.WriteLine($"{planeta} ");
}

Console.WriteLine($"\nQuantidade de planetas na coleção: {planetas.Count}");

Console.Write("\nJupiter está na coleção? ");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta índice 3: {listaPlanetas[3]}");



Console.ReadKey();


