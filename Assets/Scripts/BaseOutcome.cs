using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseOutcome : MonoBehaviour, IOutcome
{
    public Vector3 targetRotation;
    private GameObject bullseye;

    public GameObject Bullseye
    {
        get {

            bullseye = GetComponentsInChildren<Transform>(true)
                .FirstOrDefault(t => t.CompareTag("Bullseye"))?.gameObject;

            if (bullseye == null)
            {
                Debug.LogError("Child with tag Bullseye not found");
            }

            return bullseye;

        }
        set { bullseye = value; }
    }

    public Vector3 TargetRotation
    {
        get { return targetRotation; }
        set { targetRotation = value; }
    }


    protected virtual void Awake()
    {
        Debug.Log("Base Outcome Awake");
        // Find the first child with the tag "Bullseye" and assign it to Bullseye
        
    }

    public abstract void Execute();
}
