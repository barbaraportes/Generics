
Console.WriteLine("## Stack<T> ##\n");

//atua ao estilo LIFO - last in first out

//propriedade: Count
//métodos: push() - pop() - peek() - Contains() - etc

//construtores: stack<T>() - stack<T>(IEnumerable<T> - Stack<T>(int capacity)

Stack<string> diasDaSemana = new Stack<string>();
diasDaSemana.Push("Segunda");
diasDaSemana.Push("Terça");
diasDaSemana.Push("Quarta");


int[] array1 = new int[] { 1,2,3,4};
Stack<int> pilha1 = new Stack<int>(array1);

