

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

static int AddWrapper(int x, int y)
{
    return Add();

    int Add()
    {
        return x + y;
    }
}

#nullable enable
static void Process(string?[] lines, string mark)
{
    foreach (var line in lines)
    {
        if (IsValid(line))
        {
            // Processing logic
        }
    }

    bool IsValid([NotNullWhen(true)] string? line)
    {
        return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
    }
}

// The local function here will alter the parent method's variables
static int AddWrapperWithSideEffect(int x, int y)
{
    // Do some validation here
    return Add();

    int Add()
    {
        x += 1;
        return x + y;
    }
}

// The static will prevent parent variable modification
static int AddWrapperWithStatic(int x, int y)
{
    // Do some validation here
    return Add(x, y);

    static int Add(int x, int y)
    {
        return x + y;
    }
}


