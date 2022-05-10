namespace Mirage;

using System;
using System.Globalization;
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

    #region Winstreak
    public static String ColorizeWinstreak(Int32 winstreak)
    {
        return winstreak switch
        {
            Int32 when winstreak <= 2 => $"[#AAAAAA]{winstreak}[/]",
            Int32 when winstreak <= 5 => $"[#FFFFFF]{winstreak}[/]",
            Int32 when winstreak <= 10 => $"[#F7FF33]{winstreak}[/]",
            Int32 when winstreak <= 20 => $"[#55FFFF]{winstreak}[/]",
            Int32 when winstreak <= 50 => $"[#800000]{winstreak}[/]",
            Int32 when winstreak <= 100 => $"[#FFAEED]{winstreak}[/]",
            _ => $"[#6100B8]{winstreak}[/]"
        };
    }
    #endregion

    #region Finals
    public static String ColorizeFinalKills(Int32 finals)
    {
        return finals switch
        {
            Int32 when finals <= 1000 => $"[#AAAAAA]{finals}[/]",
            Int32 when finals <= 2500 => $"[#FFFFFF]{finals}[/]",
            Int32 when finals <= 5000 => $"[#F7FF33]{finals}[/]",
            Int32 when finals <= 10_000 => $"[#55FFFF]{finals}[/]",
            Int32 when finals <= 20_000 => $"[#800000]{finals}[/]",
            Int32 when finals <= 50_000 => $"[#FFAEED]{finals}[/]",
            Int32 when finals <= 99_999 => $"[#6100B8]{finals}[/]",
            _ => ColorizeRainbowFinalKills(finals)
        };
    }

    private static String ColorizeRainbowFinalKills(Int32 finals)
    {
        String representation = finals.ToString();

        StringBuilder builder = new($"[#FF5555]{representation[0]}[/]");
        builder.Append($"[#FFAA00]{representation[1]}[/]")
            .Append($"[#FFFF55]{representation[2]}[/]")
            .Append($"[#55FF55]{representation[3]}[/]")
            .Append($"[#55FFFF]{representation[4]}[/]")
            .Append($"[#AA00AA]{representation[5..]}[/]");

        return builder.ToString();
    }
    #endregion

    #region Wins
    public static String ColorizeWins(Int32 wins)
    {
        return wins switch
        {
            Int32 when wins <= 250 => $"[#AAAAAA]{wins}[/]",
            Int32 when wins <= 1000 => $"[#FFFFFF]{wins}[/]",
            Int32 when wins <= 2500 => $"[#F7FF33]{wins}[/]",
            Int32 when wins <= 5000 => $"[#55FFFF]{wins}[/]",
            Int32 when wins <= 10_000 => $"[#800000]{wins}[/]",
            Int32 when wins <= 20_000 => $"[#FFAEED]{wins}[/]",
            _ => $"[#6100B8]{wins}[/]"
        };
    }
    #endregion

    #region FKDR
    public static String ColorizeFKDR(Single fkdr)
    {
        String representation = fkdr.ToString("F2", CultureInfo.InvariantCulture);
        return fkdr switch
        {
            Single when fkdr <= 1.0 => $"[#AAAAAA]{representation}[/]",
            Single when fkdr <= 2.0 => $"[#FFFFFF]{representation}[/]",
            Single when fkdr <= 3.0 => $"[#F7FF33]{representation}[/]",
            Single when fkdr <= 5.0 => $"[#55FFFF]{representation}[/]",
            Single when fkdr <= 10.0 => $"[#800000]{representation}[/]",
            Single when fkdr <= 50.0 => $"[#FFAEED]{representation}[/]",
            Single when fkdr < 100.0 => $"[#6100B8]{representation}[/]",
            _ => ColorizeRainbowFKDR(representation)
        };
    }

    public static String ColorizeRainbowFKDR(String fkdr)
    {
        StringBuilder builder = new($"[#FF5555]{fkdr[0]}[/]");
        builder.Append($"[#FFAA00]{fkdr[1]}[/]")
            .Append($"[#FFFF55]{fkdr[2]}[/]")
            .Append($"[#55FF55]{fkdr[3]}[/]")
            .Append($"[#55FFFF]{fkdr[4]}[/]")
            .Append($"[#AA00AA]{fkdr[5..]}[/]");

        return builder.ToString();
    }
    #endregion

    #region WLR
    public static String ColorizeWLR(Single wlr)
    {
        String representation = wlr.ToString("F2", CultureInfo.InvariantCulture);
        return wlr switch
        {
            Single when wlr <= 0.5 => $"[#AAAAAA]{representation}[/]",
            Single when wlr <= 1.0 => $"[#FFFFFF]{representation}[/]",
            Single when wlr <= 3.0 => $"[#F7FF33]{representation}[/]",
            Single when wlr <= 5.0 => $"[#55FFFF]{representation}[/]",
            Single when wlr <= 10.0 => $"[#800000]{representation}[/]",
            Single when wlr <= 50.0 => $"[#FFAEED]{representation}[/]",
            Single when wlr < 100.0 => $"[#6100B8]{representation}[/]",
            _ => ColorizeRainbowWLR(representation)
        };
    }

    public static String ColorizeRainbowWLR(String wlr)
    {
        StringBuilder builder = new($"[#FF5555]{wlr[0]}[/]");
        builder.Append($"[#FFAA00]{wlr[1]}[/]")
            .Append($"[#FFFF55]{wlr[2]}[/]")
            .Append($"[#55FF55]{wlr[3]}[/]")
            .Append($"[#55FFFF]{wlr[4]}[/]")
            .Append($"[#AA00AA]{wlr[5..]}[/]");

        return builder.ToString();
    }
    #endregion
}
