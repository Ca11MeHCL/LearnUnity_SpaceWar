using UnityEngine;

public class HCLMonoBehaviour : MonoBehaviour
{
    protected virtual void Start()
    {
        //OverWrite
    }
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        //OverWrite
    }
    
}
