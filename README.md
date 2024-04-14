# Pub Sub Delegate Example

This example demonstrates a way of using delegates involving multiple publishers and subscribers (consumers). The example revolves around a simple event system where there is NumEvent of two types: Even num and Odd num. Publishers loop over a range of numbers and publish events to the event system. Consumers subscribe to the event system and are notified when an event is published. The example demonstrates how to use delegates to implement the event system.

## Overview
### Events
An event is a message which is published by a publisher. Consumers subscribe to events and are notified when an event is published. We define the events in `Events.cs` as opposed to defining them in publisher clas because the purpose of pub sub system is that the publisher and subscriber are decoupled. The publisher does not need to know about the subscriber and vice versa. As the events defined can only be invoked from within the class that defines them, we define a simple `RaiseNumEvent` method to invoke the appropriate event based on the `NumEventType` enum.

### Publisher
We have two Publishers in this example. `PublisherA` and `PublisherB`. Both of them inherit from an abstract class `Publisher` which defines a `Publish` method. The inherited classes can simply use this method to publish events.

### Consumer
We have two Consumers in this example. `ConsumerA` and `ConsumerB`. Both of them inherit from an interface `INumConsumer` which declares two methods `OnEvenNumRecived` and `OnOddNumRecived`. The consumers implement these methods to handle the processing of events. We have used an interface and not an abstract class as there is no common implementation among the consumers as opposed to the `Publish` method in the publishers.

### Program
The `Program` class is the entry point of the application. It creates instances of the publishers and consumers and subscribes the consumers to the event system via `+=`. It then starts the publishers to publish events.