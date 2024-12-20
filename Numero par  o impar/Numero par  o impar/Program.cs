
int numero;

try
{
    Console.Write("Escribe un numero: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if ((numero % 2) == 0)
        Console.Write("Escribiste un numero par");
    else
        Console.Write("Escribiste un numero impar");

}
catch
{
    Console.Write("\nDebes escribir un número.");
}
