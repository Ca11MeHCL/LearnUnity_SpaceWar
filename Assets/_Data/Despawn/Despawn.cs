using System;
using UnityEngine;

public  abstract class Despawn : HCLMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    
    protected virtual void Despawning()
    {
        if (!this.CanDespawn()) return;
        {
            this.DespawnObject();
        }
    }
    protected virtual void DespawnObject()
    {
        Destroy(this.transform.parent.gameObject);
    }
    protected abstract bool CanDespawn();
}
