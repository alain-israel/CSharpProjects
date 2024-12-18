
float a = 3, b = 5, c = 7, d = 9, e = 11, f = 13, operacion;

Console.WriteLine("Este es el valor de los numeros:\n");
Console.WriteLine("a = 3\nb = 5\nc = 7\nd = 9\ne = 11\nf = 13");
Console.WriteLine("\ngLa formula para sumar los numeros sera asi:\n(a + b + c) * (d + e) / f");
    
operacion = (a + b + c) * (d + e) / f;
Console.WriteLine("El resultado es {0}", operacion.ToString("#.##"));

