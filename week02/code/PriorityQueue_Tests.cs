using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three names with differen priorities, then deque them all
    // Expected Result: Items are dequed in order of the highest to the lowest priority
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Ntombi", 1);
        priorityQueue.Enqueue("Atli", 2);
        priorityQueue.Enqueue("Atle", 3);
        Assert.AreEqual("Atle", priorityQueue.Dequeue());
        Assert.AreEqual("Atli", priorityQueue.Dequeue());
        Assert.AreEqual("Ntombi", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Enque two items with the same highest  priorities, then dequeue both. 
    // Expected Result: The first enque item with the highest priority is dequed first.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Ntombi", 5);
        priorityQueue.Enqueue("Atli", 5);
        Assert.AreEqual("Ntombi", priorityQueue.Dequeue());
        Assert.AreEqual("Atli", priorityQueue.Dequeue());   
    }

    // Add more test cases as needed below.
}