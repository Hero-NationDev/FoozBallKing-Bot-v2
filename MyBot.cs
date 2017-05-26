using System;
using Discord;
using Discord.Commands;
namespace FoozBallKing_Bot_v2
{
    class MyBot
    {
        DiscordClient discord;

        public MyBot()
        {
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '|';
                x.AllowMentionPrefix = true;
            });

            var commands = discord.GetService<CommandService>();

            commands.CreateCommand("botinfo")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Hey there! My name is FoozBallKing Bot! My owner is @IndoHQ Blu YT✓ᵛᵉʳᶦᶠᶦᵉᵈ#3035! My current version is `v2.0 Test Build 1`! Test Build 2 will be the Music features of me! One more thing, my prefix is `|`!");
                });

            commands.CreateCommand("foozstaffyt")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://www.youtube.com/channel/UCfMwlVqas3DZIml24FXY7rw https://www.youtube.com/user/dragons99990 https://www.youtube.com/channel/UCArKd8rTTWvdK7gA7E3TfVw https://www.youtube.com/channel/UCRFcXEpywYabEVvoKLGdJBw");
                });
            discord.ExecuteAndWait(async () => 
            {
                await discord.Connect("MjkyMDUzMjE5NTI4NjcxMjMz.DAHWuA.aGblJuHMZAcj8bbQl772XI2YrkY", TokenType.Bot);
            });

            
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
