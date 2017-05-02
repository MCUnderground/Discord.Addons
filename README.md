# EmbedOnFly
Faster embeds for Discord.Net 1.0+ warapper

Install nuget package: `Install-Package EmbedOnFly`

Example Usage :

```cpp
Embed embed = new Embed();

embed.MakeEmbed("red", "Example", "this is example");
embed.SendEmbed(Context);
```

Colors supported :

Co | lo | rs
--- | --- | ---
Aqua | Black | Blue
Fuchsia | Gray | Green
Lime | Maroon | Navy
Olive | Purple | Red
Silver | Teal | White
Yellow | / | /

Colors followed from: https://en.wikipedia.org/wiki/Web_colors#HTML_color_names
