using System;

namespace MeuPrimeiroProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos

            string sobrenome;

            string nome = "Thamirys";
            bool EProgramadora = true;
            int idade = 31;
            sobrenome = "Gameiro";

            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 7;

            Console.WriteLine($"Resultado da soma: {soma}");
            Console.WriteLine($"Resultado da subtracao: {subtracao}");
            Console.WriteLine($"Resultado da multiplicacao: {multiplicacao}");
            Console.WriteLine($"Resultado da divisao: {divisao}");
            Console.WriteLine($"Resultado do resto: {mod}");

            // Operadores lógicos

            var Everdadeiro = true && true;
            var Efalso1 = true && false;
            var Efalso2 = false && true;
            var Efalso3 = false && false;

            var OuVerdadeiro = true || true;
            var OuVerdadeiro1 = false || true;
            var OuVerdadeiro2 = true || false;
            var Oufalso = false || false;

            Console.WriteLine(Everdadeiro);
            Console.WriteLine(Efalso1);
            Console.WriteLine(Efalso2);
            Console.WriteLine(Efalso3);

            Console.WriteLine(OuVerdadeiro);
            Console.WriteLine(OuVerdadeiro1);
            Console.WriteLine(OuVerdadeiro2);
            Console.WriteLine(Oufalso);

            var falsoNegado = !Oufalso;
            var verdadeiroNegado = !OuVerdadeiro;

            Console.WriteLine(falsoNegado);
            Console.WriteLine(verdadeiroNegado);

        }
    }
}
