namespace NumConsumer
{
    public class ConsumerA : INumConsumer
    {
        public static void OnEvenNumReceived(int num)
        {
            Console.WriteLine($"Consumer A: Received even num: {num}");
        }
        public static void OnOddNumReceived(int num)
        {
            Console.WriteLine($"Consumer A: Received odd num: {num}");
        }
    }
}

