using UnityEngine;

[System.Serializable]
public class CatModel
{
    public string name;
    public string description;
    public string color;
    public bool enable;
    public string qr_code;

    public static CatModel FromJson(string jsonString)
    {
        return JsonUtility.FromJson<CatModel>(jsonString);
    }
}
