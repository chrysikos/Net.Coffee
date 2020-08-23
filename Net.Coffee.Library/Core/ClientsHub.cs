using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Coffee.Library.Core
{
    public class ClientsHub
    {
        private HubConnection connection;
        public ClientsHub()
        {
            this.connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/ClientsHub")
                .WithAutomaticReconnect()
                .Build();

            this.connection.On<string, string>(
                "ReceiveMessage",
                (x, y) =>
                {

                });
        }
        public async Task StartAsync()
        {
            await connection.StartAsync();
        }
        public async Task SendMessage(string x, string y)
        {
            await this.connection.InvokeAsync("SendMessage", x, y);
        }
    }
}
