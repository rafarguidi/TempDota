using TimerSpanDT.Interfaces;

namespace TimerSpanDT.Runes;

public class WaterRune : IRune
{
    public int GetInterval() => 2;
    public int StartToAppear() => 0;
    public int? EndToAppear() => 4;

    public async Task MessageNotification()
    {
        Console.WriteLine("Runa de Água vai aparecer!");
    }
}
