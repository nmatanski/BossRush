using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossRush.Modules
{
    public class Greetings : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task GreetAsync()
        {
            await ReplyAsync($"Greetings, {Context.User.Mention}. Long days and pleasant nights.");
        }
    }
}
