using NumConsumer;
using NumPublisher;
using Models;

namespace App {
    static class Program {
        static void PubSub(){
            Events.EvenNum += ConsumerA.OnEvenNumReceived;
            Events.OddNum += ConsumerA.OnOddNumReceived;

            Events.EvenNum += ConsumerB.OnEvenNumReceived;
            Events.OddNum += ConsumerB.OnOddNumReceived;

            PublisherA.LoopNums();
            PublisherB.LoopNums();
        }
        static void Main(){
            PubSub();
        }
    }
}