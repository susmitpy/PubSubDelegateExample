namespace NumConsumer
{
public class ConsumerB : INumConsumer
    {
    public static void OnEvenNumReceived(int num){
        Console.WriteLine($"Consumer B: Received even num: {num}");
    }
    public static void OnOddNumReceived(int num){
        Console.WriteLine($"Consumer B: Received odd num: {num}");
    }
}

}