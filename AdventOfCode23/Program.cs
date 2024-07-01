using AdventOfCode23;
using AdventOfCode23.lib;

using static AdventOfCode23.utils.Utils;
using static AdventOfCode23.utils.Enums;


var console = ConsoleManager.GetInstance();
var executor = new SolutionExecutor();

while (true)
{
    console.DrawStartScreen();
    string selection = console.HandleStartPrompt();
    var menuSelection = GetEnumFromStr<MenuSelection>(selection);

    bool exited = false;

    switch (menuSelection)
    {
        case MenuSelection.SolveAllDays:
            executor.ExecuteAllSolutions();
            break;
        case MenuSelection.SpecificDays:
            var days = console.HandleDaysPrompt();
            var dayNums = TransformEnumerable(days, dayStr => GetIntFromStr(dayStr));
            executor.ExecuteSolutionsForSelectDays(dayNums.ToArray());
            break;
        case MenuSelection.Exit:
            exited = true;
            break;
        default:
            break;
    }
    if (exited) break;

    Console.WriteLine("Press any key to return to the home screen..");
    Console.ReadKey();
    console.Clear();
}
