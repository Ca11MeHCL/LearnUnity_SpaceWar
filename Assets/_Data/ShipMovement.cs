using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPosition;
    [SerializeField] protected float speed = 0.1f;
    private void FixedUpdate()
    {
        this.worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPosition.z = 0;
        Vector3 newPos= Vector3.Lerp(transform.position, worldPosition, this.speed);
        transform.position = newPos;
    }
}
