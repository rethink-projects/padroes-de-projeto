using System;

namespace padroes_de_projeto.Builder
{
    // Usar o padrão Builder só faz sentido quando seus produtos são
    // bem complexos e requerem configuração extensiva.
    //O exemplo a seguir simplifica a implementação desse padrão utilizando a fluent interface do C#.
    class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder Body(string content)
        {
            _email.Body = content;
            return this;
        }
        public EmailBuilder From(string address)
        {
            _email.From = address;
            return this;
        }
        public Email Build()
        {
            return _email;
        }
        public EmailBuilder Subject(string title)
        {
            _email.Subject = title;
            return this;
        }
        public EmailBuilder To(string address)
        {
            _email.To = address;
            return this;
        }
    }
    public class Client
    {
        public void Main()
        {
            var emailBuilder = new EmailBuilder();
            var email = emailBuilder.To("felipe.muniz@rethink.dev")
                .From("contato@rethink.dev")
                .Subject("Assunto: Testando o padrão builder")
                .Body("Corpo do e-mail aqui!!!")
                .Build();
            Console.WriteLine($"{email.From} \n {email.To} \n {email.Subject} \n {email.Body} ");
        }

    }
}