using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaChatProducer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Kafka Chat Producer ===");

            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"  // Kafka must be running
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            while (true)
            {
                Console.Write("You: ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input.ToLower() == "exit") break;

                try
                {
                    var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });
                    Console.WriteLine($"[Sent] {result.Value}");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"❌ Error: {e.Error.Reason}");
                }
            }

            Console.WriteLine("Producer closed.");
        }
    }
}