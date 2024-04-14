namespace NumConsumer
{
    interface INumConsumer
    {
        abstract public static void OnEvenNumReceived(int num);
        abstract public static void OnOddNumReceived(int num);
    }
}