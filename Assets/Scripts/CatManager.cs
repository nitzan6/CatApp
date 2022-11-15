using System.Collections;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    private API _api;
    private CatDataHandler _catDataHandler;

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
        CatModel newCat = new CatModel();

        yield return _api.GetCatFromAPI(cat => newCat = cat);

        Debug.Log(newCat.description);
    }
}
