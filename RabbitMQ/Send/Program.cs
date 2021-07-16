using RabbitMQ.Client;
using System;
using System.Text;

namespace Send
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Fila com mensagem"

            //var factory = new ConnectionFactory() { HostName = "localhost" };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: "hello",
            //                         durable: false,
            //                         exclusive: false,
            //                         autoDelete: false,
            //                         arguments: null);

            //    string message = "Hello World!";
            //    var body = Encoding.UTF8.GetBytes(message);

            //    channel.BasicPublish(exchange: "",
            //                         routingKey: "hello",
            //                         basicProperties: null,
            //                         body: body);
            //    Console.WriteLine(" [x] Sent {0}", message);
            //}

            //Console.WriteLine(" Press [enter] to exit.");
            //Console.ReadLine();

            #endregion

            //var factory = new ConnectionFactory() { HostName = "localhost" };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: "task_queue",
            //                         durable: true, //definindo que a msg nao sera excluida da fila caso o servico pare
            //                         exclusive: false,
            //                         autoDelete: false,
            //                         arguments: null);

            //    var message = GetMessage(args);
            //    var body = Encoding.UTF8.GetBytes(message);

            //    var properties = channel.CreateBasicProperties();
            //    properties.Persistent = true; //marcando as mensagns como persistentes

            //    channel.BasicPublish(exchange: "",
            //                         routingKey: "task_queue",
            //                         basicProperties: properties,
            //                         body: body);
            //    Console.WriteLine(" [x] Sent {0}", message);
            //}
        

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }

        private static string GetMessage(string[] args)
        {
            return ((args.Length > 0) ? string.Join(" ", args) : "Hello World!");
        }
    }
}
