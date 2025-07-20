using Confluent.Kafka;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaChatWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(message)) return;

            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            try
            {
                using var producer = new ProducerBuilder<Null, string>(config).Build();
                await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });

                txtChat.AppendText($"You: {message}{Environment.NewLine}");
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = "localhost:9092",
                    GroupId = Guid.NewGuid().ToString(),
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
                consumer.Subscribe("chat-topic");

                while (true)
                {
                    try
                    {
                        var cr = consumer.Consume();
                        this.Invoke((MethodInvoker)(() =>
                        {
                            txtChat.AppendText($"Other: {cr.Message.Value}{Environment.NewLine}");
                        }));
                    }
                    catch { }
                }
            });
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}