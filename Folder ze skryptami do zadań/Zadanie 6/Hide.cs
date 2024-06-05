using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    public LayerMask obstaclesLayer;

    void Update()
    {
        Vector3 hideSpot = FindBestHideSpot();
        if (hideSpot != Vector3.zero)
        {
            Vector3 direction = (hideSpot - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    Vector3 FindBestHideSpot()
    {
        Collider[] obstacles = Physics.OverlapSphere(transform.position, 20f, obstaclesLayer);
        Vector3 bestSpot = Vector3.zero;
        float bestDistance = Mathf.Infinity;

        foreach (var obstacle in obstacles)
        {
            Vector3 hideDirection = (obstacle.transform.position - player.position).normalized;
            Vector3 potentialSpot = obstacle.transform.position + hideDirection * obstacle.bounds.extents.magnitude;

            float distanceToSpot = Vector3.Distance(transform.position, potentialSpot);
            if (distanceToSpot < bestDistance)
            {
                bestDistance = distanceToSpot;
                bestSpot = potentialSpot;
            }
        }

        return bestSpot;
    }
}
