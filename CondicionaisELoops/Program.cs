using System;
using System.Collections.Generic;

namespace CondicionaisELoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Codicionais

            Console.WriteLine("Informe sua idade:");
            int.TryParse(Console.ReadLine(), out int idade);

            if(idade < 12)
            {
                Console.WriteLine("Voce e uma crianca");
            }
            else if(idade >= 12 && idade < 18)
            {
                Console.WriteLine("Voce e um adolecente");
            }
            else
            {
                Console.WriteLine("Voce e um adulto");
            }

            string mensagem = idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";
            Console.WriteLine(mensagem);

            Console.WriteLine("Informe seu mes de nascimento:");
            var mes = Console.ReadLine();

            switch (mes.ToLower())
            {
                case "dezembro":
                case "janeiro":
                case "fevereiro":
                    Console.WriteLine("Voce nasceu no verão");
                    break;
                case "marco":
                case "abril":
                case "maio":
                    Console.WriteLine("Voce nasceu no outono");
                    break;
                case "junho":
                case "julho":
                case "agosto":
                    Console.WriteLine("Voce nasceu no inverno");
                    break;
                case "setembro":
                case "outubro":
                case "novembro":
                    Console.WriteLine("Voce nasceu na primavera");
                    break;
                default:
                    Console.WriteLine("Mes nao reconhecido");
                    break;
            }

            // List e Array
            string[] nomes = new string[5];
            nomes[0] = "Ana";
            nomes[1] = "Lucia";
            nomes[2] = "Viviane";
            nomes[3] = "Amanda";
            nomes[4] = "Thamirys";

            Console.WriteLine($"Nome 1: {nomes[0]}");
            Console.WriteLine($"Nome 2: {nomes[1]}");
            Console.WriteLine($"Nome 3: {nomes[2]}");

            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Gameiro");
            sobrenomes.Add("Oliveira");
            sobrenomes.Add("Cavalcante");
            sobrenomes.Add("Viana");
            sobrenomes.Add("Montani");
            sobrenomes.Add("Silva");

            // Loops

            for (int i = 0; i < sobrenomes.Count; i++)
            {
                Console.WriteLine($"Sobrenome {i + 1}: {sobrenomes[i]}");
            }
            Console.WriteLine();

            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome por foreach: {sobrenome}");
            }
            Console.WriteLine();

            sobrenomes.ForEach(sobrenome =>
                Console.WriteLine($"Sobrenome por foreach1: {sobrenome}"));
            Console.WriteLine();

            int x = sobrenomes.Count - 1;
            while (x >= 0)
            {
                Console.WriteLine($"Sobrenome por while invertido: {sobrenomes[x]}");
                x--;
            }
            Console.WriteLine();

            int y = 0;
            do
            {
                Console.WriteLine($"Nome por do while: {nomes[y]}");
                y++;
            } while (y < nomes.Length);
        }
    }
}
