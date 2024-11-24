using TimerSpanDT.Interfaces;

namespace TimerSpanDT.Runes;

public class ExperienceRune : IRune
{
    public int GetInterval() => 7;
    public int StartToAppear() => 7;
    public int? EndToAppear() => null;

    public async Task MessageNotification()
    {
        Console.WriteLine("Runa de XP vai aparecer!");
    }
}
