/*Console.WriteLine("ejercicio 1");
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
Console.WriteLine("El número invertido es: " + numeroInvertido);*/

Console.WriteLine("ejercicio 2");
int opcion = 0;
int volver;
int num1 = 0;
int num2 = 0;
float suma = 0;
float resta = 0;
float multi = 0;
float div = 0;


do
{
    Console.WriteLine("ingrese un num para empezar a operar: \n");
    Console.WriteLine("1: suma, 2: resta, 3:multiplicacion, 4:division\n");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ingrese el primer numero\n");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero\n");
    num2 = Convert.ToInt32(Console.ReadLine());



    switch (opcion)
    {
        case 1:
            suma = num1 + num2;
            Console.WriteLine("el resultado es \n" +suma);
            break;
        case 2: 
            resta = num1 - num2;
            Console.WriteLine("el resultado es \n" + resta);
            break;
        case 3: 
            multi = num1 * num2;
            Console.WriteLine("el resultado es \n" + multi);
            break;
        case 4:
            div = num1 / num2;
            Console.WriteLine("el resultado es \n" + div);
            break;
    }



    Console.WriteLine("si desea volver a operar presione cero 0\n");
    volver = Convert.ToInt32(Console.ReadLine());

} while (volver == 0);
