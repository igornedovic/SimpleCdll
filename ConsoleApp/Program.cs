using Wrapper;
public class Program
{
    public static void Main(string[] args)
    {
        for (uint i = 1; i <= 10; i++)
        {
            ConnectSessionWrapper.SetConnectSession(i);
        }

        Console.ReadKey();
}
}