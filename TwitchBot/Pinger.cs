using System;
using System.Threading;

namespace TwitchBot
{
    public class Pinger
    {
        private IrcClient client;
        private Thread sender;

        public Pinger(IrcClient client)
        {
            this.client = client;
            this.sender = new Thread(new ThreadStart(this.Run));
        }

        public void Start()
        {
            this.sender.IsBackground = true;
            this.sender.Start();
        }

        private void Run()
        {
            while (true)
            {
                Console.WriteLine("Sending PING");
                this.client.SendIrcMessage("PING irc.twitch.tv");
                Thread.Sleep(TimeSpan.FromMinutes(5.0));
                Console.WriteLine("Sent PING");
            }
        }
    }
}
