using System.Collections.Generic;

public class StackOfStrings
{
    List<string> data = new List<string>();

    public void Push(string newItem)
    {
        data.Add(newItem);
    }

    public string Pop()
    {
        var result = string.Empty;
        if (!IsEmpty())
        {
            var lastItem = data.Count - 1;
            result = data[lastItem];
            data.RemoveAt(lastItem);
        }
        return result;
    }

    public string Peek()
    {
        var result = string.Empty;
        if (!IsEmpty())
        {
            result = data[data.Count - 1];
        }
        return result;
    }

    private bool IsEmpty()
    {
        return data.Count == 0;
    }
}
