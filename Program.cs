internal class Program
{

    /*
    1. Hacer un programa que le pida al usuario
    un número y la computadora responda si
    es par o impar.
    
    
    5.Hacer una programa que pueda calcular
    el perímetro y el área de cualquier
    polígono regular, pero que le pregunte al
    usuario qué desea calcular.
    
    
    */
    
    private static void Main(string[] args)
    {

        //1

        double num;

        System.Console.Write("Ingrese el valor: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){
            System.Console.WriteLine("Este numero es par");
        }
        else
        {
            System.Console.WriteLine("El numero es impar");

        }


        //5

        System.Console.WriteLine("1. Calcular perimetro\n2. Calcular area");
        System.Console.Write("Ingrese su opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if(opcion == 1){
            float num_lados, medida_lado, perimetro;

            System.Console.Write("Ingrese el numero de lados: ");
            num_lados = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Ingrese la medida de los lados: ");
            medida_lado = Convert.ToInt32(Console.ReadLine());

            perimetro = num_lados * medida_lado;

            System.Console.WriteLine($"El perimetro es: {perimetro}");
        }

        if(opcion == 2)
        {
            float area, apotema, perimetro;

            System.Console.Write("Ingrese el perimetro: ");
            perimetro = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Ingrese la apotema: ");
            apotema = Convert.ToInt32(Console.ReadLine());

            area = perimetro * apotema;

            area = area / 2;

            System.Console.WriteLine($"El area es: {area}");


        }


    }
}