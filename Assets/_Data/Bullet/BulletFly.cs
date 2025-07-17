using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] protected int flySpeed = 1;
    [SerializeField] protected Vector3 direction = Vector3.right;

    private void Update()
    {
        transform.parent.Translate(this.direction* this.flySpeed* Time.deltaTime);
    }
}
