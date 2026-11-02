
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Caso_tema7_semana11

{

    internal class Program

    {

        static public void numero_naturales()

        {

            Console.Write("Ingresar numero de N: ");

            int N = int.Parse(Console.ReadLine());

            int S = 0;

            for (int c = 0; c <= N; c++)

            {

                S = S + c;

            }

            Console.WriteLine("La suma es: " + S);

        }

        static public int sumaNN_con_recursividad(int N)

        {

            if (N == 1)

            {

                return 1;

            }

            return N + sumaNN_con_recursividad(N - 1);

        }

        static public int sumaNP_con_recursividad(int N)

        {

            if (N == 2)

            {

                return 2;

            }

            return N + sumaNP_con_recursividad(N - 2);

        }
        
        static public long factorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N * factorial(N - 1);
        }
        static public int Potencia(int B, int P)

        {

            if (P == 0)

            {

                return 1;

            }

            return B * Potencia(B, P - 1);

        }

        static public void conteo_regresivo(int N)

        {

            if (N < 0)

            {

                return;

            }

            Console.WriteLine(N);

            conteo_regresivo(N - 1);

        }
        static public int suma_arreglos(int[] num, int indice)
        {
            if (indice >= num.Length)
            {
                return 0;
            }
            return num[indice] + suma_arreglos(num, indice + 1);
        }
        static void Main(string[] args)

        {

            int opc;

            bool valor = true;

            while (valor)

            {

                Console.Clear();

                Console.WriteLine("****************************");

                Console.WriteLine("\t\t MENU DE OPCIONES");

                Console.WriteLine("******************************");

                Console.WriteLine("[1]Suma de N numero naturales");

                Console.WriteLine("[2]Suma de N numero naturales con recursividad");

                Console.WriteLine("[3]Suma de N numeros pares con recursividad");

                Console.WriteLine("[4] Factorial");

                Console.WriteLine("[5] Potencia");

                Console.WriteLine("[6] Conteo regresivo");

                Console.WriteLine("[7] Arreglos");

                Console.WriteLine("[8] Salir");

                Console.WriteLine("****************************");

                opc = int.Parse(Console.ReadLine());

                switch (opc)

                {

                    case 1:

                        numero_naturales();

                        break;

                    case 2:

                        Console.Write("Ingresar numero de N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));

                        break;

                    case 3:

                        Console.Write("Ingresar numero N: ");

                        int N1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La suma de pares es: " + sumaNP_con_recursividad(N1*2));

                        break;

                    case 4:

                        Console.Write("Igresar num: ");

                        int N2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El factorial es " + factorial(N2));

                        break;

                    case 5:

                        Console.WriteLine("Ingresar base: ");

                        int B = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresar exponente: ");

                        int P = int.Parse(Console.ReadLine());

                        Console.WriteLine(B + "^" + P + "=" + Potencia(B, P));

                        break;

                    case 6:

                        int N3;

                        N3 = int.Parse(Console.ReadLine());

                        conteo_regresivo(N3);

                        break;

                    case 7:
                        int[] num = {10,15,20,25,30};
                        Console.WriteLine("La suma del arreglo es: " + suma_arreglos(num, 0));
                        break;

                    case 8:

                        valor = false;

                        break;

                    default:

                        Console.Write("opcion invalida");
                            break;


        }
                Console.ReadKey();
            }

        }

    }

}

