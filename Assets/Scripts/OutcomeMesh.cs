using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutcomeMesh : BaseOutcome
{
    public override void Execute()
    {
        // Implementation for Outcome A
        Debug.Log("Outcome Mesh executed");
        // Example: Rotate the GameObject to the target rotation
        transform.rotation = Quaternion.Euler(TargetRotation);
        // Example: Move the GameObject to the bullseye position
        transform.position = Bullseye.transform.position;

        // Instantiate the prefab and find the bullseye within it
        GameObject instance = Instantiate(gameObject, Vector3.zero, Quaternion.identity);
    }
}
