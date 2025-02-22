internal enum Operation
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal static class OperationSymbols
{
    private static readonly Dictionary<Operation, string> SymbolMap = new()
    {
        { Operation.Addition, "+" },
        { Operation.Subtraction, "-" },
        { Operation.Multiplication, "*" },
        { Operation.Division, "/" }
    };

    internal static string GetSymbol(Operation operation)
    {
        return SymbolMap[operation];
    }
}