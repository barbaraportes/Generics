
Console.WriteLine("## Queue - Exercicio ##\n");

//criando a fila
Queue<Pedido> filaPedidos = new Queue<Pedido>();

//adicionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

//exibe o numero de pedidos na fila
Console.WriteLine($"Número de pedidos na fila: {filaPedidos.Count}");

//processar os pedidos da fila
while (filaPedidos.Count > 0)
{
    //retirar o proximo pedido da fila
    Pedido proximoPedido = filaPedidos.Dequeue();

    Console.WriteLine($"Processo o pedido nº {proximoPedido.Numero}, " +
                      $"Valor {proximoPedido.Valor:c}");
}

//adicionar mais alguns pedidos na fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

//localizar pedidos na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

if(pedidoLocalizado != null)
{
    Console.WriteLine($"Pedido nº {numeroPedido} localizado na fila, " +
                      $"Valor {pedidoLocalizado.Valor:c}");
}
else
{
    Console.WriteLine($"Pedido nº {numeroPedido} não localizado na fila");
}


Console.ReadKey();


class Pedido
{
    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }

    public int Numero { get; set; }
    public double Valor { get; set; }
}


