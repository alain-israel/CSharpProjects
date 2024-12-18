
Console.WriteLine("**** Acceso Válido ****");
Console.WriteLine("\nCómo te llamas?: ");
string name = Console.ReadLine();
Console.WriteLine("\nBienvenido " + name + ".");
Console.WriteLine("\nQue edad tienes?");
int edad = Convert.ToInt32(Console.ReadLine());


if (edad > 0 && edad < 18)
{
    Console.WriteLine("\n" + name + " eres MENOR de edad");
}
else if (edad >= 18 && edad < 35)
{
    Console.WriteLine("\n" + name + " eres un ADULTO JOVEN");
}
else if (edad >= 35 && edad < 65)
{
    Console.WriteLine("\n" + name + " eres un ADULTO");
}
else if (edad >= 65 && edad < 130)
{
    Console.WriteLine("\n" + name + " eres un ADULTO MAYOR");
}
else
{
    Console.WriteLine("\n" + name + ", debes ingresar tu edad.");
}
