using System;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("Thamirys");
            nomes.Add("Alessandra");
            nomes.Add("Ana");

            nomes.ForEach(x => {               
                Console.WriteLine(x);
            });

            //Console.WriteLine(nomes[0]);


            SortedList<int, int> dados = new SortedList<int, int>();
            dados.Add(5, 15);
            dados.Add(1, 11);
            dados.Add(2, 12);
            dados.Add(4, 14);
            dados.Add(3, 13);

            Console.WriteLine(dados[2]);

            Dictionary<string, string> departamentos = new Dictionary<string, string>();
            departamentos.Add("TI", "Tecnologia da Informacao");
            departamentos.Add("RH", "Recursos Humanos");
            departamentos.Add("Mkt", "Marketing");

            Console.WriteLine(departamentos["RH"]);

            Queue<int> senhasFila = new Queue<int>();
            senhasFila.Enqueue(1);
            senhasFila.Enqueue(2);
            senhasFila.Enqueue(3);
            senhasFila.Enqueue(4);

            senhasFila.Dequeue();
            Console.WriteLine(senhasFila.Peek());

            Stack<int> senhasPilha = new Stack<int>();
            senhasPilha.Push(1);
            senhasPilha.Push(2);
            senhasPilha.Push(3);
            senhasPilha.Push(4);

            senhasPilha.Pop();
            Console.WriteLine(senhasPilha.Peek());
        }
    }
}
