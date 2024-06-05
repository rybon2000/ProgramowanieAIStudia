using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public List<Transform> pointList = new List<Transform>();
    public NavMeshAgent agent;
    private int currentIndex;
    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            MoveToTarget();
        }
    }
    public void MoveToTarget()
    {
        if (pointList.Count == 0)
        {
            return;
        }

        agent.SetDestination(pointList[currentIndex].position);
        currentIndex++;
        if (currentIndex >= pointList.Count)
        {
            currentIndex = 0;
        }
    }
}
