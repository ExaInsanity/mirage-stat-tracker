namespace Mirage;

using System;
using System.Text;

internal static class Colorizer
{
    #region Stars
    public static String ColorizeStars(Int32 stars)
    {
        return stars switch
        {
            Int32 when stars < 100 => $"[#AAAAAA][[{stars}✫]][/]",
            Int32 when stars < 200 => $"[#FFFFFF][[{stars}✫]][/]",
            Int32 when stars < 300 => $"[#FFAA00][[{stars}✫]][/]",
            Int32 when stars < 400 => $"[#55FFFF][[{stars}✫]][/]",
            Int32 when stars < 500 => $"[#00AA00][[{stars}✫]][/]",
            Int32 when stars < 600 => $"[#00AAAA][[{stars}✫]][/]",
            Int32 when stars < 700 => $"[#AA0000][[{stars}✫]][/]",
            Int32 when stars < 800 => $"[#FF55FF][[{stars}✫]][/]",
            Int32 when stars < 900 => $"[#5555FF][[{stars}✫]][/]",
            Int32 when stars < 1000 => $"[#AA00AA][[{stars}✫]][/]",
            Int32 when stars < 1100 => ColorizeRainbowPrestige(stars),
            Int32 when stars < 1200 => $"[#AAAAAA][[[/][#FFFFFF]{stars}[/][#AAAAAA]✪]][/]",
            Int32 when stars < 1300 => $"[#AAAAAA][[[/][#FFFF55]{stars}[/][#FFAA00]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1400 => $"[#AAAAAA][[[/][#55FFFF]{stars}[/][#00AAAA]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1500 => $"[#AAAAAA][[[/][#55FF55]{stars}[/][#00AA00]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1600 => $"[#AAAAAA][[[/][#00AAAA]{stars}[/][#5555FF]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1700 => $"[#AAAAAA][[[/][#FF5555]{stars}[/][#AA0000]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1800 => $"[#AAAAAA][[[/][#FF55FF]{stars}[/][#AA00AA]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 1900 => $"[#AAAAAA][[[/][#5555FF]{stars}[/][#0000AA]✪[/][#AAAAAA]]][/]",
            Int32 when stars < 2000 => $"[#AAAAAA][[[/][#AA00AA]{stars}[/][#555555]✪[/][#AAAAAA]]][/]",
            _ => ColorizeLegendaryPrestige(stars)
        };
    }

    private static String ColorizeRainbowPrestige(Int32 stars)
    {
        String representation = stars.ToString();
        StringBuilder builder = new("[#FF5555][[[/]");
        builder.Append($"[#FFAA00]{representation[0]}[/]")
            .Append($"[#FFFF55]{representation[1]}[/]")
            .Append($"[#55FF55]{representation[2]}[/]")
            .Append($"[#55FFFF]{representation[3]}[/]")
            .Append($"[#FF55FF]✫[/]")
            .Append($"[#AA00AA]]][/]");

        return builder.ToString();
    }

    private static String ColorizeLegendaryPrestige(Int32 stars)
    {
        String representation = stars.ToString();

        return stars switch
        {
            Int32 when stars < 2100 => ColorizeMirrorPrestige(representation),
            Int32 when stars < 2200 => ColorizeLightPrestige(representation),
            Int32 when stars < 2300 => ColorizeDawnPrestige(representation),
            Int32 when stars < 2400 => ColorizeDuskPrestige(representation),
            Int32 when stars < 2500 => ColorizeAirPrestige(representation),
            Int32 when stars < 2600 => ColorizeWindPrestige(representation),
            Int32 when stars < 2700 => ColorizeNebulaPrestige(representation),
            Int32 when stars < 2800 => ColorizeThunderPrestige(representation),
            Int32 when stars < 2900 => ColorizeEarthPrestige(representation),
            Int32 when stars < 3000 => ColorizeWaterPrestige(representation),
            _ => ColorizeFirePrestige(representation)
        };
    }

    private static String ColorizeMirrorPrestige(String stars)
    {
        StringBuilder builder = new("[#555555][[[/]");
        builder.Append($"[#AAAAAA]{stars[0]}[/]")
            .Append($"[#FFFFFF]{stars[1..3]}[/]")
            .Append($"[#AAAAAA]{stars[3]}✪[/]")
            .Append($"[#555555]]][/]");

        return builder.ToString();
    }

    private static String ColorizeLightPrestige(String stars)
    {
        StringBuilder builder = new($"[#FFFFFF][[{stars[0]}[/]");
        builder.Append($"[#FFFF55]{stars[1..3]}[/]")
            .Append($"[#FFAA00]{stars[3]}⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeDawnPrestige(String stars)
    {
        StringBuilder builder = new($"[#FFAA00][[{stars[0]}[/]");
        builder.Append($"[#FFFFFF]{stars[1..3]}[/]")
            .Append($"[#55FFFF]{stars[3]}[/]")
            .Append($"[#00AAAA]⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeDuskPrestige(String stars)
    {
        StringBuilder builder = new($"[#AA00AA][[{stars[0]}[/]");
        builder.Append($"[#FF55FF]{stars[1..3]}[/]")
            .Append($"[#FFAA00]{stars[3]}[/]")
            .Append($"[#FFFF55]⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeAirPrestige(String stars)
    {
        StringBuilder builder = new($"[#55FFFF][[{stars[0]}[/]");
        builder.Append($"[#FFFFFF]{stars[1..3]}[/]")
            .Append($"[#AAAAAA]{stars[3]}⚝[/]")
            .Append("[#555555]]][/]");

        return builder.ToString();
    }

    private static String ColorizeWindPrestige(String stars)
    {
        StringBuilder builder = new($"[#FFFFFF][[{stars[0]}[/]");
        builder.Append($"[#55FF55]{stars[1..3]}[/]")
            .Append($"[#00AA00]{stars[3]}⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeNebulaPrestige(String stars)
    {
        StringBuilder builder = new($"[#AA0000][[{stars[0]}[/]");
        builder.Append($"[#FF5555]{stars[1..3]}[/]")
            .Append($"[#FF55FF]{stars[3]}⚝[/]")
            .Append($"[#AA00AA]]][/]");

        return builder.ToString();
    }

    private static String ColorizeThunderPrestige(String stars)
    {
        StringBuilder builder = new($"[#FFFF55][[{stars[0]}[/]");
        builder.Append($"[#FFFFFF]{stars[1..3]}[/]")
            .Append($"[#555555]{stars[3]}⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeEarthPrestige(String stars)
    {
        StringBuilder builder = new($"[#55FF55][[{stars[0]}[/]");
        builder.Append($"[#00AA00]{stars[1..3]}[/]")
            .Append($"[#FFAA00]{stars[3]}⚝]][/]");

        return builder.ToString();
    }

    private static String ColorizeWaterPrestige(String stars)
    {
        StringBuilder builder = new($"[#55FFFF][[{stars[0]}[/]");
        builder.Append($"[#00AAAA]{stars[1..3]}[/]")
            .Append($"[#5555FF]{stars[3]}⚝[/]")
            .Append("[#0000AA]]][/]");

        return builder.ToString();
    }

    private static String ColorizeFirePrestige(String stars)
    {
        StringBuilder builder = new($"[#FFFF55][[{stars[0]}[/]");
        builder.Append($"[#FFAA00]{stars[1..3]}[/]")
            .Append($"[#FF5555]{stars[3..]}⚝[/]")
            .Append("[#AA0000]]][/]");

        return builder.ToString();
    }
    #endregion
}
