

int filas = int.Parse(Console.ReadLine());
int columnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];

double[] promedios = new double[5];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;


for(int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N: {columna + 1}");
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.WriteLine($"Cargue la nota N: {fila + 1}");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}


for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("==============================================");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine($"Notas del alumno N: {columna + 1}");

    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Nota numero N {fila + 1} ");
        Console.WriteLine($" es: {numeros[fila, columna]} ");
        //notas[fila, columna] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();




//Console.WriteLine("Ingrese las notas de los examenes");

//Console.WriteLine("Ingrese la cantidad de alumnos");
//int cantidadAlumnos = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese la cantidad de Notas por alumno");
//int cantidadDeNotas = int.Parse(Console.ReadLine());

//int[,] notas = new int[cantidadDeNotas, cantidadAlumnos];

////Filas
//int lengthFilas = notas.GetUpperBound(0) + 1;
////Columnas
//int lengthColumnas = notas.GetUpperBound(1) + 1;

//for (int columna = 0; columna < lengthColumnas; columna++)
//{
//    Console.WriteLine();
//    Console.WriteLine($"Notas del alumno N: {columna + 1}");

//    for (int fila = 0; fila < lengthFilas; fila++)
//    {
//        Console.WriteLine($"Cargue la nota N: {fila + 1}");
//        notas[fila, columna] = int.Parse(Console.ReadLine());
//    }
//}



//for (int columna = 0; columna < lengthColumnas; columna++)
//{
//    Console.WriteLine();
//    Console.WriteLine("==============================================");
//    Console.WriteLine();

//    Console.WriteLine();
//    Console.WriteLine($"Notas del alumno N: {columna + 1}");

//    for (int fila = 0; fila < lengthFilas; fila++)
//    {
//        Console.Write($"Nota numero N {fila + 1} ");
//        Console.WriteLine($" es: {notas[fila, columna]} ");
//        //notas[fila, columna] = int.Parse(Console.ReadLine());
//    }
//}
//Console.WriteLine();
