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
            var padraoEscolhido = 2;

            switch (padraoEscolhido)
            {
                case 0:
                    Console.WriteLine("Testando o padrão Abstract Factory.");
                    new padroes_de_projeto.AbstractFactory.Client().Main();
                    break;
                case 1:
                    Console.WriteLine("Testando o padrão Builder.");
                    new padroes_de_projeto.Builder.Client().Main();
                    break;
                case 2:
                    Console.WriteLine("Testando o padrão Singleton.");
                    new padroes_de_projeto.Singleton.Client().Main();
                    break;

                default:
                    Console.WriteLine("Escolha um padrão válido.");
                    break;
            }
        }
    }
}
