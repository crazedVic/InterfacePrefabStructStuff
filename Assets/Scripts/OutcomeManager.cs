using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeManager : MonoBehaviour
{
    public OutcomeProbability[] outcomeProbabilities;
    public Rigidbody ball;
    private Vector3 initialBallPosition;

    void Start()
    {
        if (ball != null)
        {
            initialBallPosition = ball.transform.position;
        }
        else
        {
            Debug.LogError("Ball Rigidbody is not assigned.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ExecuteOutcome();
            ResetBallPosition();
        }
    }

    void ExecuteOutcome()
    {
        float totalProbability = 0;
        foreach (var outcomeProbability in outcomeProbabilities)
        {
            totalProbability += outcomeProbability.probability;
        }

        float randomValue = Random.Range(0, totalProbability);
        float cumulativeProbability = 0;

        foreach (var outcomeProbability in outcomeProbabilities)
        {
            cumulativeProbability += outcomeProbability.probability;
            if (randomValue <= cumulativeProbability)
            {
                var outcome = outcomeProbability.Outcome;
                if (outcome != null)
                {
                    Debug.Log(outcome.Bullseye.transform.position);
                    // wait to hit, then call:
                    outcome.Execute();
                }
                break;
            }
        }
    }

    void ResetBallPosition()
    {
        if (ball != null)
        {
            ball.transform.position = initialBallPosition;
            ball.velocity = Vector3.zero; // Stop the ball's movement
            ball.angularVelocity = Vector3.zero; // Stop the ball's rotation
        }
    }
}
