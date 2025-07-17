using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] protected Vector3 mouseWorldPos;
    public  Vector3 MouseWorldPos { get => mouseWorldPos; }

    private void Awake()
    {
        InputManager.instance = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePos();

    }
    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
