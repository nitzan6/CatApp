using System.Collections;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    private API _api;

    void Awake()
    {
        _api = GetComponent<API>();
    }

    public void GetCat()
    {
        StartCoroutine(GetAndTransferCatData());
    }

    private IEnumerator GetAndTransferCatData()
    {
        string data = string.Empty;

        yield return _api.GetCatDataFromAPI(s => data = s);

        Debug.Log(data);
    }
}
