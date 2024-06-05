using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade : MonoBehaviour
{
    public Transform player;
    public float safeDistance = 10f;
    public float speed = 5f;

    void Update()
    {
        Vector3 playerDirection = player.position - transform.position;
        if (playerDirection.magnitude < safeDistance)
        {
            Vector3 randomDirection = (Random.insideUnitSphere * safeDistance).normalized;
            Vector3 evadeDirection = transform.position + randomDirection;
            Vector3 direction = (evadeDirection - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
