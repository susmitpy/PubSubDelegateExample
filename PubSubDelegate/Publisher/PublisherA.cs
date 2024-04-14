using Models;

namespace NumPublisher {
    public class PublisherA : Publisher
    {
        public static void LoopNums()
        {
            for (int i = 1; i <= 5; i++)
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

