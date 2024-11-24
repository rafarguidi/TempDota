using TimerSpanDT.Interfaces;

namespace TimerSpanDT.Runes;

public class PowerRune : IRune
{
    public int GetInterval() => 2;
    public int StartToAppear() => 6;
    public int? EndToAppear() => null;

    public async Task MessageNotification()
    {
        Console.WriteLine("Runa de Poder vai aparecer!");
    }
}