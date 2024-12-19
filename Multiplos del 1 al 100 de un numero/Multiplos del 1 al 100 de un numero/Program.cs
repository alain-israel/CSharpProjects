
Console.WriteLine("Ingresa un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nTu numero es " + numero + ".\n\nAhora veras los primeros 10 multiplos de " + numero + ".\n");

int contador = 1;
while (contador <= 10)
{
    int resultado = numero * contador;
    Console.WriteLine(resultado);
    contador++;
}


