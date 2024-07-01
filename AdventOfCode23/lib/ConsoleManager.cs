using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventOfCode23.lib
{
    public class ConsoleManager
    {

        private static ConsoleManager? instance;

        private ConsoleManager() { }

        public static ConsoleManager GetInstance()
        {
            instance ??= new ConsoleManager();
            return instance;
        }

        public void DrawStartScreen()
        {
            AnsiConsole.Write(
                new FigletText("Advent of Code")
                .Centered()
                .Color(Color.Red));

            AnsiConsole.Write(
                new FigletText("2023")
                .Centered()
                .Color(Color.Red));

            AnsiConsole.Write(
                new Markup("[bold yellow]By bbfodor.[/]\n")
                .Centered());

            AnsiConsole.Write(
                new Markup("[italic yellow link]https://github.com/bbfodor/AdventOfCode23[/]\n\n")
                .Centered());
        }

        public string HandleStartPrompt() =>
            AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .AddChoices([
                        "[white]Solve All Days[/]",
                        "[white]Specific Days[/]",
                        "[white]Exit[/]"])
                    .HighlightStyle(new Style(foreground: Color.Green)));

        public IEnumerable<string> HandleDaysPrompt() =>
            AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                    .AddChoices([
                        "Day 1", "Day 2", "Day 3",
                        "Day 4", "Day 5", "Day 6",
                        "Day 7", "Day 8", "Day 9",
                        "Day 10", "Day 11", "Day 12",
                        "Day 13", "Day 14"]));

        public void WriteLine(string text) => AnsiConsole.WriteLine(text);

        public void Clear() => AnsiConsole.Clear();
    }
}
