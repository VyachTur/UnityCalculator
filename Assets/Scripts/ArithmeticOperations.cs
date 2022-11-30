using System;

public static class ArithmeticOperations
{
    public static float ReturnSolution(float operand1, float operand2, Operations operation)
    {
        switch (operation)
        {
            case Operations.Plus:
                return operand1 + operand2;

            case Operations.Minus:
                return operand1 - operand2;

            case Operations.Multiply:
                return operand1 * operand2;

            case Operations.Divide:
                return operand1 / operand2;

        default:
                throw new ArithmeticException("Недопустимая операция!");
        }
    }
}
