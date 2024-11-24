using TimerSpanDT.Interfaces;

namespace TimerSpanDT.Runes;

public class GoldRune : IRune
{
    public int GetInterval() => 3;
    public int StartToAppear() => 0;
    public int? EndToAppear() => null;

    public async Task MessageNotification()
    {
        Console.WriteLine("Runa de Ouro vai aparecer!");
    }
}
