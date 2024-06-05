using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    void Update()
    {
        Vector3 playerDirection = player.position - transform.position;
        Vector3 predictedPosition = player.position + player.forward * playerDirection.magnitude / speed;
        Vector3 direction = (predictedPosition - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
