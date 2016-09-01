using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttClient mqttclient = new MqttClient("iot.eclipse.org");

            mqttclient.MqttMsgPublishReceived += mqttclient_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            mqttclient.Connect(clientId,"teste","123");

            Console.ReadKey();
        }

        static void mqttclient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
