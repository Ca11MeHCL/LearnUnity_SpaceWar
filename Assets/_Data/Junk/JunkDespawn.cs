using UnityEngine;

public class JunkDespawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 25f;
    }
}
