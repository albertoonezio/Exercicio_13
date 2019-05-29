using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            int terceiroNumero = 0;
            List<int> listaDecrescente = new List<int>();

            Console.Write("Digite o Primeiro Número: ");
            primeiroNumero = int.Parse(Console.ReadLine());
            listaDecrescente.Add(primeiroNumero);

            Console.Write("Digite o Segundo Número: ");
            segundoNumero = int.Parse(Console.ReadLine());
            listaDecrescente.Add(segundoNumero);

            Console.Write("Digite o Terceiro Número: ");
            terceiroNumero = int.Parse(Console.ReadLine());
            listaDecrescente.Add(terceiroNumero);

            listaDecrescente.Sort();
            listaDecrescente.Reverse();

            foreach (int decrescente in listaDecrescente)
            {
                Console.WriteLine(decrescente);
            }
        }
    }
}
