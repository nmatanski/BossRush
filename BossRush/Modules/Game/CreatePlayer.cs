using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace BossRush.Modules.Game
{
    public class CreatePlayer : ModuleBase<SocketCommandContext>
    {
        [Command("register")]
        public async Task PingAsync()
        {
            Player.CreateDefaultPlayer(Context.User.Mention);

            await ReplyAsync($"{Context.User.Mention}, your character has been created");
        }
    }
}
