//Ejercicio 1 clase 9

Console.WriteLine("Ingrese la longitud del vecton: ");
int longitudVector = int.Parse(Console.ReadLine());

int[] numeros = new int[longitudVector];

Random numeroAleatorio = new Random();

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = numeroAleatorio.Next(100);
}

Console.WriteLine("");
Console.WriteLine("Mostrando lista.");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}


Console.WriteLine("");
Console.WriteLine("Mostrando lista invertida.");
for(int i = numeros.Length - 1 ; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}