using System;

namespace padroes_de_projeto.AbstractFactory
{
    public class AbstractFactoryCode
    {
    }
    // A interface fábrica abstrata declara um conjunto de métodos
    // que retorna diferentes produtos abstratos. Estes produtos são
    // chamados uma família e estão relacionados por um tema ou
    // conceito de alto nível. Produtos de uma família são
    // geralmente capazes de colaborar entre si. Uma família de
    // produtos pode ter várias variantes, mas os produtos de uma
    // variante são incompatíveis com os produtos de outro variante.
    public interface IGUIFactory
    {
        IButton CreateButton();

        ICheckbox CreateCheckbox();
    }

    // As fábricas concretas produzem uma família de produtos que
    // pertencem a uma única variante. A fábrica garante que os
    // produtos resultantes sejam compatíveis. Assinaturas dos
    // métodos fabrica retornam um produto abstrato, enquanto que
    // dentro do método um produto concreto é instanciado.
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }

    // Cada fábrica concreta tem uma variante de produto correspondente.

    class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    // Cada produto distinto de uma família de produtos deve ter uma
    // interface base. Todas as variantes do produto devem
    // implementar essa interface.
    public interface IButton
    {
        string Paint();
    }

    // Produtos concretos são criados por fábricas concretas
    // correspondentes.
    class WinButton : IButton
    {

        // Renderiza um botão no estilo Windows.
        public string Paint()
        {
            return "The result of the product A1.";
        }
    }

    class MacButton : IButton
    {
        // Renderiza um botão no estilo macOS.
        public string Paint()
        {
            return "The result of the product A2.";
        }
    }

    // Aqui está a interface base de outro produto. Todos os
    // produtos podem interagir entre si, mas a interação apropriada
    // só é possível entre produtos da mesma variante concreta.
    public interface ICheckbox
    {
        string Paint();

    }

    class WinCheckbox : ICheckbox
    {
        // Renderiza uma caixa de seleção estilo Windows.
        public string Paint()
        {
            return "The result of the product B1.";
        }

    }

    class MacCheckbox : ICheckbox
    {
        // Renderiza uma caixa de seleção no estilo macOS.
        public string Paint()
        {
            return "The result of the product B2.";
        }

    }
    // O código cliente trabalha com fábricas e produtos apenas
    // através de tipos abstratos: GUIFactory, Button e Checkbox.
    // Isso permite que você passe qualquer subclasse fábrica ou de
    // produto para o código cliente sem quebrá-lo.
    class Client
    {
        public void Main()
        {
            // O código do cliente pode funcionar com qualquer classe de fábrica concreta.
            Console.WriteLine("Client: Testando Código com WinFactory");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testando Código com MacFactory");
            ClientMethod(new MacFactory());
        }

        public void ClientMethod(IGUIFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckbox();

            Console.WriteLine(productA.Paint());

            Console.WriteLine(productB.Paint());

        }
    }

}