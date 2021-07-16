using RabbitMQ.Client;
using System;
using System.Text;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };

            using (var connection = factory.CreateConnection())
            {
                using var channel = connection.CreateModel();

                channel.QueueDeclare(queue: "Exemplo", durable: false, exclusive: false, autoDelete: false, arguments: null);

                string message = $"Mensagem {DateTime.Now:yyyy-MM-dd hh24:mm:ss}";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "", routingKey: "Exemplo", basicProperties: null, body: body);

                Console.WriteLine("Mensagem enviada com sucesso!!!");
            }

            Console.ReadLine();
        }
    }
}
