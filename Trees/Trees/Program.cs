public class Program
{
    public static void Main(string[] args)
    {
        Tree t1 = new Oak();
        Tree t2 = new AppleTree();
        Tree t3 = new Birch();
        Sun.Instance.SetTimer(2000);
        Console.ReadLine();
    }
    
}