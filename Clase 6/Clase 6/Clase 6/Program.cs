int secretNumbre;
string selectedNumber;
int count = 0;

do
{
    //Console.Clear();
    secretNumbre = new Random(DateTime.Now.Millisecond).Next(1, 21);
    Console.WriteLine("Adivina el numero entre 1 y 20!");
    selectedNumber = Console.ReadLine().ToString();

    if (secretNumbre < int.Parse(selectedNumber))
    {
        Console.WriteLine("el numero es muy grande! intenta de nuevo");
        count++;
    }else if(secretNumbre > int.Parse(selectedNumber))
    {
        Console.WriteLine("el numero es muy chico! intenta de nuevo");
        count++;
    }
}
while (int.Parse(selectedNumber) != secretNumbre);

Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: { secretNumbre } Lo has logrado en { count } intentos!!");