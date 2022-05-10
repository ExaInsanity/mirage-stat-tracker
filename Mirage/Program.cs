namespace Mirage;

using System;
using System.Text;

using Spectre.Console;

public static class Program
{
    public static Int32 Main(String[] argv)
    {
        Console.OutputEncoding = Encoding.Unicode;

        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(0.2f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(0.72f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(0.917f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(1.91f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(2.86f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(4.2f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(5.723f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(33.24f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(78.23f));
        AnsiConsole.MarkupLine(Colorizer.ColorizeFKDR(101.0f));

        return 0;
    }
}
