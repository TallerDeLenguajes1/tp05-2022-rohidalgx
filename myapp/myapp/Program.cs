Console.WriteLine("ejercicio 1");
int numeroAInvertir = 0;
int numeroInvertido = 0;

do
{
    Console.WriteLine("Ingrese el numero a invertir\n");
    numeroAInvertir = Convert.ToInt32(Console.ReadLine());
} while(numeroAInvertir < 0);


while (numeroAInvertir > 0)
{
    numeroInvertido = numeroInvertido * 10 + (numeroAInvertir % 10);
    numeroAInvertir /= 10;
}
Console.WriteLine("El número invertido es: " + numeroInvertido);