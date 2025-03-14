public class Sun
{
    private Sun() { }
    public static Sun Instance { get; } = new Sun();

    private System.Timers.Timer timer;
    private bool status = false;
    public delegate void ChangeCheck(bool status);
    public event ChangeCheck SunStatusChanged;

    public void SetTimer(int period)
    {
        timer = new System.Timers.Timer(period);
        timer.AutoReset = true;
        timer.Start();
        timer.Elapsed += changeSunStatus;
    }

    private void changeSunStatus(Object? obj, EventArgs e)
    {
        status = !status;
        SunStatusChanged(status);
    }
}