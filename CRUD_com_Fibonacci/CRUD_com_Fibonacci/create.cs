using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class create
    {
        

        public void inserir(ArrayList lista)
        {
            create c = new create();
            string newElement;

            Console.Clear();
            Console.WriteLine("Digite o elemento que deseja inserir na lista: ");
            newElement = Console.ReadLine();



            if (lista.Contains(newElement))
            {

                int opc = 1;
                do
                {

                    Console.WriteLine("\"{0}\" já está presente na lista, Escolha uma opção, Tecle: ", newElement);
                    Console.WriteLine("1 - para digitar outro elemento");
                    Console.WriteLine("2 - para retornar ao menu inicial");
                    opc = int.Parse(Console.ReadLine());


                    switch (opc)
                    {

                        case 1:
                            {
                                
                                c.inserir(lista);
                                opc = 0;

                            }
                            break;


                        case 2:
                            {
                                
                                Console.WriteLine("Retornando ao menu inicial");

                            }
                            break;

                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Opção Inválida, Retornaremos ao menu inicial");
                                opc = 0;
                                Console.ReadKey();

                            }
                            break;

                    }


                } while (opc == 1);



            }
            else
            {
                
                lista.Add(newElement);
                Console.WriteLine("\"{0}\" inserido na lista com Sucesso!!!", newElement);
                Console.ReadKey();


            }

            

            }
        }
    }


