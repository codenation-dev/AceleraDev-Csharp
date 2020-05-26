using System;

namespace Heranca
{
    public class CriancaPequena : Pessoa
    {
        public CriancaPequena(int id, string nome) : base(id, nome)
        {

        }

        public override void Andar()
        {
            Console.WriteLine($"{Nome} está andando e brincando");
        }

        public override void Comer()
        {
            var sexo = SexoFeminino ? "a" : "o";
            Console.WriteLine($"Algum adulto iniciou a alimentacao d{sexo} {Nome}");
        }

        public override void TomarBanho()
        {
            var sexo = SexoFeminino ? "a" : "o";
            Console.WriteLine($"Algum adulto iniciou o banho d{sexo} {Nome}");
        }
    }
}
