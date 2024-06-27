using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutcomeHUD : BaseOutcome
{
    public Text messageText;
    public string message;
    public float timeToLive;
    private float elapsedTime;

    protected override void Start()
    {
        base.Start(); // Call the base class Start method if needed
        elapsedTime = 0f;
    }

    protected override void Update()
    {
        base.Update(); // Call the base class Update method if needed

        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeToLive)
        {
            Destroy(gameObject);
        }
    }

    public override void Execute()
    {
        Debug.Log("Outcome HUD executed");

        // Instantiate itself
        GameObject instance = Instantiate(gameObject, Vector3.zero, Quaternion.identity);

        // Find the messageText component in the instance
        OutcomeHUD outcomeHUDInstance = instance.GetComponent<OutcomeHUD>();
        if (outcomeHUDInstance != null)
        {
            outcomeHUDInstance.messageText.text = message;
            outcomeHUDInstance.timeToLive = timeToLive; // Ensure the timeToLive is set for the instance
        }
    }

}

