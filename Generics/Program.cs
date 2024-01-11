Console.WriteLine("## Generics ##\n");

//ClasseGenerica<int> objInt = new ClasseGenerica<int>();
//objInt.Adicionar(10);
//objInt.Adicionar(20);
//objInt.Adicionar(30);
//objInt.Adicionar(40);
//objInt.Adicionar(50);

//Console.WriteLine("Classe ClasseGenerica<T> de objetos int\n");


ClasseGenerica<string> objStr = new ClasseGenerica<string>();
objStr.Adicionar("10");
objStr.Adicionar("20");
objStr.Adicionar("30");
objStr.Adicionar("40");
objStr.Adicionar("50");

Console.WriteLine("Classe ClasseGenerica<T> de objetos string\n");



for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objStr[i]);
}



Console.ReadKey();

public class ClasseGenerica<T>
{
    T[] obj = new T[5];
    int contador = 0;

    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    public T this[int index]
    {
        get { return obj[index]; }

        set { obj[index] = value; }


    }
}