using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossRush
{
    public partial class Bot
    {
        private DiscordSocketClient client;
        private CommandService commands;
        private IServiceProvider services;


        static void Main(string[] args) => new Bot().RunBotAsync().GetAwaiter().GetResult();

    }
}
