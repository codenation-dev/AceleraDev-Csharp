using System;

namespace ClasseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Doguinho thorzinho = new Doguinho();
            thorzinho.CorDoPelo = "Marrom e preto";
            thorzinho.Id = 1;
            thorzinho.Nome = "Thor Cavalcante";
            thorzinho.NomeDoDono = "Diego";
            thorzinho.Porte = "medio";

            thorzinho.Comer();
            Console.WriteLine(thorzinho.Latir());
            thorzinho.Passear(true);
        }
    }
}
