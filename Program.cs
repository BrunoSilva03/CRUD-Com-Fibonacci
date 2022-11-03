using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            //Autor: Bruno Silva Rodrigues - 2022
            int option;
            ArrayList lista = new ArrayList();
            Console.WriteLine("Olá, Seja BEM-VINDO(A)");

            create c = new create();
            read r = new read();
            update u = new update();
            delete d = new delete();
            verify v = new verify();
            clean clear = new clean();
            fibonacci f = new fibonacci();
            swap s = new swap();

            do
            {

                Console.Clear();
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Exibir");
                Console.WriteLine("2 - Inserir");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Limpar");
                Console.WriteLine("6 - Verificar se a lista está vazia");
                Console.WriteLine("7 - Fibonacci");
                Console.WriteLine("8 - Verificar quantos elementos existem na lista");
                Console.WriteLine("9 - Trocar elementos de lugar na lista");
                Console.WriteLine("0 - Sair do Programa");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {


                    case 0:
                        {
                            Console.WriteLine("Saindo do programa, obrigado por usar...");
                            Environment.Exit(0);

                        }
                        break;


                    case 1:
                        {
                            r.exibirLista(lista);

                        }
                        break;


                    case 2:
                        {
                            c.inserir(lista);

                        }
                        break;


                    case 3:
                        {

                            d.excluir(lista);
                        }
                        break;


                    case 4:
                        {
                            u.alterar(lista);

                        }
                        break;


                    case 5:
                        {
                            clear.limpar(lista);

                        }
                        break;


                    case 6:
                        {
                            Console.Clear();
                            if (v.vazia(lista))
                            {

                                Console.WriteLine("SIM, a lista encontra-se vazia atualmente.");
                                
                            }
                            else
                            {

                                Console.WriteLine("Não, a lista NÃO encontra-se vazia neste momento.");
                               
                            }

                            Console.ReadKey();

                        }
                        break;

                    case 7:
                        {

                            f.sequenciaFibonacci();
                        }
                        break;


                    case 8:
                        {
                            Console.Clear();
                            if (v.vazia(lista))
                            {
                                Console.WriteLine("A lista atualmente tem 0 elementos");
                            }
                            else {
                                Console.WriteLine("A lista atualmente tem {0} elementos", lista.Count);
                            }

                            Console.ReadKey();
         
                        }
                        break;


                    case 9:
                        {
                            s.swapElements(lista);

                        }
                        break;


                    default:
                        {
                            Console.WriteLine("Opção Inválida, Tente novamente.");
                            Console.ReadKey();
                            
                        }
                        break;


                }


            } while (option != 0);





            Console.ReadKey();
        }
    }
}
