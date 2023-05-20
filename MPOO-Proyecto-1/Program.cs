void NombredelMetodo()
{
    Console.WriteLine("Cual es tu nombre");
    string Nombre = string.Empty;

    Nombre = Console.ReadLine();
    if (Nombre != null)
    {
        Console.WriteLine("Hola -" + Nombre + "\n");
    }

    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(i + 1);
    }
}
    
NombredelMetodo();

