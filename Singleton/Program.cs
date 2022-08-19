using Singleton;

Console.Title = "Singleton";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
    Console.WriteLine("Same instance");

instance1.Log("Logging from instance1");
instance2.Log("Logging from instance2");

Console.ReadKey();