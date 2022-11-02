using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class fibonacci
    {
        public void sequenciaFibonacci()
        {

            Console.Clear();
            int casas;
            int option = 1;

            Console.WriteLine("Digite quantas casas deseja ver da sequência de fibonacci");
            casas = int.Parse(Console.ReadLine());


            do
            {

                if (casas <= 0)
                {

                    Console.Clear();
                    Console.WriteLine("Número de casas menor ou igual a 0, não há nada a mostrar da sequência de fibonacci.");
                    Console.WriteLine("1 - Digite outro número de casas");
                    Console.WriteLine("2 - Retornar ao menu principal");
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Digite quantas casas deseja ver da sequência de fibonacci");
                                casas = int.Parse(Console.ReadLine());
                                
                            }
                            break;


                        case 2:
                            {
                                Console.WriteLine("Retornando ao menu principal...");
                                option = 0;

                            }
                            break;



                        default:
                            {
                                option = 0;
                                Console.WriteLine("Opção Inválida. Retornaremos ao menu principal");
                                

                            }
                            break;

                    }
                }
                else {

                    if (casas == 1) {
                        Console.WriteLine("SEQUÊNCIA DE FIBONACCI COM 1 CASA: ");
                        Console.Write("1");
                        option = 0;
                        
                    }

                    if (casas == 2) {
                        Console.WriteLine("SEQUÊNCIA DE FIBONACCI COM 2 CASAS: ");
                        Console.Write("1,", "\t");
                        Console.Write("1");
                        option = 0;
                       
                    }

                    if (casas >= 3) {
                        int casaAtual, casaAnterior, aux;

                        casaAtual = 3;
                        casaAnterior = 2;
                        aux = 1;

                        Console.WriteLine("SEQUÊNCIA DE FIBONACCI COM {0} CASAS: ", casas);
                        Console.Write(1 + "\t");
                        Console.Write(1 + "\t");
                        Console.Write(2 + "\t");
                        for (int i = 4; i <= casas; i++) {
                            
                            Console.Write(casaAtual + "\t");
                            aux = casaAtual;
                            casaAtual = casaAtual + casaAnterior;
                            casaAnterior = aux;
                            

                        }

                        option = 0;

                    }


                }

            } while (option == 1);
            Console.ReadKey();

        }
    }
}
