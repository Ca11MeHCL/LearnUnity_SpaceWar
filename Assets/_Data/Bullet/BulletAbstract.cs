using UnityEngine;

public class BulletAbstract : HCLMonoBehaviour
{
    [Header("Bullet Abstract")]
    [SerializeField] protected BulletController bulletCtrl;
    public BulletController BulletCtrl { get => bulletCtrl; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBulletCtrl();
    }
    protected virtual void LoadBulletCtrl()
    {
        if(this.bulletCtrl != null) return;
        this.bulletCtrl= transform.parent.GetComponent<BulletController>();
    }
}
