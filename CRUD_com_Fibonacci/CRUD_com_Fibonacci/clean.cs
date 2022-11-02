using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CRUD_com_Fibonacci
{
    class clean
    {
        verify v = new verify();

        public void limpar(ArrayList lista) {
            Console.Clear();
            if (v.vazia(lista))
            {
                Console.WriteLine("A lista já está vazia!");
                
            }
            else {
                lista.Clear();
                Console.WriteLine("Lista esvaziada com Sucesso!!!");
                
            }

            Console.ReadKey();

        }
    }
}
