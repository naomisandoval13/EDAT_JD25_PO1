using FuncionesLambda;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Expresion lambda como funcion");
        //Func<int, int> b = (a) => a * 2;

        //int resultado = b(4);
        //Console.WriteLine("El resultado es: " + resultado);

        //Func <int,int,int> suma = (a, b) => a + b;
        //int resultado = suma (4, 6);
        //Console.WriteLine("El resultado es : " + resultado);

        //Func<int, int, int> mayor = (a, b) =>
        //{
        //    if (a > b)
        //    {
        //        return a;

        //    }
        //    else
        //    {
        //        return b;
        //    }
        //};
        //int resultado = mayor (45,20);

        //Console.WriteLine("El mayor es : " + resultado);


        var numeros = new List<int> {8,5,9,4,7,13,8 };

        Func<int, bool> ObtenerPares = (num) => num % 2 == 0;
        var pares = numeros.Where(ObtenerPares);
        Console.WriteLine("Hola");











        //Persona pers = new Persona();
        //int edad = 18;
        //edad++;
        //edad++;
        //Console.WriteLine(" El valor de la variable edad es : " + edad);
        ////Console.WriteLine("La direccion de memoria es: " +);




        Console.ReadKey();
    }
}