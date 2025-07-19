using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : HCLMonoBehaviour
{
    [SerializeField] protected Transform holder;
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> poolObjs;

    protected override void LoadComponents()
    {
        this.LoadPrefabs();
        this.LoadHolder();
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
    protected virtual void LoadHolder()
    {
        if(this.holder != null) return;
        this.holder = transform.Find("Holder");
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

        Transform newPrefabs = this.GetObjectFromPool(prefab);
        newPrefabs.SetPositionAndRotation(spawnPos, rotation);

        newPrefabs.parent = this.holder;
        return newPrefabs;
    }

    protected virtual Transform GetObjectFromPool(Transform prefab)
    {
        foreach(Transform poolObj in this.poolObjs)
        {
            if(poolObj.name== prefab.name)
            {
                this.poolObjs.Remove(poolObj);
                return poolObj;
            }
        }

        Transform newPrefab= Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }
    public virtual Transform GetPrefabByName(string prefabName)
    {
        foreach(Transform prefab in this.prefabs)
        {
            if (prefab.name == prefabName) return prefab;
        }
        return null;
    }
    public virtual void Despawn(Transform obj)
    {
        this.poolObjs.Add(obj);
        obj.gameObject.SetActive(false);
    }

}
