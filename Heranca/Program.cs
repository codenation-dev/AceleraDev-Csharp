using System;
using ModificadorAcesso;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Adulto thamy = new Adulto(1, "Thamirys");

            thamy.DataDeNascimento = new DateTime(1988, 09, 30);
            thamy.SexoFeminino = true;



            CriancaPequena davi = new CriancaPequena(2, "Davi")
            {
                DataDeNascimento = new DateTime(2018, 03, 06),              
                SexoFeminino = false
            };

            thamy.Comer();
            thamy.TomarBanho();
            thamy.Andar();
            Console.WriteLine();

            davi.Comer();
            davi.TomarBanho();
            davi.Andar();

            ClassePublica publica = new ClassePublica();
            publica.MinhaPropPublica = 10;

            Console.WriteLine(Calculo.Somar(10, 15));

            Adulto.DizerBomDia();
        }
    }

    // colocar em outro arquivo sempre !!!
    class  MyClass : ClassePublica
    {       
        public void MeuMetodo()
        {
            base.MinhaPropProtectedInternal = 15;
        }
    }
}
