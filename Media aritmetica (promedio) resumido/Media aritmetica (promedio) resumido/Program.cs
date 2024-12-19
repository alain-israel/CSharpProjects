
List<int> arrayNumeros = new List<int>();
decimal suma = 0;

Console.Write("\nEscribe el numero de digitos de la longitud de numeros a calcular: ");
int numeroVueltas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numeroVueltas; i++)
{
    Console.Write("\nEscribe un numero al azar: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    arrayNumeros.Add(numero);    
}
foreach (int n in arrayNumeros)
    suma += n;
decimal resultado = suma / numeroVueltas;
Console.WriteLine("\nEl promedio de los numeros es: " + resultado + ".");