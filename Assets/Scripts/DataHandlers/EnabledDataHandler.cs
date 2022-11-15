using UnityEngine;
using UnityEngine.UI;

public class EnabledDataHandler : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private Sprite _onSprite;
    [SerializeField]
    private Sprite _offSprite;

    public void SetBooleanValue(bool value)
    {
        if (value)
        {
            _image.sprite = _onSprite;
        }
        else
        {
            _image.sprite = _offSprite;
        }
    }

    public void ToggleBooleanValue()
    {
        if (_image.sprite == _onSprite)
        {
            _image.sprite = _offSprite;
        }
        else
        {
            _image.sprite = _onSprite;
        }
    }
}
