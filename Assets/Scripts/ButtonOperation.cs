using TMPro;
using UnityEngine;

public class ButtonOperation : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputOp1TMP;
    [SerializeField] private TMP_InputField _inputOp2TMP;
    [SerializeField] private TMP_Text _operationViewTMP;
    [SerializeField] private TMP_Text _textResultTMP;
    [SerializeField] private Operations _operation;

    public void DoOperation()
    {
        float operand1;
        float operand2;
        float result;

        float.TryParse(_inputOp1TMP.text, out operand1);
        float.TryParse(_inputOp2TMP.text, out operand2);


        _operationViewTMP.text = ReturnOperationName(_operation);

        try
        {
            result = ArithmeticOperations.ReturnSolution(operand1, operand2, _operation);
        }
        catch
        {
            _textResultTMP.text = "infinity";
            return;
        }

        _textResultTMP.text = result.ToString();
    }

    private string ReturnOperationName(Operations operation) => operation switch
    {
        Operations.Plus => "+",
        Operations.Minus => "-",
        Operations.Multiply => "*",
        Operations.Divide => "/",
        _ => "?",
    };
}
