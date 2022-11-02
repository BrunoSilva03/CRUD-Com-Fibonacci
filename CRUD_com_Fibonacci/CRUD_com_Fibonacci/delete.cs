using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class delete
    {
        verify v = new verify();


        public void excluir(ArrayList lista) {

            delete d = new delete();

            if (v.vazia(lista))
            {
                Console.WriteLine("A lista encontra-se atualmente vazia.");

            }
            else {
                string elementExclude;
                Console.WriteLine("Digite o elemento que deseja excluir da lista");
                elementExclude = Console.ReadLine();

                if (lista.Contains(elementExclude))
                {

                    lista.Remove(elementExclude);
                    Console.WriteLine("\"{0}\" excluído da lista com Sucesso!!!", elementExclude);
                    Console.ReadKey();

                }
                else {

                    int opc = 1;

                    Console.WriteLine("\"{0}\" não existe na lista", elementExclude);
                    Console.WriteLine("1 - Digite outro elemento");
                    Console.WriteLine("2 - Retornar ao menu inicial");
                    opc = int.Parse(Console.ReadLine());


                    switch (opc) {

                        case 1: {

                                d.excluir(lista);
                                opc = 0;

                            }break;


                        case 2:
                            {
                                opc = 0;
                           

                            }break;



                        default: {
                                Console.Clear();
                                Console.WriteLine("Opção Inválida, Retornaremos ao menu inicial");
                                opc = 0;
                                Console.ReadKey();


                            }break;


                    }

                }

            }

        }
    }
}
