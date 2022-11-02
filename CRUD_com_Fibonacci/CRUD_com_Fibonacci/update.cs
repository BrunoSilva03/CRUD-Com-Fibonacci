using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class update
    {
        verify v = new verify();


        public void alterar(ArrayList lista)
        {

            update u = new update();
            Console.Clear();

            if (v.vazia(lista))
            {
                Console.WriteLine("A lista encontra-se vazia no momento.");
                Console.ReadKey();
            }
            else
            {
                string element, newElement;
                bool retornarMenuInicial = false;

                Console.WriteLine("Digite o elemento que deseja alterar na lista:");
                element = Console.ReadLine();


                if (lista.Contains(element))
                {
                    
                    int option = 1;
                    Console.WriteLine("Digite o elemento para substituir \"{0}\" na lista:", element);
                    newElement = Console.ReadLine();
                    do
                    {

                        if (lista.Contains(newElement))
                        {
                            Console.WriteLine("\"{0}\" já está presente na lista, Tente: ", newElement);
                            Console.WriteLine("1 - Digite outro elemento");
                            Console.WriteLine("2 - Retornar ao menu inicial");
                            option = int.Parse(Console.ReadLine());


                            switch (option)
                            {

                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Digite o elemento para substituir \"{0}\" na lista:", element);
                                        newElement = Console.ReadLine();

                                        if (lista.Contains(newElement))
                                        {
                                            option = 1;

                                        }
                                        else
                                        {

                                            option = 0;

                                        }



                                    }
                                    break;


                                case 2:
                                    {
                                        retornarMenuInicial = true;
                                        option = 0;

                                    }
                                    break;



                                default:
                                    {
                                        retornarMenuInicial = true;
                                        Console.WriteLine("Opção Inválida. Retornaremos ao menu principal");
                                        option = 0;
                                        Console.ReadKey();

                                    }
                                    break;

                            }
                        }
                        else {
                            option = 0;
                        }



                    } while (option == 1);

                    if (retornarMenuInicial == false)
                    {


                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].Equals(element))
                            {
                                lista[i] = newElement;
                            }

                        }

                        Console.WriteLine("elemento \"{0}\" substituído pelo elemento \"{1}\" na lista com Sucesso", element, newElement);
                        Console.ReadKey();
                    }


                }
                else
                {

                    int opc = 1;

                    do
                    {
                        Console.WriteLine("\"{0}\" não está presente na lista, Tente:", element);
                        Console.WriteLine("1 - Digite outro elemento");
                        Console.WriteLine("2 - Retornar ao menu inicial");
                        opc = int.Parse(Console.ReadLine());

                        switch (opc)
                        {

                            case 1:
                                {
                                    opc = 0;
                                    u.alterar(lista);

                                }
                                break;


                            case 2:
                                {

                                    opc = 0;

                                }
                                break;


                            default:
                                {

                                    Console.WriteLine("Opção Inválida, Retornaremos ao menu principal");
                                    opc = 0;
                                    Console.ReadKey();


                                }
                                break;
                        }

                    } while (opc == 1);



                }



            }

        }
    }
}
