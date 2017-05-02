# EmbedOnFly
Faster embeds for Discord.Net 1.0+ warapper

Install: 
```tex
Install-Package Discord.Addons.EmbedTool
```

Example Usage :

```cpp
EmbedTool embed = new EmbedTool();

embed.MakeEmbed("red", "Example", "this is example");
embed.SendEmbed(Context);
```

Colors supported :

Colors | to | use <3
--- | --- | ---
Aqua | Black | Blue
Fuchsia | Gray | Green
Lime | Maroon | Navy
Olive | Purple | Red
Silver | Teal | White
Yellow | / | /

Colors followed from: https://en.wikipedia.org/wiki/Web_colors#HTML_color_names
