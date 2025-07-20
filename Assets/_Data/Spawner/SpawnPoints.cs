using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoints : HCLMonoBehaviour
{
    [SerializeField] protected List<Transform> points;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPoints();  
    }
    protected virtual void LoadPoints()
    {
        if (points == null) return;
        foreach (Transform point in transform)
        {
            points.Add(point);
        }
    }
    public virtual Transform GetRamdomPoint()
    {
        int rand= Random.Range(0, this.points.Count);
        return this.points[rand];
    }
}
