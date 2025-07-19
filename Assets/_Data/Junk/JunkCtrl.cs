using UnityEngine;

public class JunkCtrl : HCLMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get => junkSpawner; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();

    }
    protected virtual void LoadJunkSpawner()
    {
        if (this.junkSpawner != null) return;
        this.junkSpawner = GetComponent<JunkSpawner>();
    }
}
