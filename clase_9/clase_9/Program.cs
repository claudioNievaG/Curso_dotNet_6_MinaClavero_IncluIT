Console.WriteLine("Ingrese el tamaño deseado para el listado");
var dato = Console.ReadLine();
//if (dato == null)
//{
//    dato = "0";
//}
int listLength = int.Parse(dato);

int[] vector = new int[listLength];

Random randomNumber = new Random();


for (int i = 0; i < vector.Length; i++)
{

    vector[i] = randomNumber.Next(100);

}

Console.WriteLine("Los numeros generados son: ");

int contador = 0;
foreach(int item in vector)
{
    contador++;
    Console.WriteLine($"indice[{contador - 1}]: {item}");
}

Console.WriteLine();
Console.WriteLine("Ingresa el indice a modificar: ");
var borrarPosicion = int.Parse(Console.ReadLine());

if (borrarPosicion > vector.Length - 1 || borrarPosicion < 0)
{
    Console.WriteLine($"Error, Indice no valido. Por favor coloque un valor entre 0 y {vector.Length - 1}");
}
else
{
    Console.WriteLine("Ingrese nuevo valor");
    vector[borrarPosicion] = int.Parse(Console.ReadLine());

    contador = 0;
    foreach (int item in vector)
    {
        contador++;
        Console.WriteLine($"indice[{contador - 1}]: {item}");
    }
}

