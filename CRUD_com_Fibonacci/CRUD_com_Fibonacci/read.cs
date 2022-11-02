using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class read
    {
        verify v = new verify();
        public void exibirLista(ArrayList lista) {
            Console.Clear();
            if (v.vazia(lista))
            {
               
                Console.WriteLine("A lista encontra-se vazia no momento.");
               

            }
            else {
                for (int i = 0; i < lista.Count; i++) {

                    Console.WriteLine(lista[i]);

                }

            }

            Console.ReadKey();

        }
    }
}
