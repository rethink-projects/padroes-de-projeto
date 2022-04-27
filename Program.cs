using System;

namespace padroes_de_projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escolher o padrão a testar: 
            // 0 - Abstract Factory
            // 1 - Builder
            // 2 - Singleton
            var padraoEscolhido = 0;

            switch (padraoEscolhido)
            {
                case 0:
                    Console.WriteLine("Testando o padrão Abstract Factory.");
                    new padroes_de_projeto.AbstractFactory.Client().Main();
                    break;
                case 1:
                    Console.WriteLine("Testando o padrão Builder.");
                    break;
                case 2:
                    Console.WriteLine("Testando o padrão Singleton.");
                    break;

                default:
                    Console.WriteLine("Escolha um padrão válido.");
                    break;
            }
        }
    }
}
