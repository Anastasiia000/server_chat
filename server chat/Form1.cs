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
        public Form1()
        {
            InitializeComponent();
            labelMessenger.BackColor = Color.White;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            var factory = new ConnectionFactory() { HostName = "localhost" }; //создаем инстантс для соединения сервера //работаем с очередью на локальной машине
            using (var connection = factory.CreateConnection()) //содаем абстракциюб которая будет управлять версией протоколаб унификацией и тд
            using (var channel = connection.CreateModel())
            {
                //объявляем очередь, куда мы будем публиковать наше сообщения
                channel.QueueDeclare(queue: queue.Text,
                    durable: true, exclusive: false, autoDelete: false, arguments: null);

                //переводим сообщение, так как сигнатура метода требует байты
                var body = Encoding.UTF8.GetBytes(txtWrite.Text);

                channel.BasicPublish(exchange: "",
                    routingKey: queue.Text, basicProperties: null, body: body);

                txtQueue.Text += txtWrite.Text + " from: " + queue.Text + "\r\n";
                txtWrite.Clear();
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
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
    }
}
