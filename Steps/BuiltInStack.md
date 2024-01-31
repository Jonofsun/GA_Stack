# Stack - Built In

- Creating a new stack
- Push()
- Display()
- Pop()
- Peek()
- IsEmpty()

## Creating a Stack Object

Creating a new stack using the built-in `Stack` class in C# is a straightforward process. Here's a simple code snippet that demonstrates how to create a new stack:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers
        Stack<int> myStack = new Stack<int>();

        // The 'myStack' variable now holds an empty stack of integers
    }
}
```

In this code:

1. We include the necessary using directives at the top of the file to access the `Stack` class and related functionality.

2. We create a new instance of the `Stack<int>` class, specifying that it will store integers. This line initializes an empty stack and assigns it to the `myStack` variable.

After running this code, you'll have a new stack (`myStack`) ready to be used to store and manage integer elements using stack operations like `Push`, `Pop`, `Peek`, and others.

---

## Push() - Adding an object to the stack

Certainly! Here's an example of how to create a new stack and use the `Push` method to add elements to the stack:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers
        Stack<int> myStack = new Stack<int>();

        // Push elements onto the stack
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        // At this point, the stack 'myStack' contains the elements: 1, 2, and 3
    }
}
```

In this code:

1. We create a new instance of the `Stack<int>` class as before, initializing it with an empty stack of integers.

2. We use the `Push` method to add integers (1, 2, and 3) onto the stack. Each call to `Push` adds an element to the top of the stack, following the Last-In-First-Out (LIFO) principle.

After executing this code, the stack `myStack` will contain the elements 1, 2, and 3 in that order, with 3 at the top of the stack. You can continue to use the stack for further operations like popping, peeking, and more.

---

## Pop() - Getting an element OFF the stack

The `Pop` operation is an essential operation in stack data structures, and it's used to remove and retrieve the top element from the stack. In a stack, elements are stored in a Last-In-First-Out (LIFO) order, meaning that the most recently added element (the top element) is the first one to be removed when you perform a `Pop` operation.

Here's how the `Pop` operation works:

1. **Access the Top Element:** The `Pop` operation first accesses the top element of the stack, which is the element at the top of the stack's internal storage.

2. **Remove the Top Element:** After accessing the top element, the `Pop` operation removes it from the stack. This means that the stack's size decreases by one, and the element is no longer in the stack.

3. **Return the Removed Element:** The removed element is typically returned as the result of the `Pop` operation. This allows you to use or process the removed element as needed.

Here's an example of how to use the `Pop` operation in C# with a stack:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers and push elements onto it
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        // Perform a Pop operation to remove and retrieve the top element
        int poppedItem = myStack.Pop();

        // Display the removed element
        Console.WriteLine("Popped element: " + poppedItem); // Output: Popped element: 3

        // The stack now contains the elements 1 and 2
    }
}
```

In this code:

- We create a stack and push elements onto it.
- We perform a `Pop` operation to remove and retrieve the top element (which is 3 in this case).
- We display the removed element.

Keep in mind that it's essential to check if the stack is empty before performing a `Pop` operation to avoid exceptions when attempting to pop from an empty stack. The `IsEmpty` property or `Count` property can be used to perform this check.

---

## Displaying Elements from a stack

To display elements from a stack in C#, you can use a loop (e.g., `foreach`) to iterate through the stack's elements and print them out. Since stacks follow the Last-In-First-Out (LIFO) principle, elements will be retrieved in reverse order, starting from the top of the stack. Here's an example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers and push elements onto it
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        // Display elements from the stack
        Console.WriteLine("Elements in the stack:");
        foreach (int item in myStack)
        {
            Console.WriteLine(item);
        }

        // Output:
        // Elements in the stack:
        // 3
        // 2
        // 1
    }
}
```

---

## Peek() - Viewing the 2nd element

The `Peek` method is used to examine the top element of a stack without removing it. It allows you to access the value of the element at the top of the stack without modifying the stack's structure. The `Peek` operation is useful when you want to check the top element's value before deciding whether to pop it or perform other operations based on its value.

