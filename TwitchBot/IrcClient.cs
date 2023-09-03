using System.IO;
using System.Net.Sockets;

namespace TwitchBot
{
    public class IrcClient
    {
        private string userName;
        private string channel;
        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        public IrcClient(string ip, int port, string userName, string password, string channel)
        {
            this.userName = userName;
            this.channel = channel;
            this.tcpClient = new TcpClient(ip, port);
            this.inputStream = new StreamReader((Stream)this.tcpClient.GetStream());
            this.outputStream = new StreamWriter((Stream)this.tcpClient.GetStream());
            this.outputStream.WriteLine("PASS " + password);
            this.outputStream.WriteLine("NICK " + userName);
            this.outputStream.WriteLine("USER " + userName + " 8 * :" + userName);
            this.outputStream.WriteLine("JOIN #" + channel);
            this.outputStream.Flush();
        }

        public void SendIrcMessage(string message)
        {
            this.outputStream.WriteLine(message);
            this.outputStream.Flush();
        }

        public string ReadMessage() => this.inputStream.ReadLine();

        public void SendChatMessage(string message) => this.SendIrcMessage(":" + this.userName + "!" + this.userName + "@" + this.userName + ".tmi.twitch.tv PRIVMSG #" + this.channel + " :" + message);
    }
}
