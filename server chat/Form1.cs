using RabbitMQ.Client;
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

namespace server_chat {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e) {
            int timeToSleep = new Random().Next(1000, 3000);
            Thread.Sleep(timeToSleep);
            var factory = new ConnectionFactory() { HostName = "localhost" }; //создаем инстантс для соединения сервера //работаем с очередью на локальной машине
            using (var connection = factory.CreateConnection()) //содаем абстракциюб которая будет управлять версией протоколаб унификацией и тд
            using (var channel = connection.CreateModel()) {
                //объявляем очередь, куда мы будем публиковать наше сообщения
                channel.QueueDeclare(queue: "dev-queue",
                    durable: true, exclusive: false, autoDelete: false, arguments: null);

                //переводим сообщение, так как сигнатура метода требует байты
                var body = Encoding.UTF8.GetBytes(txtWrite.Text);

                channel.BasicPublish(exchange: "",
                    routingKey: "dev-queue", basicProperties: null, body: body);

                labelMessenger.Text +="\n"+ txtWrite.Text;
                txtWrite.Clear();
            }
        }
    }
}
