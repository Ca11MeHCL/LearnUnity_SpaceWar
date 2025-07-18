using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : HCLMonoBehaviour
{

    [SerializeField] protected List<Transform> prefabs;

    protected override void LoadComponents()
    {
        this.LoadPrefabs();
    }
    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;

        Transform prefabObj = transform.Find("Prefabs");
        foreach (Transform Prefab in prefabObj)
        {
            this.prefabs.Add(Prefab);
        }
        this.HidePrefabs();

        Debug.Log(transform.name + ": LoadPrefabs() ",gameObject);
    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform Prefab in this.prefabs)
        {
            Prefab.gameObject.SetActive(false);
        }
    }
    public virtual Transform Spawn(string prefabName, Vector3 spawnPos, Quaternion rotation)
    {
        Transform prefab = this.GetPrefabByName(prefabName);
        if (prefab == null)
        {
            Debug.LogWarning("Prefab not found: " + prefabName);
            return null;
        }

        Transform newPrefabs = Instantiate(prefab, spawnPos, rotation);
        return newPrefabs;
    }
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach(Transform prefab in this.prefabs)
        {
            if (prefab.name == prefabName)
            {
                return prefab;
            }
        }
        return null;
    }

}
