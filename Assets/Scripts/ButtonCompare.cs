using TMPro;
using UnityEngine;

public class ButtonCompare : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputCmp1TMP;
    [SerializeField] private TMP_InputField _inputCmp2TMP;
    [SerializeField] private TMP_Text _compareViewTMP;
    [SerializeField] private TMP_Text _textResultTMP;

    public void DoCompare()
    {
        _compareViewTMP.text = "?";

        int operand1;
        int operand2;

        int.TryParse(_inputCmp1TMP.text, out operand1);
        int.TryParse(_inputCmp2TMP.text, out operand2);

        if (operand1 > operand2)
        {
            _compareViewTMP.text = ">";
            _textResultTMP.text = $"Первое число больше второго на {operand1 - operand2}";
        }
        else if(operand1 < operand2)
        {
            _compareViewTMP.text = "<";
            _textResultTMP.text = $"Первое число меньше второго на {operand2 - operand1}";
        }
        else
        {
            _compareViewTMP.text = "=";
            _textResultTMP.text = $"Числа равны";
        }
    }
}
