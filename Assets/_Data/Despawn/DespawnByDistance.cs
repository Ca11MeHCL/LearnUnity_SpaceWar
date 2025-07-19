using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 70f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Camera mainCam;
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
    protected override void LoadComponents()
    {
        this.LoadCamera();
    }
    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = FindObjectOfType<Camera>();
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
    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.transform.position);
        if (this.distance > this.disLimit) return true;
        return false;
    }
}
