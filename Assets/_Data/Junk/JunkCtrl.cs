using UnityEngine;

public class JunkCtrl : HCLMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (Model != null) return;
        this.model = transform.Find("Model");
    }
}
