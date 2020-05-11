using System;
using System.Collections.Generic;

namespace Conversao
{
    class Program
    {        
        static void Main(string[] args)
        {
            Programadora dev = new Programadora();
            dev.Nome = "Thamirys Gameiro";
            dev.AnosDeCarreira = 11;
            dev.ConheceMetodologiaAgil = true;
            dev.DataAdmissao = new DateTime(2020, 03, 03);
            dev.DataNascimento = new DateTime(1988, 09, 30);
            dev.Id = 5;
            dev.Linguagens = new List<string>() { "C#", "Javascript" };

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Diego";
            funcionario.DataAdmissao = new DateTime(2020, 03, 03);
            funcionario.DataNascimento = new DateTime(1986, 06, 30);

            // Conversão implícita

            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5F;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;

            string meuTexto = $"Neste texto vamos testar a conversao implicita " +
                $"de variavel inteira {varInt} e variavel float {varFloat}";

            Funcionario devfunc = dev;

            Console.WriteLine($"Conversao implicita: int para long: {varLong}");
            Console.WriteLine($"Conversao implicita: float para double: {varDouble}");
            Console.WriteLine($"Conversao implicita: char para int: {varInt1}");
            Console.WriteLine($"Conversao implicita por interpolacao: {meuTexto}");
            Console.WriteLine($"Conversao implicita: classe filha para classe pai: " 
                + $"Nome: {devfunc.Nome}, " 
                + $"dt adm: {devfunc.DataAdmissao:dd/MM/yyyy}, "
                + $"dt nasc: {devfunc.DataNascimento:dd/MM/yyyy}");
            Console.WriteLine();


            // Conversão explícita

            long varLongExp = 9223372036854775807;            
            int varIntExp = (int)varLongExp;

            varInt = (int)varLong;
            string longParaString = varLong.ToString();
            decimal varDecimal = Convert.ToDecimal("15,2");
            varDecimal += 10;
            decimal.TryParse("morango", out decimal varDecimalTry);
            decimal.TryParse("17", out decimal varDecimalTry1);

            if (devfunc is Programadora info)
                Console.WriteLine($"Conversao explicita: func e programadora: {info.Nome}");

            if (funcionario is Programadora infoFunc)
                Console.WriteLine($"Conversao explicita: func e programador: {infoFunc.Nome}");


            Console.WriteLine($"Conversao explicita: long(max) para int: {varIntExp}");
            Console.WriteLine($"Conversao explicita: long para int: {varInt}");
            Console.WriteLine($"Conversao explicita: long para string: {longParaString}");
            Console.WriteLine($"Conversao explicita: string para decimal: {varDecimal}");
            Console.WriteLine($"Conversao explicita: string para decimal via tryParse: {varDecimalTry}");
            Console.WriteLine($"Conversao explicita: string para decimal via tryParse: {varDecimalTry1}");
        }
    }

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Programadora : Funcionario
    {
        public List<string> Linguagens { get; set; }
        public bool ConheceMetodologiaAgil { get; set; }
        public int AnosDeCarreira { get; set; }
    }
}
