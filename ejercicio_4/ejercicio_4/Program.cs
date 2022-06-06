using System;




string? cadena;
string? cadena2;
int opcion = 0;
int volver;
int num1 = 0;
int num2 = 0;
float suma = 0;
float resta = 0;
float multi = 0;
float div = 0;

Console.WriteLine("Ingrese una cadena \n");
cadena = Console.ReadLine();

//Console.WriteLine("obtener algunas letras que forman parte de una cadena\n");
//Console.WriteLine(+cadena[0] + " " + cadena[1] + " " + cadena[2]);

//Console.WriteLine("Obtener la longitud de la cadena y muestre por pantalla\n");
//Console.WriteLine(+cadena.Length);

//Console.WriteLine("Concatenar (Unir) dos cadenas distintas\n");
//Console.WriteLine("ingrese otra cadena\n");
//cadena2 = Console.ReadLine();
//Console.WriteLine(String.Concat(cadena, cadena2));

//Console.WriteLine("Extraer una subcadena\n");
//Console.WriteLine(cadena2.Substring(2));

//Console.WriteLine("Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado\n");



//do
//{
//    Console.WriteLine("ingrese un num para empezar a operar: \n");
//    Console.WriteLine("1: suma, 2: resta, 3:multiplicacion, 4:division\n");
//    opcion = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("ingrese el primer numero\n");
//    num1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("ingrese el segundo numero\n");
//    num2 = Convert.ToInt32(Console.ReadLine());



//    switch (opcion)
//    {
//        case 1:
//            suma = num1 + num2;
//            Console.WriteLine("el resultado de la suma es:  \n" + Convert.ToString(suma));
//            break;
//        case 2:
//            resta = num1 - num2;
//            Console.WriteLine("el resultado de la resta es: \n" + Convert.ToString(resta));
//            break;
//        case 3:
//            multi = num1 * num2;
//            Console.WriteLine("el resultado de la multiplicaciones es: \n" + Convert.ToString(multi));
//            break;
//        case 4:
//            div = num1 / num2;
//            Console.WriteLine("el resultado de la division es: \n" + Convert.ToString(div));
//            break;
//    }



//    Console.WriteLine("si desea volver a operar presione cero 0\n");
//    volver = Convert.ToInt32(Console.ReadLine());

//} while (volver == 0);

Console.WriteLine("Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla");

foreach (char letra in cadena)
{
    Console.WriteLine(letra + "-");
}

Console.WriteLine("Buscar la ocurrencia de una palabra determinada en la cadena ingresada");

int contador = 0;
foreach (char letra in cadena)
{
    if (letra == 'a')
    {
        contador++;
    }
}

Console.WriteLine("La cantidad de veces que aparece la letra a es:" + contador);

Console.WriteLine("Convierta la cadena a Mayúsculas y luego minúsculas");

Console.WriteLine("Convierto la cadena a minúsculas:");
Console.WriteLine(cadena.ToLower());

Console.WriteLine("Convierto la cadena a mayúsculas:");
Console.WriteLine(cadena.ToUpper());


Console.WriteLine("Ingrese una nueva cadena y luego compare los valores de ambas.");

string? nuevaCadena = Console.ReadLine();

Console.WriteLine($"Comparando...: {nuevaCadena == cadena}");

Console.WriteLine("Ingrese una cadena separada por (,) caracteres que usted determine y muestre por pantalla los resultados");

string? pruebaSplit = Console.ReadLine();

string?[] arregloSplit = pruebaSplit.Split(", ");

Console.WriteLine("El resultado obtenido es: ");

foreach (string? subCadena in arregloSplit)
{
    Console.WriteLine(subCadena);
}

//no hice el ultimo apartado
