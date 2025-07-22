using UnityEngine;

public class FollowTarget : HCLMonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float speed= 2f;
    protected virtual void FixedUpdate()
    {
        this.Following();
    }
    protected virtual void Following()
    {
        if (this.target == null) return;

        Vector3 current = transform.position;
        Vector3 targetPos = new Vector3(this.target.position.x, this.target.position.y, current.z);

        transform.position = Vector3.Lerp(current, targetPos, this.speed * Time.fixedDeltaTime);
    }

}
