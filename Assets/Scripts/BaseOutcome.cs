using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public abstract class BaseOutcome : MonoBehaviour, IOutcome
{
    [SerializeField] private Vector3 targetRotation;
    [SerializeField] private GameObject bullseye;
    [SerializeField] private float timeToLive;
    private float elapsedTime = 0f;

    public GameObject Bullseye //{ get; set; }
    {
        get
        {
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
    [SerializeField]
    public Vector3 TargetRotation
    {
        get { return targetRotation; }
        set { targetRotation = value; }
    }

    public float TimeToLive
    {
        get { return timeToLive; }
        set { TimeToLive = value; }
    }

    protected void Update()
    {
        if (timeToLive > 0f)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= timeToLive)
            {
                Destroy(gameObject);
            }
        }

    }

    public abstract void Execute();
}
