using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootDelay = 0.5f;
    [SerializeField] protected float shootTimer = 0f;
    [SerializeField] protected Transform bulletPrefab;

    private void Update()
    {
        this.IsShooting();
        
    }
    private void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (!this.isShooting) return;

        this.shootTimer += Time.fixedDeltaTime;
        if(this.shootTimer < shootDelay ) return;
        this.shootTimer = 0;
        
        Vector3 spawnPos = transform.parent.position;
        Quaternion rotation= transform.parent.rotation;
        Transform newBullet= Instantiate(this.bulletPrefab,spawnPos,rotation);
        newBullet.gameObject.SetActive(true);
    }
    protected virtual bool IsShooting()
    {
        this.isShooting= InputManager.Instance.OnFiring==1;
        return this.isShooting;
    }
}
