using UnityEngine;
using UnityEngine.UI;

public class DescriptionDataHandler : MonoBehaviour
{
    [SerializeField]
    InputField _descriptionBox;

    public void SetText(string text)
    {
        _descriptionBox.text = text;
    }
}
