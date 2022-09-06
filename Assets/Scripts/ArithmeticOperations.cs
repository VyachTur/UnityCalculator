using System;

public static class ArithmeticOperations
{
    public static float ReturnSolution(int operand1, int operand2, Operations operation)
    {
        switch (operation)
        {
            case Operations.Plus:
                return (float)operand1 + operand2;

            case Operations.Minus:
                return (float)operand1 - operand2;

            case Operations.Multiply:
                return (float)operand1 * operand2;

            case Operations.Divide:
                return operand1 / operand2;

        default:
                throw new ArithmeticException("Недопустимая операция!");
        }
    }
}
