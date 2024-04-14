using Models;

namespace NumPublisher {
    abstract public class Publisher {
        protected static void Publish(NumEventType eventType, int num){
            Events.RaiseNumEvent(eventType, num);
        }
    }
}