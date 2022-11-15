using UnityEngine;

public class CatDataHandler : MonoBehaviour
{
    [SerializeField]
    private TextDataHandler _nameDataHandler;
    [SerializeField]
    private TextDataHandler _descriptionDataHandler;
    [SerializeField]
    private ImageDataHandler _colorDataHandler;
    [SerializeField]
    private ImageDataHandler _catImageDataHandler;

    public void ApplyData(Cat catData)
    {
        _nameDataHandler.SetText(catData.name);
        _descriptionDataHandler.SetText(catData.description);
        _colorDataHandler.SetColor(catData.color);
        _catImageDataHandler.SetImage(catData.qr_code);
    }
}
