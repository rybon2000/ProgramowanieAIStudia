using UnityEngine;

public class DistanceBetweenPlayerAndGameObject : MonoBehaviour
{
    public Transform player;
    public Transform point;

    void Update()
    {
        float distance = Vector3.Distance(player.position, point.position);
        Debug.Log(distance);
    }
}
