using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class swap
    {
        verify v = new verify();

        public void swapElements(ArrayList lista)
        {
            read r = new read();
            swap s = new swap();

            if (v.vazia(lista))
            {

                Console.WriteLine("A lista atualmente encontra-se vazia.");
            }
            else
            {
                string element1, element2;
                Console.Clear();
                Console.WriteLine("Essa função troca 2 elementos de lugar dentro da lista");

                Console.WriteLine("Digite um elemento dentro da lista: ");
                element1 = Console.ReadLine();

                if (lista.Contains(element1))
                {
                    int opc2 = 1;
                    Console.WriteLine("Digite outro elemento dentro da lista: ");
                    element2 = Console.ReadLine();

                   
                    do
                    {


                        if (lista.Contains(element2))
                        {
                            opc2 = 0;
                            string aux1 = "elemento 1", aux2 = "elemento 2";
                            int indice1 = 0, indice2 = 0, indice3;
                            for (int i = 0; i < lista.Count; i++)
                            {
                                if (lista[i].Equals(element1))
                                {

                                    aux1 = Convert.ToString(lista[i]);
                                    indice1 = i;
                                   
                                }

                               
                            }

                            for (int j = 0; j < lista.Count; j++) {

                                if (lista[j].Equals(element2))
                                {

                                    aux2 = Convert.ToString(lista[j]);
                                    indice2 = j;
                                   
                                }
                            }
                            

                            lista[indice1] = aux2;
                            lista[indice2] = aux1;

                            Console.WriteLine("Elementos \"{0}\" e \"{1}\" trocados de lugar na lista Com Sucesso!!!", element1, element2);
                            Console.ReadKey();

                        }
                        else
                        {


                            Console.WriteLine("O elemento \"{0}\" não está presente na lista nesse momento. Tente: ", element2);
                            Console.WriteLine("1 - Digitar outro elemento");
                            Console.WriteLine("2 - Retornar ao menu inicial");
                            opc2 = int.Parse(Console.ReadLine());


                            switch (opc2)
                            {

                                case 1:
                                    {

                                        Console.WriteLine("Digite outro elemento dentro da lista: ");
                                        element2 = Console.ReadLine();

                                        opc2 = 1;
                                    }
                                    break;



                                case 2:
                                    {

                                        opc2 = 0;
                                        Console.WriteLine("Retornando ao menu inicial...");


                                    }
                                    break;



                                default:
                                    {
                                        Console.WriteLine("Opção Inválida. Retornaremos ao menu inicial");
                                        opc2 = 0;

                                    }
                                    break;


                            }




                        }

                    } while (opc2 == 1);

                }
                else
                {
                    int opc1 = 1;
                    do
                    {

                        Console.WriteLine("O elemento \"{0}\" não está presente na lista neste momento. Tente: ", element1);
                        Console.WriteLine("1 - Digitar outro elemento");
                        Console.WriteLine("2 - Retornar ao menu inicial");
                        opc1 = int.Parse(Console.ReadLine());


                        switch (opc1)
                        {

                            case 1:
                                {
                                    opc1 = 0;
                                    s.swapElements(lista);

                                }
                                break;


                            case 2:
                                {
                                    opc1 = 0;
                                    Console.WriteLine("Retornando ao menu inicial...");

                                }
                                break;


                            default:
                                {
                                    opc1 = 0;
                                    Console.WriteLine("Opção inválida. Retornaremos ao menu inicial");

                                }
                                break;

                        }

                    } while (opc1 == 1);

                }

            }

            


        }



    }
}
