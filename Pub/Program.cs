using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace Pub
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MqttClient mqttclient = new MqttClient("iot.eclipse.org"); 

                string clientId = Guid.NewGuid().ToString();
                mqttclient.Connect(clientId, "teste", "123");
            do
            {
                Console.ReadLine();
                mqttclient.Publish("Teste123", GetBytes("mensagem teste"));

            } while (true);


            Console.ReadKey();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
