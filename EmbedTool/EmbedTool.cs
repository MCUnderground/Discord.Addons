using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbedsOnFly
{
    public class EmbedTool : ModuleBase
    {
        EmbedBuilder basic;
        EmbedFooterBuilder footer;

        public void MakeEmbed(string color = "white", string title = null, string description = null, string imageUrl = null, string footerDescription = null, string footerImageUrl = null)
        {
            EmbedColor(color);
            if (title != null) { basic.WithTitle(title); }
            if (description != null) { basic.WithDescription(description); }
            if (imageUrl != null) { basic.WithThumbnailUrl(imageUrl); }

            footer = new EmbedFooterBuilder();

            if (footerDescription != null)
            {
                basic.WithFooter(footer
                     .WithText(footerDescription)
                );
            }
            if (footerImageUrl != null)
            {
                basic.WithFooter(footer
                     .WithIconUrl(footerImageUrl)
                );
            }
        }
        private void EmbedColor(string color)
        {
            basic = new EmbedBuilder();


            if (color.ToLower() == "aqua") { basic.WithColor(new Color(0, 255, 255)); }
            else if (color.ToLower() == "black") { basic.WithColor(new Color(0, 0, 0)); }
            else if (color.ToLower() == "blue") { basic.WithColor(new Color(0, 0, 255)); }
            else if (color.ToLower() == "fuchsia") { basic.WithColor(new Color(255, 0, 255)); }
            else if (color.ToLower() == "gray") { basic.WithColor(new Color(128, 128, 128)); }
            else if (color.ToLower() == "green") { basic.WithColor(new Color(0, 128, 0)); }
            else if (color.ToLower() == "lime") { basic.WithColor(new Color(0, 255, 0)); }
            else if (color.ToLower() == "maroon") { basic.WithColor(new Color(128, 0, 0)); }
            else if (color.ToLower() == "navy") { basic.WithColor(new Color(0, 0, 128)); }
            else if (color.ToLower() == "olive") { basic.WithColor(new Color(128, 128, 0)); }
            else if (color.ToLower() == "purple") { basic.WithColor(new Color(128, 0, 128)); }
            else if (color.ToLower() == "red") { basic.WithColor(new Color(255, 0, 0)); }
            else if (color.ToLower() == "silver") { basic.WithColor(new Color(192, 192, 192)); }
            else if (color.ToLower() == "teal") { basic.WithColor(new Color(0, 128, 128)); }
            else if (color.ToLower() == "white") { basic.WithColor(new Color(255, 255, 255)); }
            else if (color.ToLower() == "yellow") { basic.WithColor(new Color(255, 255, 0)); }
            else { basic.WithColor(new Color(255, 255, 255)); }

        }

        public async Task SendEmbed(CommandContext Context) { await Context.Channel.SendMessageAsync("", false, basic); }
    }
}
