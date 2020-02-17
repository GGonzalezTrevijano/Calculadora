using System;

namespace Proyecto_Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("La calculadora loca de Willy");
            int dat = 1;

            while (dat != 0)
            {
                Menu();
                
                string dato = Console.ReadLine();
                int valor = int.Parse(dato);

                switch (valor)
                {
                    case 1:

                        Suma();

                        break;

                    case 2:

                        Resta();

                        break;

                    case 3:

                        Multiplicacion();

                        break;

                    case 4:

                        Division();

                        break;

                    case 5:

                        Potencia();

                        break;

                    case 6:

                        Seno();

                        break;

                    case 7:

                        Coseno();

                        break;

                    case 8:

                        Tangente();

                        break;

                    case 9:

                        Primo();
                           
                        break;

                    case 10:

                        dat = 0;

                        break;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("1)Suma de dos numeros");
            Console.WriteLine("2)Resta de dos numeros");
            Console.WriteLine("3)Multiplicacion de dos numeros");
            Console.WriteLine("4)Division de dos numeros");
            Console.WriteLine("5)Potencia de un numero");
            Console.WriteLine("6)Seno de un numero ");
            Console.WriteLine("7)Coseno de un numero");
            Console.WriteLine("8)Tengente de un numero");
            Console.WriteLine("9)Numero Primo");
            Console.WriteLine("10)Salir");
        }
        public static void Suma()
        {
            Console.WriteLine("Inserta los 2 numeros a sumar");

            Suma numeros = new Suma();

            numeros.num1 = int.Parse(Console.ReadLine());
            numeros.num2 = int.Parse(Console.ReadLine());

            double resultadosuma = numeros.CalcularValor();

            Console.WriteLine("La suma de los numeros es: {0}", resultadosuma);
        }
        public static void Resta()
        {
            Console.WriteLine("Inserta los 2 numeros a restar");

            Resta numeros = new Resta();

            numeros.Num3 = int.Parse(Console.ReadLine());
            numeros.Num4 = int.Parse(Console.ReadLine());

            numeros.Resultado = 0;

            Console.WriteLine("La resta de los numeros es: {0}", numeros.Resultado);
        }
        public static void Multiplicacion()
        {
                Console.WriteLine("Inserta los 2 numeros a multiplicar");

                Multiplicacion numeros = new Multiplicacion();

                numeros.Num5 = int.Parse(Console.ReadLine());
                numeros.Num6 = int.Parse(Console.ReadLine());

                double resultado = numeros.Resultado();

                Console.WriteLine("La multiplicacion de los 2 numeros es: {0}", resultado);
        }
        public static void Division()
        {
            Console.WriteLine("Interta los 2 numeros a dividir");

            Division numeros = new Division();

            numeros.Num7 = int.Parse(Console.ReadLine());
            numeros.Num8 = int.Parse(Console.ReadLine());

            numeros.Dividir = 0;

            Console.WriteLine("La division de los 2 numeros es: {0}", numeros.Dividir);
        }
        public static void Potencia()
        {
            Console.WriteLine("Interta los 2 numeros para calcular su potencia");

            Potencia numeros = new Potencia();

            Console.WriteLine("Interta el numero");
            numeros.Num9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Interta el numero para elevarlo");
            numeros.Num10 = int.Parse(Console.ReadLine());

            numeros.Operacion = 0;

            Console.WriteLine("El resultado de elevar {0}, {1} veces es: {2}", numeros.Num9, numeros.Num10, numeros.Operacion);
        }
        public static void Seno()
        {
            Console.WriteLine("Interta el numero para calcular su seno");

            Seno numeros = new Seno();

            numeros.Num11 = int.Parse(Console.ReadLine());

            numeros.Sen = 0;

            Console.WriteLine("El Seno de {0} es: {1}", numeros.Num11, numeros.Sen);
        }
        public static void Coseno()
        {
            Console.WriteLine("Inserta el numero para calcular el coseno");

            Coseno numeros = new Coseno();

            numeros.Num12 = int.Parse(Console.ReadLine());

            numeros.Cosen = 0;

            Console.WriteLine("El coseno de {} es: {1}", numeros.Num12, numeros.Cosen);
        }
        public static void Tangente()
        {
            Console.WriteLine("Inserta el numero para calcular la tangente");

            Tangente numeros = new Tangente();

            numeros.Num13 = int.Parse(Console.ReadLine());

            numeros.Tang = 0;

            Console.WriteLine("La tangente de {0} es: {1}", numeros.Num13, numeros.Tang);
        }
        public static void Primo()
        {
            Console.WriteLine("Inserta el numero para calcular si es primo");

            Primo numeros = new Primo();

            numeros.Num14 = int.Parse(Console.ReadLine());

            numeros.Prim = "texto";

            Console.WriteLine(numeros.Prim);
        }
    }
}
