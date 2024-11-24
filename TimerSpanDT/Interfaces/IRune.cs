namespace TimerSpanDT.Interfaces;

public interface IRune
{
    public int GetInterval();
    public int StartToAppear();
    public int? EndToAppear();
    public Task MessageNotification();
}
