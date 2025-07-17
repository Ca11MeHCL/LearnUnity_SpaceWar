using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] protected List<Transform> prefabs;

    protected void Reset()
    {
        this.LoadComponents();
    }
    protected void Awake()
    {
        this.HidePrefabs();
    }
    protected virtual void LoadComponents()
    {
        this.LoadPrefabs();
    }
    protected virtual void LoadPrefabs()
    {
        Transform prefabObj = transform.Find("Prefabs");
        foreach (Transform Prefab in prefabObj)
        {
            this.prefabs.Add(Prefab);
        }
    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform Prefab in this.prefabs)
        {
            Prefab.gameObject.SetActive(false);
        }
    }
}
