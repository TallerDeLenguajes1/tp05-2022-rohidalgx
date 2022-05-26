using System;

float primerNumero, segundoNumero;

Console.WriteLine("Ingrese un número");
primerNumero = (float)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor Absoluto: " + Math.Abs(primerNumero));
Console.WriteLine("Valor Cuadrado: " + Math.Pow(primerNumero, 2));
Console.WriteLine("Raíz Cuadrada: " + Math.Pow(primerNumero, 0.5f));
Console.WriteLine("Seno: " + Math.Sin(primerNumero));
Console.WriteLine("Coseno: " + Math.Cos(primerNumero));
Console.WriteLine("Parte Entera " + Math.Floor(primerNumero));

Console.WriteLine("Ingrese otro número");
primerNumero = (float)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
segundoNumero = (float)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El máximo entre los dos es: " + Math.Max(primerNumero, segundoNumero));
Console.WriteLine("El mínimo entre los dos es: " + Math.Min(primerNumero, segundoNumero));
