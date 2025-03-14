public class Soil
{
    private Soil() { }
    public static Soil Instance { get; } = new Soil();
    private int res = 1000;
    public bool extractResource (int feed_rate) { 
        if (res >= feed_rate) {
            res -= feed_rate;
            return true;
        }
        return false;
    }
}