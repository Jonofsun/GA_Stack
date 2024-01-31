Sure, here's an example of a simple C# stack class implemented using an array:

```csharp
using System;

public class Stack<T>
{
    private T[] array;
    private int top;
    private int capacity;

    public Stack(int capacity)
    {
        if (capacity <= 0)
        {
            throw new ArgumentException("Capacity must be greater than zero.");
        }

        this.capacity = capacity;
        this.array = new T[capacity];
        this.top = -1;
    }

    public int Count
    {
        get { return top + 1; }
    }

    public bool IsEmpty
    {
        get { return top == -1; }
    }

    public bool IsFull
    {
        get { return top == capacity - 1; }
    }

    public void Push(T item)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("Stack is full.");
        }

        array[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T poppedItem = array[top];
        array[top--] = default(T); // Reset the value in the array
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return array[top];
    }

    public void Clear()
    {
        Array.Clear(array, 0, top + 1);
        top = -1;
    }
}
```

This `Stack` class is a generic class that allows you to create a stack of any data type. It uses an array to store the elements, and it includes methods for pushing, popping, peeking at the top element, checking if the stack is empty or full, and clearing the stack.

Here's how you can use this `Stack` class:

```csharp
Stack<int> myStack = new Stack<int>(5);
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

Console.WriteLine("Top element: " + myStack.Peek()); // Output: 3

while (!myStack.IsEmpty)
{
    Console.WriteLine("Popped element: " + myStack.Pop());
}

// Output:
// Popped element: 3
// Popped element: 2
// Popped element: 1
```

In this example, we create an integer stack with a capacity of 5, push some values onto the stack, peek at the top element, and then pop all the elements from the stack.