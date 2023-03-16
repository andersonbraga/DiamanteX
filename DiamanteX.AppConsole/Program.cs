using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace DiamanteX.AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int restoI;
            int restoJ;


            for (int i = 0; i < numero; i++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Numero par, digite um numero impar");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else if (numero % 2 == 1)
                {
                    for (int j = 0; j < numero; j++)
                    {
                        restoI = numero / 2 - i;
                        restoJ = numero /2 - j;

                        if (Math.Abs(restoI) + Math.Abs(restoJ) <=  Math.Sqrt(numero * 2) )
                        {

                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();

                }

            }
            /////////////////////////////////////////////////////////////////////////////////////////
            DiamanteFor();
            /////////////////////////////////////////////////////////////////////////////////////////
                static void DiamanteFor()
                {
                    Console.WriteLine("Insira um numero impar: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                    Console.WriteLine("Numero par, digite um numero impar");
                    numero = Convert.ToInt32(Console.ReadLine());
                    }
                    else if( numero % 2 == 1) 

                    {
                        for (int i = 0; i < numero; i += 2)

                        {
                            for (int j = numero; j > i; j -= 2)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 0; j <= i; j += 1)
                            {
                                Console.Write("x");

                            }

                            Console.WriteLine();
                        }

                        for (int i = numero - 2; i >= 0; i -= 2)

                        {
                            for (int j = numero + 2; j > i; j -= 2)
                            {
                                Console.Write(" ");
                            }

                            for (int j = i; j > 0; j -= 1)
                            {
                                Console.Write("x");

                            }

                            Console.WriteLine();
                        }
                    }
                }

            
            
        }
    }
}