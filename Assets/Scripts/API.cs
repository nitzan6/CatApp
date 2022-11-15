using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class API : MonoBehaviour
{
    private const string NAME = "Nitzan";
    private const string URL = "https://pusbkbbia3.execute-api.us-east-1.amazonaws.com/default/get_cat";

    private User _sendData = new User { name = NAME };
    private string _serializedSendData;

    void Awake()
    {
        _serializedSendData = JsonUtility.ToJson(_sendData);
    }

    public IEnumerator GetCatFromAPI(System.Action<Cat> onReceivedData)
    {
        using UnityWebRequest www = UnityWebRequest.Post(URL, "POST");
        www.SetRequestHeader("Content-Type", "application/json");
        www.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(_serializedSendData));

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            string result = www.downloadHandler.text;

            if (onReceivedData != null)
            {
                Cat catData = Cat.FromJson(result);
                onReceivedData(catData);
            }
        }
    }
}
