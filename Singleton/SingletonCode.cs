using System;

namespace padroes_de_projeto.Singleton
{

    sealed class Livro
    {
        private static readonly Livro instance = new Livro();
        public int Quantidade { get; set; }
        private Livro() { }
        public static Livro GetInstance
        {
            get
            {
                return instance;
            }
        }

    }
    public class Client
    {
        public void Main()
        {
            // Colocando em prática
            Livro _livro1 = Livro.GetInstance;
            _livro1.Quantidade = 4;

            Livro _livro2 = Livro.GetInstance;
            _livro2.Quantidade = 90;

            Console.WriteLine(_livro1.Quantidade.ToString());
            Console.WriteLine(_livro2.Quantidade.ToString());


        }
    }
}