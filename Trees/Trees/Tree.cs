public abstract class Tree
{
    protected int height = 0;
    protected int resources = 0;

    protected int grow_rate;
    protected int feed_rate;

    private System.Timers.Timer grow_timer = new System.Timers.Timer();
    private System.Timers.Timer eat_timer = new System.Timers.Timer();

    private void SetTimer(ref System.Timers.Timer timer, int period, System.Timers.ElapsedEventHandler handler)
    {
        timer = new System.Timers.Timer(period);
        timer.AutoReset = true;
        timer.Elapsed += handler;
    }
    public Tree()
    {
        SetTimer(ref grow_timer, 500, Grow);
        SetTimer(ref eat_timer, 1000, Eat);
        Sun.Instance.SunStatusChanged += this.CanGrow;
    }
    private void CanGrow(bool isDay) {
        if(isDay)
        {
            eat_timer.Stop();
            grow_timer.Start();
        }
        else
        {
            eat_timer.Start();
            grow_timer.Stop();
        }
    }

    protected void Grow(Object? obj, EventArgs e)
    {
        height += grow_rate;
        Console.WriteLine("Grow " + height);
    }
    protected void Eat(Object? obj, EventArgs e)
    {
        int consumpt = feed_rate * (height / 10 + 1);
        if (Soil.Instance.extractResource(consumpt))
            resources += consumpt;
        Console.WriteLine("Eat " + resources);
    }
}