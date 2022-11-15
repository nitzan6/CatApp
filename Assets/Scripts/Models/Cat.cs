using UnityEngine;

[System.Serializable]
public class Cat
{
    public string name;
    public string description;
    public string color;
    public bool enable;
    public string qr_code;

    public static Cat FromJson(string jsonString)
    {
        return JsonUtility.FromJson<Cat>(jsonString);
    }
}