Here's how you can use the `Peek` method in C# with a stack:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers and push elements onto it
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        // Use the Peek method to examine the top element without removing it
        int topElement = myStack.Peek();

        // Display the top element
        Console.WriteLine("Top element: " + topElement); // Output: Top element: 3

        // The stack still contains the elements: 1, 2, and 3
    }
}
```

In this example:

- We create a stack and push elements onto it.

- We use the `Peek` method to examine the top element, which is 3 in this case.

- We display the top element's value using `Console.WriteLine`.

After using the `Peek` method, the stack remains unchanged, and you can continue to work with its elements as needed. It's a useful operation when you want to inspect the top element without altering the stack's contents.

---

## IsEmpty

The `IsEmpty` property is used to check if a stack is empty, meaning it contains no elements. It is commonly used to determine whether it is safe to perform pop or peek operations on the stack without running into exceptions. Here's how you can use the `IsEmpty` property in C# with a stack:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new stack of integers
        Stack<int> myStack = new Stack<int>();

        // Check if the stack is empty
        bool isEmpty = myStack.Count == 0; // You can also use myStack.Count == 0 or myStack.Count == 0

        Console.WriteLine("Is the stack empty? " + isEmpty); // Output: Is the stack empty? True

        // Push elements onto the stack
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        // Check if the stack is empty again
        isEmpty = myStack.Count == 0;

        Console.WriteLine("Is the stack empty now? " + isEmpty); // Output: Is the stack empty now? False
    }
}
```

In this example:

- We create an empty stack and use the `IsEmpty` property to check if it's empty initially. Since there are no elements, it returns `true`, indicating that the stack is empty.

- After pushing elements onto the stack, we check the `IsEmpty` property again, and this time it returns `false`, indicating that the stack is no longer empty.

Using the `IsEmpty` property is a convenient way to determine whether a stack has any elements before performing operations that require elements to be present.

---

## IsFull()



## Pop

In this code:

1. We create a new stack of integers (`myStack`) and push elements onto it.

2. To display the elements, we use a `foreach` loop, which iterates through the stack from top to bottom, printing each element as it goes.

Running this code will display the elements from the stack in the reverse order of insertion, as stacks retrieve elements in a Last-In-First-Out (LIFO) manner.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> myStack = new Stack<int>(5);

        Console.WriteLine("Is the stack empty? " + myStack.IsEmpty); // Output: True

        // Push elements onto the stack
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Console.WriteLine("Is the stack empty? " + myStack.IsEmpty); // Output: False
        Console.WriteLine("Is the stack full? " + (myStack.Count == myStack.Capacity)); // Output: False

        // Peek at the top element without removing it
        Console.WriteLine("Top element: " + myStack.Peek()); // Output: 3

        // Pop elements from the stack and display them
        Console.WriteLine("Popped elements:");
        while (myStack.Count > 0)
        {
            int poppedItem = myStack.Pop();
            Console.WriteLine(poppedItem);
        }

        Console.WriteLine("Is the stack empty? " + myStack.IsEmpty); // Output: True

        // Try to pop from an empty stack (this will throw an exception)
        // int invalidPop = myStack.Pop(); // Uncomment this line to see the exception

        // Push more elements onto the stack
        myStack.Push(4);
        myStack.Push(5);

        Console.WriteLine("Is the stack full? " + (myStack.Count == myStack.Capacity)); // Output: False

        // Display the elements in the stack
        Console.WriteLine("Elements in the stack:");
        foreach (int item in myStack)
        {
            Console.WriteLine(item);
        }
    }
}
```

In this demonstration:

- We first check if the stack is empty using `IsEmpty`, and it initially returns `true` because we haven't pushed any elements yet.

- We push elements onto the stack using `Push`.

- We check if the stack is empty again, and it returns `false`.

- We also check if the stack is full, although in this case, the capacity of the stack is 5, and we haven't reached that limit.

- We use `Peek` to look at the top element without removing it.

- We then use a loop to `Pop` elements from the stack and display them.

- After popping all elements, we check if the stack is empty again (which it should be).

- We demonstrate that attempting to `Pop` from an empty stack will throw an exception (uncomment the line to see the exception).

- We push more elements onto the stack and display the elements using a loop.

This extended demonstration should give you a better understanding of how to use the `Stack` class and its methods in C#.