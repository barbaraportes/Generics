Console.WriteLine("## Dictionary ##\n");
//chave possui valor exclusivo
//não precisar estar ordenado

Dictionary<int, int> dic1 = new();
var dic2 = new Dictionary<int, int>();

dic1.Add(1, 2);
dic2.Add(2, 3);

var dic3 = new Dictionary<int, int>()
{
    {1, 100 },
    {2, 200 },
    {3, 300 }
};

Console.WriteLine("\n- Tentando incluir elemento com chave(3) já existente com método Add\n");
try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Tentando incluir elemento com chave(3) já existente com método TryAdd\n");
var resultado = dic3.TryAdd(3, 333);
Console.WriteLine($"O elemento foi incluido?\nResposta: {resultado}");

Console.WriteLine("\n--------------------------------------------------------------------\n");

if (!dic3.ContainsKey(7)) //se a chave 7 não existir no dictionary, incluir chave 7 com valor 7000
{
    Console.WriteLine("\n- Incluindo o elemento com chave 7 e valor 7000\n");
    dic3.Add(7, 7000);
}

Console.WriteLine(dic3[7]);

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Usando ContainsValue\n");

if (dic3.ContainsValue(7000))
{ 
    Console.WriteLine("O valor existe no dictionary");
   
}

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Alterando o valor do elemento com a chave 7\n");
Console.WriteLine($"Valor atual do item {dic3[7]}");

if (dic3.ContainsValue(7000))
{
    dic3[7] = 7777;
    Console.WriteLine($"\nValor alterado do item {dic3[7]}\n");
}

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Tentando obter elemento com chave(5) inexistente\n"); //KeyNotFoundException

try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception ex)    
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Usando TryGetValue() para a chave 5(inexistente)\n");

if (dic3.TryGetValue(5, out int valor))
{
    Console.WriteLine($"Valor para a chave 5 = {valor}");
}
else
{
    Console.WriteLine("Chave não encontrada");
}


Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Usando TryGetValue() para a chave 2(existente)\n");

if (dic2.TryGetValue(2, out int valor2))
{
    Console.WriteLine($"Valor para a chave 2 = {valor2}");
}
else
{
    Console.WriteLine("Chave não encontrada");
}

//adicionando novos elementos

dic3.Add(6, 6666);
dic3.Add(4, 4444);

Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Percorrendo o dicionario e exibindo os itens (foreach)\n");

foreach (var item in dic3)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Ordenando os elementos do dicionario(SortedDictionary) \n");

var dic3Ordenado = new SortedDictionary<int, int>(dic3);
foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


Console.WriteLine("\n--------------------------------------------------------------------\n");

Console.WriteLine("\n- Ordenando os elementos do dicionario(LINQ) \n");

var dic3Ordenado2 = dic3.OrderBy(x => x.Key);
foreach (var item in dic3Ordenado2)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


Console.ReadKey();


