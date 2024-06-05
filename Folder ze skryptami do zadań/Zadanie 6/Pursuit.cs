using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;

    void Update()
    {
        Vector3 playerDirection = player.position - transform.position;
        float distance = playerDirection.magnitude;
        float playerSpeed = player.GetComponent<Rigidbody>().velocity.magnitude;
        float predictionTime = distance / speed;

        Vector3 predictedPosition = player.position + player.forward * playerSpeed * predictionTime;
        Vector3 direction = (predictedPosition - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
