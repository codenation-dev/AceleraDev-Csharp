using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Generics
                DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
                CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();
                calcDev.CalcularValorUnitario(dev);

                Console.WriteLine($"O valor final do desenv é {dev.ValorFinal}");


                CarroUsado carro = new CarroUsado();
                CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();
                calcCarro.CalcularValorUnitario(carro);

                Console.WriteLine($"O valor final do carro é {carro.ValorFinal}");


                KiloBuffet comida = new KiloBuffet();
                CalculoGenerico<KiloBuffet> calcBuffet = new CalculoGenerico<KiloBuffet>();
                calcBuffet.CalcularValorUnitario(comida);

                Console.WriteLine($"O valor final da comida é {comida.ValorFinal}");


                var texto = "Ola meu   nome é Thamirys??? Sim.. O sobrenome é Gameiro";

                Console.WriteLine($"A frase possui {texto.ContadorDePalavras()} palavras");

                //string erro = null;
                //erro.ContadorDePalavras();

            }
            catch (Exception ex)
            {
                // gravar log com mensagem de erro usando ex.Message

                Console.WriteLine($"Ihhh deu ruim, entre em contato com os desenvolvedores");
            }
            finally
            {
                Console.WriteLine("Isso acontece indenpendente de dar erro ou nao");
            }
            
        }
    }
}
