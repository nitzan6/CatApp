using UnityEngine;

public class CatDataHandler : MonoBehaviour
{
    [SerializeField]
    private NameDataHandler _nameDataHandler;
    [SerializeField]
    private DescriptionDataHandler _descriptionDataHandler;
    [SerializeField]
    private ImageDataHandler _colorDataHandler;
    [SerializeField]
    private ImageDataHandler _catImageDataHandler;
    [SerializeField]
    private EnabledDataHandler _enableDataHandler;

    public void ApplyData(Cat catData)
    {
        _nameDataHandler.SetText(catData.name);
        _descriptionDataHandler.SetText(catData.description);
        _colorDataHandler.SetColor(catData.color);
        _catImageDataHandler.SetImage(catData.qr_code);
        _enableDataHandler.SetBooleanValue(catData.enable);
    }
}
