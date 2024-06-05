using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;

    public float speed = 4f;
    void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
