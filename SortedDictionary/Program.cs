
Console.WriteLine("## Sorted Dictionary ##\n");
//mesmas propriedades e métodos do dictionary


var brics = new SortedDictionary<int, string>()
{
    {20, "Brasil" },
    {10, "China" },
    {40, "India" },
    {30, "URSS" },
};

Console.WriteLine("\n- Incluindo o elemento de chave [70] e valor [Africa do sul]");

if (brics.ContainsKey(70))
{
    Console.WriteLine("A chave ja existe");
}
else
{
    brics.Add(70, "Africa do Sul");
}


Console.WriteLine($"\n- Número de elementos no dicionário: {brics.Count}");


Console.WriteLine("\n- Acessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

brics[2] = "Argentina";




Console.ReadKey();




