using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server_chat
{
    public partial class Form1 : Form
    {
        string myName = "";
       // public Point point = new Point( button4.Location.X);
        public Form1()
        {
            InitializeComponent();
            labelMessenger.BackColor = Color.White;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" }; //создаем инстантс для соединения сервера //работаем с очередью на локальной машине
            using (var connection = factory.CreateConnection()) //содаем абстракциюб которая будет управлять версией протоколаб унификацией и тд
            using (var channel = connection.CreateModel()) {
                //объявляем очередь, куда мы будем публиковать наше сообщения
                channel.QueueDeclare(queue: queue.Text,
                    durable: true, exclusive: false, autoDelete: false, arguments: null);

                //переводим сообщение, так как сигнатура метода требует байты
                var body = Encoding.UTF8.GetBytes(txtWrite.Text);

                channel.BasicPublish(exchange: "",
                    routingKey: queue.Text, basicProperties: null, body: body);

                txtQueue.Text += "I write to " + queue.Text +": "+ txtWrite.Text + "\r\n";
                txtWrite.Clear();

                /*var factory = new ConnectionFactory() { HostName = "localhost" }; 
                using (var connection = factory.CreateConnection()) 
                using (var channel = connection.CreateModel()) {
                    channel.ExchangeDeclare(exchange: "direct_logs",
                        type: ExchangeType.Direct);

                    var body = Encoding.UTF8.GetBytes(txtWrite.Text);
                    channel.BasicPublish(exchange: "direct_logs",
                        routingKey: "a", basicProperties: null, body: body);
                    txtQueue.Text += txtWrite.Text + " to: " + queue.Text + "\r\n";
                    txtWrite.Clear();
                }*/
            }
            }

        private void btnReceive_Click(object sender, EventArgs e)
        {

           /* var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel()) {
                channel.ExchangeDeclare(exchange: "direct_logs",
                    type: ExchangeType.Direct);
                var queueName = channel.QueueDeclare(autoDelete: false).QueueName;

                channel.QueueBind(queue: queueName,
                    exchange: "direct_logs",
                    routingKey: "a");

                channel.QueueBind(queue: queueName,
                    exchange: "direct_logs",
                    routingKey: "b");
                channel.QueueBind(queue: queueName,
                     exchange: "direct_logs",
                     routingKey: "c");

                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += (sender, e) => {
                    var body = e.Body;
                    var message = Encoding.UTF8.GetString(body.ToArray());
                    textBox1.Text += $"from {queueName} you get: {message}...";
                };
                channel.BasicConsume(queue: queueName,
                    autoAck: true,
                    consumer: consumer);

            }*/

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            {
                channel.QueueDeclare(queue: queue.Text,
                                durable: true,
                                exclusive: false,
                                autoDelete: false,
                                arguments: null);
                var consumer = new EventingBasicConsumer(channel);

                BasicGetResult result = channel.BasicGet(queue: queue.Text, autoAck: true);
                if (result != null)
                    txtReceive.Invoke(new MethodInvoker(delegate { txtReceive.Text += (Encoding.UTF8.GetString(result.Body.ToArray())) + " from: " + queue.Text + "\r\n"; }));
                else
                    return;
            }
            channel.Close();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            createNewRoom form = new createNewRoom();
            form.Show();
            //queue.Items.Add
        }
    }
}
