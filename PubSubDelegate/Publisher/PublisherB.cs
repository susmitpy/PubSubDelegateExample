using Models;
namespace NumPublisher {
    public class PublisherB : Publisher
    {
        public static void LoopNums()
        {
            for (int i = 100; i <= 105; i++)
            {
                if (i % 2 == 0)
                {
                    Publish(NumEventType.EVEN, i);
                }
                else if (i % 2 == 1)
                {
                    Publish(NumEventType.ODD, i);
                }
            }
        }
    }
}

