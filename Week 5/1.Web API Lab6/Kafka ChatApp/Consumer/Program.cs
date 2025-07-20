using System;
using Confluent.Kafka;

namespace KafkaChatConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Kafka Chat Consumer ===");

            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            try
            {
                while (true)
                {
                    var cr = consumer.Consume();
                    Console.WriteLine($"Other: {cr.Message.Value}");
                }
            }
            catch (ConsumeException e)
            {
                Console.WriteLine($"❌ Error: {e.Message}");
            }
            finally
            {
                consumer.Close();
            }
        }
    }
}