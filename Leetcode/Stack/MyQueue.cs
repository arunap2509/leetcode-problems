namespace Leetcode.Stack;

public class MyQueue
{
    private readonly Stack<int> stackOne;
    private readonly Stack<int> stackTwo;

    public MyQueue()
    {
        stackOne = new();
        stackTwo = new();
    }

    public void Push(int x)
    {
        stackOne.Push(x);
    }

    public int Pop()
    {
        Peek();

        return stackTwo.Pop();
    }

    public int Peek()
    {
        if (stackTwo.Count == 0)
        {
            while (stackOne.Count != 0)
            {
                stackTwo.Push(stackOne.Pop());
            }
        }

        return stackTwo.Peek();
    }

    public bool Empty()
    {
        return stackOne.Count == 0 && stackTwo.Count == 0;
    }
}

