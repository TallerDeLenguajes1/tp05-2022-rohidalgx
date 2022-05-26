using System;




string? cadena;
string? cadena2;

Console.WriteLine("Ingrese una cadena \n");
cadena = Console.ReadLine();

Console.WriteLine("obtener algunas letras que forman parte de una cadena\n");
Console.WriteLine(+cadena[0] + " " + cadena[1] + " " + cadena[2]);

Console.WriteLine("Obtener la longitud de la cadena y muestre por pantalla\n");
Console.WriteLine(+cadena.Length);

Console.WriteLine("Concatenar (Unir) dos cadenas distintas\n");
Console.WriteLine("ingrese otra cadena\n");
cadena2 = Console.ReadLine();
Console.WriteLine(String.Concat(cadena, cadena2));

Console.WriteLine("Extraer una subcadena\n");
Console.WriteLine(cadena2.Substring(2));

Console.WriteLine("Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado\n");






