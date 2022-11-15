using System;
using UnityEngine;
using UnityEngine.UI;

public class ImageDataHandler : MonoBehaviour
{
    [SerializeField]
    private Image _image;


    public void SetColor(string colorHex)
    {
        ColorUtility.TryParseHtmlString("#" + colorHex, out Color newColor);   
        _image.color = newColor;
    }

    public void SetImage(string base64Representation)
    {
        Sprite sprite = ConvertBase64ToSprite(base64Representation);
        _image.sprite = sprite;
    }

    private Sprite ConvertBase64ToSprite(string base64Representation)
    {
        byte[] imageBytes = Convert.FromBase64String(base64Representation);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(imageBytes);

        return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }
}
