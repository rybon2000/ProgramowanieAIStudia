using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekAndFlee : MonoBehaviour
{
    public Transform player;
    public float seekDistance = 10f;
    public float fleeDistance = 5f;
    public float speed = 5f;

    void Update()
    {
        Vector3 playerDirection = player.position - transform.position;
        if (playerDirection.magnitude < seekDistance)
        {
            Vector3 direction = playerDirection.normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
        else if (playerDirection.magnitude < fleeDistance)
        {
            Vector3 direction = -playerDirection.normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
