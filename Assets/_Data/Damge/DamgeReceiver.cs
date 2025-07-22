using UnityEngine;

public class DamgeReceiver : HCLMonoBehaviour
{
    [SerializeField] protected float hp = 1;
    [SerializeField] protected float maxHp = 2;
    protected override void Start()
    {
        base.Start();
        this.Reborn();
    }
    protected virtual void Reborn()
    {
        this.hp= this.maxHp;
    }
    public virtual void Add(float hpAdd)
    {
        this.hp += hpAdd;
        if (this.hp > maxHp) this.hp = this.maxHp;
    }
    public virtual void Deduct(float hpDeduct)
    {
        this.hp -= hpDeduct;
        if (this.hp < 0) this.hp = 0;
    }
    protected virtual bool IsDead()
    {
        return this.hp < 0;
    }
}
