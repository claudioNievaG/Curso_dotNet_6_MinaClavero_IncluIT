int[] numeros = new int[10];
int sum = 0;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"deme el numero {i + 1} de {numeros.Length} para almacenar");
    int numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;
}

foreach (int numero in numeros)
{
    sum += numero;
}


Console.WriteLine($"La suma total es {sum}");
Console.WriteLine($"el numero mayor es {numeros.Max()}");
Console.WriteLine($"el numero menor es {numeros.Min()}");
Console.WriteLine($"el promedio es {sum / numeros.Length}");
Console.WriteLine("Los numeros agregados son: ");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
