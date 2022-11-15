using UnityEngine;
using UnityEngine.UI;

public class InputFieldDataHandler : MonoBehaviour
{
    [SerializeField]
    InputField _inputField;

    public void SetText(string text)
    {
        _inputField.text = text;
    }
}
