
try
{
    string name;
    int edad;

    Console.WriteLine("\nCómo te llamas?: ");
    name = Console.ReadLine();
    Console.WriteLine("\nBienvenido " + name + ". \nQue edad tienes?: ");
    edad = Convert.ToInt32(Console.ReadLine());

    if (edad > 0 && edad < 18)
        Console.WriteLine("\n" + name + " eres MENOR de edad");
    else if (edad >= 18 && edad < 35)
        Console.WriteLine("\n" + name + " eres un ADULTO JOVEN");
    else if (edad >= 35 && edad < 65)
        Console.WriteLine("\n" + name + " eres un ADULTO");
    else if (edad >= 65 && edad < 130)
        Console.WriteLine("\n" + name + " eres un ADULTO MAYOR");
    else
        Console.WriteLine("\n" + name + ", me deja sin palabras que tengas tanta edad!");
}
catch
{
    Console.WriteLine("\nDebes escribir datos válidos");
}
