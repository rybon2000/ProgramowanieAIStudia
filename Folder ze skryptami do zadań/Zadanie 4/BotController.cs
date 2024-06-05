using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour
{
    public NavMeshAgent bot;
    public Transform[] checkpoints;
    private int currentCheckpointIndex = 0;
    public void  MoveBotToNextCheckpoint()
    {
        if (currentCheckpointIndex < checkpoints.Length)
        {
            bot.SetDestination(checkpoints[currentCheckpointIndex].position);
            currentCheckpointIndex++;
        }
    }
}
