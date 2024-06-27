using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseOutcome : MonoBehaviour, IOutcome
{
    public Vector3 targetRotation;
    public GameObject Bullseye { get; set; }

    public Vector3 TargetRotation
    {
        get { return targetRotation; }
        set { targetRotation = value; }
    }

    protected virtual void Update()
    {

    }

    protected virtual void Start()
    {
        Debug.Log("Base Outcome Start");
        // Find the first child with the tag "Bullseye" and assign it to Bullseye
        foreach (Transform child in transform)
        {
            if (child.CompareTag("Bullseye"))
            {
                Bullseye = child.gameObject;
                break;
            }
        }
        if (Bullseye == null)
        {
            Debug.LogError("Child with tag Bullseye not found");
        }
    }

  

    public abstract void Execute();
}
