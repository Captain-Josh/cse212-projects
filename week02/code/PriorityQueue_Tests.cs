using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities.
    // Expected Result: Item with highest priority is returned.
    // Defect(s) Found: Last item in queue is not checked when searching for highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",1);
        priorityQueue.Enqueue("B",2);
        priorityQueue.Enqueue("C",6);
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Remove highest priority item and dequeue again.
    // Expected Result: Removed item should not be returned a second time.
    // Defect(s) Found: Dequeued item is not removed from queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",8);
        priorityQueue.Enqueue("B",6);
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());

    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Multiple items have the same priority.
    // Expected Result: Items are dequeued in FIFO order.
    // Defect(s) Found: None
      public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",8);
        priorityQueue.Enqueue("B",8);
        priorityQueue.Enqueue("C",8);
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    [TestMethod]
    //// Scenario: Attempt to dequeue from an empty queue
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found: None
    
    [ExpectedException(typeof(InvalidOperationException))]
      public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
          
        priorityQueue.Dequeue();       
        
    }
}