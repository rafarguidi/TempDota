// See https://aka.ms/new-console-template for more information

using TimerSpanDT.Interfaces;
using TimerSpanDT.Runes;

internal class Program
{
    private static DateTime _startTime;
    static void Main()
    {
        _startTime = DateTime.Now;
        CreateTimer(new GoldRune());
        CreateTimer(new ExperienceRune());
        CreateTimer(new PowerRune());
        CreateTimer(new WaterRune());
        
        Console.Write("Press any key to exit... ");
        Console.ReadKey();
    }

    private static async Task CreateTimer(IRune rune)
    {
        var interval = TimeSpan.FromSeconds(rune.GetInterval());
        var timer = new System.Timers.Timer(interval);

        timer.Elapsed += async (sender, e) =>
        {
            var executionTime = DateTime.Now - _startTime;

            if (NotStartToAppear(rune, executionTime))
                return;

            if (NoLongerAppears(rune, executionTime))
                timer.Stop();

            await rune.MessageNotification();
            Console.WriteLine($"{executionTime.Minutes}:{executionTime.Seconds:00}");
            Console.ReadLine();
        };

        timer.Start();
    }

    private static bool NotStartToAppear(IRune rune, TimeSpan executionTime)
        => executionTime < TimeSpan.FromSeconds(rune.StartToAppear());

    private static bool NoLongerAppears(IRune rune, TimeSpan executionTime)
        => rune.EndToAppear() != null && executionTime >= TimeSpan.FromSeconds(rune.EndToAppear()!.Value);
}