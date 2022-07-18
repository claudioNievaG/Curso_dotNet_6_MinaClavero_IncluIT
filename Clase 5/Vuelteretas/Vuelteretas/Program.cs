// See https://aka.ms/new-console-template for more information

string nombreIngresado;
string doContinue = "S";

while (doContinue == "S")
{
    Console.Clear();
    Console.WriteLine("Cual es tu nombre?");
    nombreIngresado = Console.ReadLine();

    Console.WriteLine($"Hola {nombreIngresado}!");

    Console.WriteLine("Quieres continuar? (S/N)");
    doContinue = Console.ReadLine().ToUpper();
}

if (doContinue == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}