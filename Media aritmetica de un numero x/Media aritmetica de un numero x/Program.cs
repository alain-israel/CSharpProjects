
List<int> arrayNumeros = new List<int>();

Console.WriteLine("Haremos un ejercicio para obtener la media de una de lista de numeros");
Console.Write("\nEscribe el numero de digitos de la longitud de numeros a calcular: ");
int numeroVueltas = Convert.ToInt32(Console.ReadLine());

for (int i = 0;  i < numeroVueltas; i++)
{
    Console.Write("\nEscribe un numero al azar: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    arrayNumeros.Add(numero);
}

Console.WriteLine("\nLos números sobre los que calcularemos la media aritmetica son: ");
for (int i = 0; i < arrayNumeros.Count; i++)
{
    Console.Write(arrayNumeros[i]);
    if (i < arrayNumeros.Count - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("\n\nPara sacar la media de una lista de numeros , sumaremos todos los numeros entre si y dividiremos entre" +
    " el numero de longitud de numeros");
int suma = 0;
for (int i = 0; i < arrayNumeros.Count; i++)
{
    suma += arrayNumeros[i];
}
Console.WriteLine("\nEl resultado que nos dio es " + suma + ". Ahora sacaremos la media");
decimal resultado = (decimal)suma / numeroVueltas;
Console.WriteLine("\nEl promedio de los numeros es: " + resultado + ".");