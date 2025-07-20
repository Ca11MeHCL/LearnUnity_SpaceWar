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
        this.ResetValue();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        //OverWrite
    }
    protected virtual void ResetValue()
    {
        //OverWrite
    }
    protected virtual void OnEnable()
    {
        //For override
    }
    protected virtual void OnDisable()
    {
        //For override
    }

}
