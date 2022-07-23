using Design_Pattern___Observer;

// Create the publisher
Publisher publisher = new Publisher();

// Create some subscribers
Subscriber subscriber1 = new Subscriber();
Subscriber subscriber2 = new Subscriber();
Subscriber subscriber3 = new Subscriber();

// Test
publisher.Register(subscriber1);
publisher.Register(subscriber2);

publisher.Price = 100;

publisher.Register(subscriber3);

publisher.Price = 200;

publisher.Unregister(subscriber2);

publisher.Price = 300;


// Force program to stay alive
Console.ReadLine();