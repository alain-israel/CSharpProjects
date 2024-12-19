float numero1, numero2, suma, resta, multi, div;
Console.WriteLine("Teclea un numero: ");
numero1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nTeclea otro numero: ");
numero2 = Convert.ToSingle(Console.ReadLine());

div = numero1 / numero2;

Console.WriteLine("\nAqui esta la DIVISION de los numeros que ingresaste: {0}\n", div.ToString("0.0000"));

multi = numero1 * numero2;

Console.WriteLine("\nAqui esta la MULTIPLICACION  de los numeros que ingresaste: {0}\n", multi);

suma = numero1 + numero2;

Console.WriteLine("\nAqui esta la SUMA de los numeros que ingresaste: {0}\n", suma);

resta = numero1 - numero2;

Console.WriteLine("\nAqui esta la RESTA de los numeros que ingresaste: {0}\n", resta);
