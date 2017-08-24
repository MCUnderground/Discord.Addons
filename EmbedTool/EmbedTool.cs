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
        private EmbedBuilder basic;
        private EmbedFooterBuilder footer;

        private readonly IDictionary<string, Color> _paletteMap = new Dictionary<string, Color>()
        {
            { "aqua", new Color(0, 255, 255) },
            { "black", new Color(0, 0, 0) },
            { "blue", new Color(0, 0, 255) },
            { "fuchsia", new Color(255, 0, 255) },
            { "gray", new Color(128, 128, 128) },
            { "green", new Color(0, 128, 0) },
            { "lime", new Color(0, 255, 0) },
            { "maroon", new Color(128, 0, 0) },
            { "navy", new Color(0, 0, 128) },
            { "olive", new Color(128, 128, 0) },
            { "purple", new Color(128, 0, 128) },
            { "red", new Color(255, 0, 0) },
            { "silver", new Color(192, 192, 192) },
            { "teal", new Color(0, 128, 128) },
            { "white", new Color(255, 255, 255) },
            { "yellow", new Color(255, 255, 0) },
        };

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
            if (string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentNullException(nameof(color));
            }

            basic = new EmbedBuilder();

            string lookup = color.ToLower();
            if (_paletteMap.ContainsKey(lookup))
            {
                basic.WithColor(_paletteMap[lookup]);
            }
            else
            {
                basic.WithColor(new Color(255, 255, 255));
            }
        }

        public async Task SendEmbed(CommandContext Context) => await Context.Channel.SendMessageAsync("", false, basic);
    }
}
