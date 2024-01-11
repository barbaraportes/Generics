
Console.WriteLine("## Queue<T> ##\n");

//fila
//atua com FIFO first in first out
//queue<T>() - queue<T>(IEnumerable<T>) - queue<T>(int32)

//propriedade count
//metodo: enqueue(T) - inclui item no final da fila
//dequeue - retorna um item do inicio da fila e o remove da fila
//peek() - retorna o item do inicio da fila sem remove-lo
//Contains() - verifica se um item existe na fila
//clear() - remove todos os elementos

Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");
diasSemana.Enqueue("Quarta");


string[] cursos = { "C#", "Phyton", "Java", "SQL"};
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("Nº de elementos na fila 1: " + fila1.Count());

ExibirFila(fila1);

//inclui novo curso na fila
fila1.Enqueue(".NET");

//remove item do inicio da fila
fila1.Dequeue();

ExibirFila(fila1);








Console.ReadKey();


static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    }
}