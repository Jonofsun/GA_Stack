# Guided Assignment - Stack Using Singly Linked List

## Introduction

**What is a Stack:** A stack is a linear data structure that follows the Last In, First Out (LIFO) principle. This means that the last element added to the stack will be the first one to be removed.

**Why is it Important:** Stacks are fundamental in computer science and are used in various applications like undo mechanisms in text editors, function call management in programming languages, and algorithmic problem solving.

**Differences from Singly Linked List:**
1. **Operation Order:** A stack restricts insertion and deletion to one end, often called the top, while a singly linked list allows insertion and deletion at both ends.
2. **Functionality:** A stack provides only two primary operations: `push` (add) and `pop` (remove), while a singly linked list offers more flexible operations.

**Pros of Stacks:**
1. **Simplicity:** Easy to implement and use.
2. **Efficient Operations:** Adding and removing elements is done in constant time.
3. **Controlled Access:** Restricts direct access to elements, preventing accidental modifications.

**Cons of Stacks:**
1. **Limited Functionality:** Provides less flexibility compared to other data structures.
2. **Potential for Overflow:** Limited by the amount of memory allocated if implemented using an array.

***Real World Examples***

1. **Undo Mechanism:** In text editors, where the last action can be reversed.
2. **Function Calls:** In programming, managing return addresses of function calls.
3. **Expression Evaluation:** In compilers and calculators for evaluating expressions.
4. **Backtracking Algorithms:** In solving puzzles, pathfinding, and algorithmic problems.

---

## Requirements

**Project Setup:**
1. Create a new C# project named "GA_Stack_SinglyLinkedList_YourName."
2. Include your name and the current date as comments in the main class or file.

**Stack Implementation:**
3. Implement a generic stack class named `Stack<T>` using a singly linked list.
4. Include a nested class `StackNode<T>` for individual nodes.

**Fields and Properties:**
5. Include a field for `top`.
6. Implement a public property `Count` for accessing the number of elements.

**Constructor:**
7. Create a constructor to initialize `top` to null and `count` to zero.

**Core Methods:**
8. Implement core methods:
   - `Push(T value)` - Adds elements to the top.
   - `Pop()` - Removes and returns the element from the top.
   - `Peek()` - Returns the element at the top without removing it.

**Additional Methods:**
9. Implement the `Clear` method to empty the stack.

**Testing:**
10. Test your `Stack` class in a separate program or class.
11. Include test cases for all functionalities, ensuring correct implementation.

**Readme File:**
12. In your README, address the following:
    - Explanation of a stack and its utility.
    - Differences between a stack and a singly linked list.
    - Discuss scenarios where a stack is preferable over other data structures.
    - Considerations for choosing between a stack and other data structures.
    - Thoughts on implementing a stack using different approaches (array vs. linked list).

Ensure thorough documentation and a clear explanation in your README.

---

## Start By Creating a Stack Class

1. Make it generic.
2. Name it `Stack`.

```csharp
using System; // Import the System namespace for basic functionalities.

// Define a generic class called Stack.
// The 'T' here is a type parameter that allows this class to work with various data types.
class Stack<T>
{

}
```

---

### Create a Nested Node Class

A stack node in a singly linked list has a reference to the next node, allowing you to move forward through the stack.

```csharp
class Stack<T>
{
    // Nested class StackNode representing elements in the stack.
    class StackNode<T>
    {
        public T Value { get; set; }                    // Data stored in the node.
        public StackNode<T> Next { get; set; }          // Reference to the next node.

        public StackNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
```

***What is a Stack Node***

A stack node is an essential component of a stack, particularly when implemented using a linked list. It contains:
1. Data element storage.
2. A pointer or reference to the next node.
3. Support for stack operations like push and pop.

---

### Fields, Property, and Constructor for your Stack

Add the following code

```csharp
class Stack<T>
{
    // Private field to track the top element of the stack.
    private StackNode<T> top;
    private int count;

    // Public property to access the count of elements.
    public int Count
    {


        get { return count; }
    }

    // Constructor to initialize an empty stack.
    public Stack()
    {
        top = null;
        count = 0;
    }
}
```

Explanation with comments:

- `private StackNode<T> top;`: This private field holds a reference to the top node in the stack.

- `private int count;`: This private field keeps track of the number of elements in the stack.

- `public int Count`: This public property allows external code to access the count of elements in the stack.

- `public Stack()`: This is the constructor of the `Stack` class. It initializes an empty stack.

**Explanation for `top`:**

The `top` reference is crucial in a stack, as it points to the most recently added element. This allows for efficient `push` and `pop` operations, as they only involve handling the top element without needing to traverse the entire structure.

---

## Push Method

```csharp
public void Push(T value)
{
    StackNode<T> newNode = new StackNode<T>(value);
    newNode.Next = top;
    top = newNode;
    count++;
}
```

Explanation:

1. Creates a new node with the given value.
2. Sets its next reference to the current top.
3. Updates the top to be the new node.
4. Increments the count.

---

### Pop Method

```csharp
public T Pop()
{
    if (top == null)
        throw new InvalidOperationException("Stack is empty.");

    T value = top.Value;
    top = top.Next;
    count--;
    return value;
}
```

Explanation:

1. Checks if the stack is empty.
2. Retrieves the value of the top element.
3. Updates the top to the next node.
4. Decreases the count and returns the value.

---

### Peek Method

```csharp
public T Peek()
{
    if (top == null)
        throw new InvalidOperationException("Stack is empty.");

    return top.Value;
}
```

Explanation:

1. Checks if the stack is empty.
2. Returns the value of the top element without removing it.

---

### Clear Method

```csharp
public void Clear()
{
    top = null;
    count = 0;
}
```

Explanation:

1. Resets the top to null.
2. Resets the count to zero.

---

### Test the Code

```csharp
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        // Push elements
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Pop an element
        Console.WriteLine($"Popped: {stack.Pop()}");

        // Peek at the top element
        Console.WriteLine($"Top element: {stack.Peek()}");

        // Display count
        Console.WriteLine($"Count: {stack.Count}");

        Console.ReadLine();
    }
}
```

---

## Rubric

| Name                | Description                                                       | Points |
|---------------------|-------------------------------------------------------------------|--------|
| Project Setup       | C# project creation with correct naming and comments.              | 5      |
| Stack Implementation | Implementation of the generic stack class using a singly linked list. | 15     |
| StackNode           | Nested `StackNode` class implementation.                          | 5      |
| Fields & Properties | Proper implementation of fields and property.                     | 5      |
| Constructor         | Constructor implementation for `Stack`.                           | 5      |
| Core Methods        | Core methods (Push, Pop, Peek) implementation.                    | 15     |
| Clear Method        | Implementation of the `Clear` method.                             | 5      |
| Testing             | Comprehensive testing program with diverse cases.                 | 10     |
| Code Compilation    | Error-free code compilation.                                      | 5      |
| Readme              | Detailed README with explanations and answers.                    | 10     |
| Total               |                                                                   | 80     |

