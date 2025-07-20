using UnityEngine;

public class JunkRandom : HCLMonoBehaviour
{
    [SerializeField] protected JunkCtrl junkCtrl;
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }
    protected virtual void LoadJunkCtrl()
    {
        if(this.junkCtrl != null) return;
        this.junkCtrl = GetComponent<JunkCtrl>();
    }

    protected override void Start()
    {
        this.JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        Transform randomPoint= this.junkCtrl.SpawnPoints.GetRamdomPoint();
        Vector3 pos = randomPoint.position;
        Quaternion rot = transform.rotation;
        Transform obj= this.junkCtrl.JunkSpawner.Spawn(JunkSpawner.meteoriteOne, pos, rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), 1f);
    }
}
