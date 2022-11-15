using System.Collections;
using UnityEngine;

public class CatManager : MonoBehaviour
{
    private API _api;
    private CatDataHandler _catDataHandler;

    void Awake()
    {
        _api = GetComponent<API>();
        _catDataHandler = GetComponentInChildren<CatDataHandler>();
    }

    public void GetCat()
    {
        StartCoroutine(GetAndApplyCatData());
    }

    private IEnumerator GetAndApplyCatData()
    {
        Cat newCat = new Cat();
        yield return _api.GetCatFromAPI(cat => newCat = cat);

        _catDataHandler.ApplyData(newCat);
    }
}
