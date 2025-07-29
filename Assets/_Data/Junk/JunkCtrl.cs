using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Transform = UnityEngine.Transform;

public class JunkCtrl : HCLMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [SerializeField] protected JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn { get => junkDespawn; }

    [SerializeField] protected JunkSO junkSO;
    public JunkSO JunkSO => junkSO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadJunkDespawn();
        this.LoadJunkSO();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.LogWarning(transform.name + ": LoadModel", gameObject);
    }

    protected virtual void LoadJunkDespawn()
    {
        if (this.junkDespawn != null) return;
        this.junkDespawn = transform.GetComponentInChildren<JunkDespawn>();
        Debug.LogWarning(transform.name + ": LoadJunkDespawn", gameObject);
    }

    protected virtual void LoadJunkSO()
    {
        if (this.junkSO != null) return;
        string resPath = "Junk/" + transform.name;
        this.junkSO = Resources.Load<JunkSO>(resPath);
        Debug.LogWarning(transform.name + ": LoadJunkSO " + resPath, gameObject);
    }
}
