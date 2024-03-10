using System.Runtime.CompilerServices;

public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and unique priority: Will (1), Michaela (3), Sue (2) and Tim (4)
        // run until the queue is empty
        // Expected Result: Will, Sue, Michaela, Tim
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Will", 3);
        priorityQueue.Enqueue("Michaela", 1);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("Tim", 4);
        //Console.WriteLine(priorityQueue);    // This can be un-commented out for debug help

        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());

        // Defect(s) Found: The dequeue function is only displaying the 3rd priority item

        Console.WriteLine("---------");

        // Test 2
        var priorityQueue2 = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Scenario: Test adding multiple names with equal priorities to make sure that functionality works with 
        // the following names/priorities: Will(1), Tallon(4), Michaela(1), Sam(2), Randy(3), Kayla(3), Mike(4)
        // Expected Result: Will, Michaela, Sam, Randy, Kayla, Tallon, Mike
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Will", 1);
        priorityQueue.Enqueue("Tallon", 4);
        priorityQueue.Enqueue("Michaela", 1);
        priorityQueue.Enqueue("Sam", 2);
        priorityQueue.Enqueue("Randy", 3);
        priorityQueue.Enqueue("Kayla", 3);
        priorityQueue.Enqueue("Mike", 4);

        //Console.WriteLine(priorityQueue);    // This can be un-commented out for debug help

        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());
        Console.WriteLine(priorityQueue.Dequeue().ToString());

        // Defect(s) Found: The dequeue function is returing higher priorities first

        Console.WriteLine("---------");

        // Test 3
        var priorityQueue3 = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 2");

        //Console.WriteLine(priorityQueue);    // This can be un-commented out for debug help

        Console.WriteLine(priorityQueue.Dequeue().ToString());

        // Defect(s) Found: The dequeue function is returing higher priorities first

        Console.WriteLine("---------");
    }
}