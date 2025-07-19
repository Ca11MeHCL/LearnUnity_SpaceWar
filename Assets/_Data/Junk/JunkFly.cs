using UnityEngine;

public class JunkFly : ParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 1f;
    }
}
